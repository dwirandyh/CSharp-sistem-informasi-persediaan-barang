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

namespace Jotun.Views.Master
{
    public partial class FrmCustomer : DevExpress.XtraEditors.XtraForm
    {
        private static FrmCustomer instance;

        public static FrmCustomer GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmCustomer();
            }
            return instance;
        }

        public void init()
        {
            gridControl1.DataSource = Controllers.CCustomer.get_data();
            cbo_cari.SelectedIndex = 0;
            txt_cari.EditValue = "";
        }

        public FrmCustomer()
        {
            InitializeComponent();
        }


        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void txt_cari_EditValueChanged(object sender, EventArgs e)
        {
             gridControl1.DataSource = Controllers.CCustomer.search(cbo_cari.EditValue.ToString(), txt_cari.EditValue.ToString());
        }

        private void btn_tambah_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmCustomerAdd()
            {
                Text = "Tambah Data Customer"
            };
            Helpers.Generic.ShowAdd(this, frm);
        }

        private void btn_perbaiki_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            var frm = new FrmCustomerAdd()
            {
                Text = "Perbaiki Data Customer",
                kd_customer = gridView1.GetRowCellValue(index[0], "kd_customer").ToString()
            };
            Helpers.Generic.ShowAdd(this, frm);
        }

        private void btn_hapus_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var index = gridView1.GetSelectedRows();
            if (index.Count() > 0)
            {
                if (Helpers.Generic.MsgQuestion("Hapus data yang dipilih?") == DialogResult.Yes)
                {
                    var data = new Models.customer()
                    {
                        kd_customer = gridView1.GetRowCellValue(index[0], "kd_customer").ToString()
                    };
                    Controllers.CCustomer.delete(data);
                }
            }
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}