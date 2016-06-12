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

namespace Jotun.Views.PO
{
    public partial class FrmPenerimaan : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtdetail;

        private static FrmPenerimaan instance;

        public static FrmPenerimaan GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPenerimaan();
            }
            return instance;
        }

        private void HitungTotal()
        {
            double total_liter = 0;
            double total_qty = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                total_liter += Convert.ToDouble(gridView1.GetRowCellValue(i, "liter"));
                total_qty += Convert.ToInt32(gridView1.GetRowCellValue(i, "qty"));
            }
            txt_total_liter.EditValue = total_liter;
            txt_total_qty.EditValue = total_qty;
        }

        private void init()
        {
            var txt = new TextEdit[] { txt_no_penerimaan, txt_haulier, txt_order_number, txt_incoterm, txt_ship_from, txt_ship_to, txt_vat_reg };
            foreach (var t in txt)
            {
                t.EditValue = "";
            }

            dtp_date.EditValue = DateTime.Now;
            dtp_order_date.EditValue = DateTime.Now;
            dtp_delivery_date.EditValue = DateTime.Now;

            txt_total_liter.EditValue = 0;
            txt_total_qty.EditValue = 0;

            dtdetail = new DataTable();
            dtdetail.Columns.Add("kd_barang", typeof(string));
            dtdetail.Columns.Add("nama", typeof(string));
            dtdetail.Columns.Add("no_batch", typeof(string));
            dtdetail.Columns.Add("qty", typeof(int));
            dtdetail.Columns.Add("ukuran", typeof(double));
            dtdetail.Columns.Add("liter", typeof(double));
            dtdetail.Rows.Add(null, "", "", 0, 0, 0);

            gridControl1.DataSource = dtdetail;

        }

        public FrmPenerimaan()
        {
            InitializeComponent();
        }

        private void FrmPenerimaan_Load(object sender, EventArgs e)
        {
            cbo_kd_barang.DataSource = Controllers.CBarang.get_data();

            this.init();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dtdetail.Rows.Add(null, "", "", 0, 0, 0);
                this.HitungTotal();
            }
            else
            {
                gridView1.DeleteSelectedRows();
                this.HitungTotal();
            }
        }

        private void cbo_kd_barang_EditValueChanged(object sender, EventArgs e)
        {
            var cbo = (SearchLookUpEdit)sender;
            var view = cbo.Properties.View;
            var index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "kd_barang");
            if (row != null)
            {
                int[] indexgrid = gridView1.GetSelectedRows();
                gridView1.SetRowCellValue(indexgrid[0], "nama", view.GetRowCellValue(index, "nama"));
                gridView1.SetRowCellValue(indexgrid[0], "ukuran", view.GetRowCellValue(index, "ukuran"));
                gridView1.SetRowCellValue(indexgrid[0], "no_batch", view.GetRowCellValue(index, "no_batch"));

                this.HitungTotal();
            }
        }

        private void spin_qty_ValueChanged(object sender, EventArgs e)
        {
            int[] indexgrid = gridView1.GetSelectedRows();
            string barang = gridView1.GetRowCellDisplayText(indexgrid[0], "nama").ToString();
            if (barang != "")
            {
                SpinEdit spin = (SpinEdit)sender;
                int qty = Convert.ToInt32(spin.EditValue);

                double ukuran = Convert.ToDouble(gridView1.GetRowCellValue(indexgrid[0], "ukuran"));

                double liter = qty * ukuran;

                gridView1.SetRowCellValue(indexgrid[0], "liter", liter);

                this.HitungTotal();
            }
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_no_penerimaan.EditValue.ToString() == "")
            {
                Helpers.Generic.MsgEx("No. D/T Tidak boleh Kosong");
                return;
            }
            else if (txt_order_number.EditValue.ToString() == "")
            {
                Helpers.Generic.MsgEx("Order Number Tidak boleh kosong");
                return;
            }

            var data = new Models.penerimaan()
            {
                no_penerimaan = txt_no_penerimaan.EditValue.ToString(),
                date = Convert.ToDateTime(dtp_date.EditValue),
                order_date = Convert.ToDateTime(dtp_order_date.EditValue),
                delivery_date = Convert.ToDateTime(dtp_delivery_date.EditValue),
                incoterm = txt_incoterm.EditValue.ToString(),
                order_number = Convert.ToInt32(txt_order_number.EditValue),
                ship_from = txt_ship_from.EditValue.ToString(),
                haulier = txt_haulier.EditValue.ToString(),
                ship_to = txt_ship_to.EditValue.ToString(),
                total_liter = Convert.ToDouble(txt_total_liter.EditValue),
                total_qty = Convert.ToDouble(txt_total_qty.EditValue)
            };

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                var detail = new Models.detail_penerimaan()
                {
                    no_penerimaan = txt_no_penerimaan.EditValue.ToString(),
                    kd_barang = gridView1.GetRowCellValue(i, "kd_barang").ToString(),
                    qty = Convert.ToInt32(gridView1.GetRowCellValue(i, "qty")),
                    ukuran = Convert.ToDouble(gridView1.GetRowCellValue(i , "ukuran")),
                    total = Convert.ToDouble(gridView1.GetRowCellValue(i , "liter"))
                };
                data.detail_penerimaans.Add(detail);
            }

            if (Controllers.PO.CPenerimaan.insert(data))
            {
                Helpers.Generic.MsgInfo("Data penerimaan barang berhasil disimpan");
            }
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void spin_qty_Leave(object sender, EventArgs e)
        {
            this.HitungTotal();
        }
    }
}