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

namespace Jotun.Views
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private static FrmLogin Instance;

        public static FrmLogin GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FrmLogin();
            }
            return Instance;
        }

        private void init()
        {
            txt_username.EditValue = "";
            txt_password.EditValue = "";
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.init();
        }

        private void btn_login_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txt_username.EditValue.ToString() == "")
            {
                Helpers.Generic.MsgEx("Username tidak boleh kosong");
            }
            else if (txt_password.EditValue.ToString() == "")
            {
                Helpers.Generic.MsgEx("Password tidak boleh kosong");
            }
            else
            {
                var data = Controllers.CKaryawan.check_login(txt_username.EditValue.ToString(), txt_password.EditValue.ToString());
                if (data == null)
                {
                    Helpers.Generic.MsgEx("Username/password anda salah");
                }
                else
                {
                    var frm = (MainMenu)this.Owner;
                    frm.karyawan = data;
                    frm.SetRule();
                    this.Close();
                }
            }
        }

        private void btn_batal2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_tutup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}