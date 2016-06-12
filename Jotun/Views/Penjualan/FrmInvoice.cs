using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Jotun.Views.Penjualan
{
    public partial class FrmInvoice : DevExpress.XtraEditors.XtraForm
    {
        private static FrmInvoice instance;

        public static FrmInvoice GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmInvoice();
            }
            return instance;
        }

        private void cetak()
        {
            var frm = new Laporan.FrmRptViewer();
            frm.rptname = "Invoice.repx";
            frm.ds = Controllers.Penjualan.CInvoice.get_repot(txt_no_invoice.EditValue.ToString());
            Helpers.Generic.ShowAdd(this, frm);
        }

        private void init()
        {
            txt_no_invoice.EditValue = Controllers.Penjualan.CInvoice.get_kode();

            dtp_sj.EditValue = DateTime.Now;
            dtp_tgl_invoice.EditValue = DateTime.Now;

            cbo_no_surat_jalan.EditValue = null;
            gridControl1.DataSource = null;

            var txt = new TextEdit[] { txt_no_po, txt_kd_customer, txt_nm_customer, txt_total, txt_total_ukuran };
            foreach (var t in txt)
            {
                t.EditValue = "";
            }

            txt_total_bayar.EditValue = 0;
            txt_diskon.EditValue = 0;
            txt_total.EditValue = 0;
            txt_total_ukuran.EditValue = 0;
        }

        public FrmInvoice()
        {
            InitializeComponent();
        }

        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            cbo_no_surat_jalan.Properties.DataSource = Controllers.Penjualan.CInvoice.get_surat_jalan();

            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbo_no_surat_jalan.EditValue == null)
            {
                Helpers.Generic.MsgEx("No. Surat jalan tidak boleh kosong");
                return;
            }

            var data = new Models.invoice()
            {
                no_invoice = txt_no_invoice.EditValue.ToString(),
                tgl = Convert.ToDateTime(dtp_tgl_invoice.EditValue),
                no_surat_jalan = cbo_no_surat_jalan.EditValue.ToString(),
                kd_customer = txt_kd_customer.EditValue.ToString(),
                total_liter = Convert.ToDouble(txt_total_ukuran.EditValue),
                total = Convert.ToInt32(txt_total.EditValue),
                total_bayar = Convert.ToInt32(txt_total_bayar.EditValue),
                diskon = Convert.ToInt32(txt_diskon.EditValue)
            };

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var detail = new Models.detail_invoice()
                {
                    no_invoice = txt_no_invoice.EditValue.ToString(),
                    kd_barang = gridView1.GetRowCellValue(i, "kd_barang").ToString(),
                    qty = Convert.ToInt32(gridView1.GetRowCellValue(i, "qty")),
                    liter = Convert.ToDouble(gridView1.GetRowCellValue(i, "liter")),
                    harga = Convert.ToInt32(gridView1.GetRowCellValue(i, "harga")),
                    total = Convert.ToInt32(gridView1.GetRowCellValue(i, "total"))
                };
                data.detail_invoices.Add(detail);
            }

            if (Controllers.Penjualan.CInvoice.insert(data))
            {
                Helpers.Generic.MsgInfo("Invoice berhasil disimpan");
                this.cetak();
            }

            this.init();
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbo_no_surat_jalan_EditValueChanged(object sender, EventArgs e)
        {
            var view = cbo_no_surat_jalan.Properties.View;
            int index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "no_po");
            if (row != null)
            {
                dtp_sj.EditValue = Convert.ToDateTime(view.GetRowCellValue(index, "tgl"));
                txt_no_po.EditValue = view.GetRowCellValue(index, "po.no_po").ToString();
                txt_kd_customer.EditValue = view.GetRowCellValue(index, "po.customer.kd_customer").ToString();
                txt_nm_customer.EditValue = view.GetRowCellValue(index, "po.customer.nama").ToString();

                gridControl1.DataSource = Controllers.Penjualan.CInvoice.get_detail_po(txt_no_po.EditValue.ToString());

                double total_liter = 0;
                int total = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    total += Convert.ToInt32(gridView1.GetRowCellValue(i, "total"));
                    total_liter += Convert.ToDouble(gridView1.GetRowCellValue(i, "liter"));
                }

                txt_total.EditValue = total;
                double diskon = total * (Convert.ToDouble(view.GetRowCellValue(index, "po.customer.diskon")) / 100);
                txt_diskon.EditValue = diskon;
                txt_total_bayar.EditValue = total - diskon;
                txt_total_ukuran.EditValue = total_liter;
            }
        }
    }
}