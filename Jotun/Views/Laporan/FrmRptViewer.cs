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
    public partial class FrmRptViewer : DevExpress.XtraEditors.XtraForm
    {
        public string rptname;
        public DataSet1 ds;

        public FrmRptViewer()
        {
            InitializeComponent();
        }

        private void FrmRptViewer_Load(object sender, EventArgs e)
        {
            var rpt = new XtraReport();
            rpt = XtraReport.FromFile(Application.StartupPath + "/Laporan/" + rptname, true);
            rpt.DataSource = ds;
            rpt.DataMember = rpt.DataMember;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}