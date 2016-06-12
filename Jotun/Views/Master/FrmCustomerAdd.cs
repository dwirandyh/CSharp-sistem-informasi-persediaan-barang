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
    public partial class FrmCustomerAdd : DevExpress.XtraEditors.XtraForm
    {
        public string kd_customer { get; set; }

        public void init()
        {
            if (this.Text.ToLower().Contains("tambah"))
            {
                var txt = new TextEdit[] { txt_nama, txt_alamat, txt_email, txt_no_telepon };
                foreach (TextEdit t in txt)
                {
                    t.EditValue = "";
                }

                txt_kd_customer.EditValue = Controllers.CCustomer.get_kode();
                cbo_status.SelectedIndex = 0;
                spin_diskon.EditValue = 0;
            }
            else
            {
                var data = Controllers.CCustomer.get_detail(this.kd_customer);
                txt_kd_customer.EditValue = kd_customer;
                txt_nama.EditValue = data.nama;
                txt_alamat.EditValue = data.alamat;
                txt_email.EditValue = data.email;
                txt_no_telepon.EditValue = data.no_telepon;
                cbo_status.SelectedItem = data.status;
                spin_diskon.EditValue = data.diskon;
            }
        }

        public FrmCustomerAdd()
        {
            InitializeComponent();
        }

        private void FrmCustomerAdd_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void btn_simpan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var txt = new TextEdit[] { txt_nama, txt_alamat, txt_email, txt_no_telepon };
            foreach (var t in txt)
            {
                if (t.EditValue.ToString() == "")
                {
                    Helpers.Generic.MsgError(t.Tag.ToString() + " tidak boleh kosong");
                    t.Focus();
                    return;
                }
            }
            var data = new Models.customer()
            {
                kd_customer = txt_kd_customer.EditValue.ToString(),
                nama = txt_nama.EditValue.ToString(),
                alamat = txt_alamat.EditValue.ToString(),
                email = txt_email.EditValue.ToString(),
                no_telepon = txt_no_telepon.EditValue.ToString(),
                diskon = Convert.ToDouble(spin_diskon.EditValue),
                status = cbo_status.SelectedItem.ToString()
            };

            if (this.Text.ToLower().Contains("tambah"))
            {
                Controllers.CCustomer.insert(data);
            }
            else
            {
                Controllers.CCustomer.update(data);
            }

            var frm = (FrmCustomer)this.Owner;
            frm.init();
            this.Close();
        }

        private void btn_batal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cbo_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_status.SelectedIndex == 0)
            {
                spin_diskon.Enabled = true;
            }
            else
            {
                spin_diskon.Enabled = false;
                spin_diskon.EditValue = 0;
            }
        }
    }
}