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
    public partial class FrmRptBarang : DevExpress.XtraEditors.XtraForm
    {
        private static FrmRptBarang Instance;

        public static FrmRptBarang GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FrmRptBarang();
            }
            return Instance;
        }

        public FrmRptBarang()
        {
            InitializeComponent();
        }

        private void FrmRptBarang_Load(object sender, EventArgs e)
        {
            DataSet1 ds = Controllers.CBarang.get_report();
            var rpt = new XtraReport();
            rpt = XtraReport.FromFile(Application.StartupPath + "/Laporan/RptBarang.repx", true);
            rpt.DataSource = ds;
            rpt.DataMember = rpt.DataMember;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}