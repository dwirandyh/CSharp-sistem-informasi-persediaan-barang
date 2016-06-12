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
    public partial class FrmRptPenerimaan : DevExpress.XtraEditors.XtraForm
    {
        private static FrmRptPenerimaan Instance;
        public static FrmRptPenerimaan GetInstance()
        {
            if (Instance == null || Instance.IsDisposed)
            {
                Instance = new FrmRptPenerimaan();
            }
            return Instance;
        }

        public FrmRptPenerimaan()
        {
            InitializeComponent();
        }

        private void FrmRptPenerimaan_Load(object sender, EventArgs e)
        {

        }

        private void btn_cetak_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataSet1 ds = Controllers.PO.CPenerimaan.get_report(Convert.ToDateTime(dtp_tgl1.EditValue), Convert.ToDateTime(dtp_tgl2.EditValue));
            var rpt = new XtraReport();
            rpt = XtraReport.FromFile(Application.StartupPath + "/Laporan/RptPenerimaan.repx", true);
            rpt.DataSource = ds;
            rpt.DataMember = rpt.DataMember;
            rpt.CreateDocument();
            documentViewer1.DocumentSource = rpt;
        }
    }
}