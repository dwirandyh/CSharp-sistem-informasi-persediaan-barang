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
    public partial class FrmPO : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtdetail;
        private static FrmPO instance;

        public static FrmPO GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmPO();
            }
            return instance;
        }

        private void init()
        {
            var txt = new TextEdit[] { txt_no_po, txt_term, txt_project, txt_nama, txt_alamat };
            foreach (var t in txt)
            {
                t.EditValue = "";
            }
            dtp_tgl.EditValue = DateTime.Now;
            txt_sub_total.EditValue = 0;
            txt_ppn.EditValue = 0;
            txt_total.EditValue = 0;

            dtdetail = new DataTable();
            dtdetail.Columns.Add("kd_barang", typeof(string));
            dtdetail.Columns.Add("nama", typeof(string));
            dtdetail.Columns.Add("qty", typeof(int));
            dtdetail.Columns.Add("ukuran", typeof(double));
            dtdetail.Columns.Add("tipe", typeof(string));
            dtdetail.Columns.Add("liter", typeof(double));
            dtdetail.Columns.Add("harga", typeof(int));
            dtdetail.Columns.Add("total", typeof(int));
            dtdetail.Columns.Add("stok", typeof(int));
            dtdetail.Rows.Add("Pilih Kode Barang", "", 0, 0, "", 0, 0, 0);
            gridControl1.DataSource = dtdetail;
        }

        private void HitungTotal()
        {
            int subtotal = 0;
            int total = 0;
            double ppn = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                int sub = Convert.ToInt32(gridView1.GetRowCellValue(i, "total"));
                subtotal += sub;
            }

            ppn = subtotal * 0.1;
            total = Convert.ToInt32(subtotal + ppn);
            txt_total.EditValue = total;
            txt_ppn.EditValue = ppn;
            txt_sub_total.EditValue = subtotal;
        }

        public FrmPO()
        {
            InitializeComponent();
        }

        private void FrmPO_Load(object sender, EventArgs e)
        {
            var customer = Controllers.CCustomer.get_data();
            cbo_kd_customer.Properties.DataSource = customer;
            cbo_kd_barang.DataSource = Controllers.CBarang.get_data();

            this.init();
        }

        private void cbo_kd_customer_EditValueChanged(object sender, EventArgs e)
        {
            var view = cbo_kd_customer.Properties.View;
            int index = view.FocusedRowHandle;
            object row = view.GetRowCellValue(index, "kd_customer");
            if (row != null)
            {
                txt_nama.EditValue = view.GetRowCellValue(index, "nama");
                txt_alamat.EditValue = view.GetRowCellValue(index, "alamat");
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
                if (Convert.ToInt32(view.GetRowCellValue(index, "stok")) == 0)
                {
                    Helpers.Generic.MsgEx("Stok tidak cukup");
                    return;
                }

                int[] indexgrid = gridView1.GetSelectedRows();
                gridView1.SetRowCellValue(indexgrid[0], "nama", view.GetRowCellValue(index, "nama"));
                gridView1.SetRowCellValue(indexgrid[0], "ukuran", view.GetRowCellValue(index, "ukuran"));
                gridView1.SetRowCellValue(indexgrid[0], "qty", "1");
                gridView1.SetRowCellValue(indexgrid[0], "tipe", view.GetRowCellValue(index, "tipe"));
                gridView1.SetRowCellValue(indexgrid[0], "harga", view.GetRowCellValue(index, "harga"));
                gridView1.SetRowCellValue(indexgrid[0], "liter", view.GetRowCellValue(index, "ukuran"));
                gridView1.SetRowCellValue(indexgrid[0], "stok", view.GetRowCellValue(index, "stok"));
                gridView1.SetRowCellValue(indexgrid[0], "total", Convert.ToDouble(view.GetRowCellValue(index, "harga")) * Convert.ToDouble(view.GetRowCellValue(index, "ukuran")));

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
                if (qty > Convert.ToInt32(gridView1.GetRowCellValue(indexgrid[0], "stok")))
                {
                    Helpers.Generic.MsgEx("Stok tidak mencukupi, sisa stok " + gridView1.GetRowCellValue(indexgrid[0], "stok"));
                    return;
                }

                int harga = Convert.ToInt32(gridView1.GetRowCellValue(indexgrid[0], "harga"));
                double ukuran = Convert.ToDouble(gridView1.GetRowCellValue(indexgrid[0], "ukuran"));

                double liter = qty * ukuran;
                int total = Convert.ToInt32(liter * harga);

                gridView1.SetRowCellValue(indexgrid[0], "liter", liter);
                gridView1.SetRowCellValue(indexgrid[0], "total", total);

                this.HitungTotal();
            }
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var customer = cbo_kd_customer.EditValue;
            if (customer == null)
            {
                Helpers.Generic.MsgEx("Data customer tidak boleh kosong");
                return;
            }
            else if (gridView1.RowCount == 0)
            {
                Helpers.Generic.MsgEx("Detail barang tidak boleh kosong");
                return;
            }

            var data = new Models.po()
            {
                no_po = txt_no_po.EditValue.ToString(),
                kd_customer = cbo_kd_customer.EditValue.ToString(),
                tgl = Convert.ToDateTime(dtp_tgl.EditValue),
                term = txt_term.EditValue.ToString(),
                project = txt_project.EditValue.ToString(),
                sub_total = Convert.ToInt32(txt_sub_total.EditValue),
                ppn = Convert.ToInt32(txt_ppn.EditValue),
                total = Convert.ToInt32(txt_total.EditValue)
            };

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                if (Convert.ToInt32(gridView1.GetRowCellValue(i, "qty")) > 0)
                {
                    var detail = new Models.detailpo()
                    {
                        no_po = txt_no_po.EditValue.ToString(),
                        kd_barang = gridView1.GetRowCellValue(i, "kd_barang").ToString(),
                        qty = Convert.ToInt32(gridView1.GetRowCellValue(i, "qty")),
                        liter = Convert.ToInt32(gridView1.GetRowCellValue(i, "liter")),
                        harga = Convert.ToInt32(gridView1.GetRowCellValue(i, "harga")),
                        total = Convert.ToInt32(gridView1.GetRowCellValue(i, "total"))
                    };
                    data.detailpos.Add(detail);
                }
            }

            if (Controllers.PO.CPO.insert(data))
            {
                Helpers.Generic.MsgInfo("Data PO berhasil disimpan");
                this.init();
            }
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                dtdetail.Rows.Add("Pilih Kode Barang", "", 0, 0, "", 0, 0, 0);
            }
            else if (e.KeyData == Keys.Delete)
            {
                gridView1.DeleteSelectedRows();
                this.HitungTotal();
            }
        }
    }
}