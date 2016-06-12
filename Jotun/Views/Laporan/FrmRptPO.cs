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
    public partial class FrmRptPO : DevExpress.XtraEditors.XtraForm
    {
        private static FrmRptPO Instance;

        public static FrmRptPO GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FrmRptPO();
            }
            return Instance;
        }

        public FrmRptPO()
        {
            InitializeComponent();
        }

        private void FrmRptPO_Load(object sender, EventArgs e)
        {
            dtp_tgl1.EditValue = DateTime.Now;
            dtp_tgl2.EditValue = DateTime.Now;
        }

        private void btn_tampilkan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataSet1 ds = Controllers.PO.CPO.get_report(Convert.ToDateTime(dtp_tgl1.EditValue), Convert.ToDateTime(dtp_tgl2.EditValue));
            var rpt = new XtraReport();
            rpt = XtraReport.FromFile(Application.StartupPath + "/Laporan/RptPO.repx", true);
            rpt.DataSource = ds;
            rpt.DataMember = rpt.DataMember;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}