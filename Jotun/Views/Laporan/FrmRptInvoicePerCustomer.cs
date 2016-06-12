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
using DevExpress.XtraReports.UI;
namespace Jotun.Views.Laporan
{
    public partial class FrmRptInvoicePerCustomer : DevExpress.XtraEditors.XtraForm
    {
        private static FrmRptInvoicePerCustomer Instance;

        public static FrmRptInvoicePerCustomer GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FrmRptInvoicePerCustomer();
            }
            return Instance;
        }

        public FrmRptInvoicePerCustomer()
        {
            InitializeComponent();
        }

        private void FrmRptInvoicePerCustomer_Load(object sender, EventArgs e)
        {
            dtp_tgl1.EditValue = DateTime.Now;
            dtp_tgl2.EditValue = DateTime.Now;

            repositoryItemCheckedComboBoxEdit1.DataSource = Controllers.CCustomer.get_data();
            repositoryItemCheckedComboBoxEdit1.DisplayMember = "nama";
            repositoryItemCheckedComboBoxEdit1.ValueMember = "kd_customer";

        }

        private void btn_tampil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (repositoryItemCheckedComboBoxEdit1.GetCheckedItems().ToString() == "")
            {
                Helpers.Generic.MsgError("Tidak ada data customer yang dipilih");
                return;
            }
            DataSet1 ds = Controllers.Penjualan.CInvoice.get_repot_penjualan_per_customer(repositoryItemCheckedComboBoxEdit1.GetCheckedItems().ToString(), Convert.ToDateTime(dtp_tgl1.EditValue), Convert.ToDateTime(dtp_tgl2.EditValue));
            var rpt = new XtraReport();
            rpt = XtraReport.FromFile(Application.StartupPath + "/Laporan/RptPenjualan.repx", true);
            rpt.DataSource = ds;
            rpt.DataMember = rpt.DataMember;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}