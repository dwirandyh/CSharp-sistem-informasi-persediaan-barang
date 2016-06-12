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
    public partial class FrmSuratJalan : DevExpress.XtraEditors.XtraForm
    {
        private static FrmSuratJalan instance;
        public static FrmSuratJalan GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmSuratJalan();
            }
            return instance;
        }

        private void init()
        {
            txt_no_sj.EditValue = Controllers.Penjualan.CSuratJalan.get_kode();
            dtp_tgl_po.EditValue = DateTime.Now;
            dtp_tgl_sj.EditValue = DateTime.Now;

            txt_sub_total.EditValue = 0;
            cbo_no_po.EditValue = null;
            gridControl1.DataSource = null;

            var txt = new TextEdit[] { txt_kd_customer, txt_nm_customer, txt_po_pr };
            foreach (var t in txt)
            {
                t.EditValue = "";
            }
        }

        private void cetak()
        {
            var frm = new Laporan.FrmRptViewer();
            frm.rptname = "SuratJalan.repx";
            frm.ds = Controllers.Penjualan.CSuratJalan.get_report(txt_no_sj.EditValue.ToString());
            Helpers.Generic.ShowAdd(this, frm);
        }

        public FrmSuratJalan()
        {
            InitializeComponent();
        }

        private void FrmSuratJalan_Load(object sender, EventArgs e)
        {
            cbo_no_po.Properties.DataSource = Controllers.Penjualan.CSuratJalan.get_po();
            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbo_no_po.EditValue == null)
            {
                Helpers.Generic.MsgEx("No. PO tidak boleh kosong");
                return;
            }

            var data = new Models.surat_jalan()
            {
                no_surat_jalan = txt_no_sj.EditValue.ToString(),
                no_po = cbo_no_po.EditValue.ToString(),
                kd_customer = txt_kd_customer.EditValue.ToString(),
                tgl = Convert.ToDateTime(dtp_tgl_sj.EditValue),
                total_ukuran = Convert.ToDouble(txt_sub_total.EditValue),
                po_pr = txt_po_pr.EditValue.ToString()
            };

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var detail = new Models.detail_surat_jalan()
                {
                    no_surat_jalan = txt_no_sj.EditValue.ToString(),
                    kd_barang = gridView1.GetRowCellValue(i, "kd_barang").ToString(),
                    qty = Convert.ToInt32(gridView1.GetRowCellValue(i, "qty")),
                    ukuran = Convert.ToDouble(gridView1.GetRowCellValue(i, "barang.ukuran")),
                    total_ukuran = Convert.ToDouble(gridView1.GetRowCellValue(i, "liter"))
                };
                data.detail_surat_jalans.Add(detail);
            }

            if (Controllers.Penjualan.CSuratJalan.insert(data))
            {
                Helpers.Generic.MsgInfo("Surat jalan berhasil disimpan");
                if (Helpers.Generic.MsgQuestion("Cetak surat jalan ?") == DialogResult.Yes)
                {
                    this.cetak();
                }
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

        private void cbo_no_po_EditValueChanged(object sender, EventArgs e)
        {
            var view = cbo_no_po.Properties.View;
            int index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "no_po");
            if (row != null)
            {
                dtp_tgl_po.EditValue = view.GetRowCellValue(index, "tgl");
                txt_kd_customer.EditValue = view.GetRowCellValue(index, "kd_customer");
                txt_nm_customer.EditValue = view.GetRowCellValue(index, "customer.nama");
                gridControl1.DataSource = Controllers.Penjualan.CSuratJalan.get_detail_po(row.ToString());

                double total = 0;
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    total += Convert.ToDouble(gridView1.GetRowCellValue(i, "liter"));
                }
                txt_sub_total.EditValue = total;
            }
        }
    }
}