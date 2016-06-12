using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Jotun.Views
{
    public partial class MainMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Models.karyawan karyawan { get; set; }

        private void ShowChild(DevExpress.XtraEditors.XtraForm frm)
        {
            var doc = documentManager1.GetDocument(frm);
            if (doc == null)
            {
                Helpers.Generic.ShowChild(this, frm);
            }
            else
            {
                tabbedView1.Controller.Activate(doc);
            }
        }

        private void init()
        {
            btn_login.Enabled = true;
            btn_logout.Enabled = false;

            pagegroup_barang.Visible = false;
            pagegroup_karyawan.Visible = false;

            page_po.Visible = false;
            page_penjualan.Visible = false;
            page_laporan.Visible = false;
            ribbon.SelectedPage = page_master;

            lbl_hak_akses.Caption = "-";
            lbl_kd_karyawan.Caption = "-";
            lbl_nama_karyawan.Caption = "-";
        }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_karyawan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Master.FrmKaryawan.GetInstance();
            this.ShowChild(frm);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.init();
        }

        public void SetRule()
        {
            lbl_kd_karyawan.Caption = this.karyawan.kd_karyawan;
            lbl_nama_karyawan.Caption = this.karyawan.nama;
            lbl_hak_akses.Caption = this.karyawan.hak_akses;

            if (this.karyawan.hak_akses == "Gudang")
            {
                page_po.Visible = true;
                page_penjualan.Visible = true;
                pagegroup_barang.Visible = true;
                pagegroup_karyawan.Visible = true;

                page_laporan.Visible = false;
            }
            else
            {
                page_po.Visible = false;
                page_penjualan.Visible = false;
                pagegroup_barang.Visible = false;
                pagegroup_karyawan.Visible = false;

                page_laporan.Visible = true;
            }

            btn_login.Enabled = false;
            btn_logout.Enabled = true;
        }

        private void btn_barang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Master.FrmBarang.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_konsumen_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Master.FrmCustomer.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_po_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = PO.FrmPO.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_surat_jalan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Penjualan.FrmSuratJalan.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_invoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Penjualan.FrmInvoice.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_penerimaan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = PO.FrmPenerimaan.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_login_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var frm = FrmLogin.GetInstance();
            Helpers.Generic.ShowAdd(this, frm);
        }

        private void btn_logout_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.init();
        }

        private void btn_rpt_barang_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Laporan.FrmRptBarang.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_rpt_po_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Laporan.FrmRptPO.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_rpt_penerimaan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Laporan.FrmRptPenerimaan.GetInstance();
            this.ShowChild(frm);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = Laporan.FrmRptInvoicePerCustomer.GetInstance();
            this.ShowChild(frm);
        }

        private void btn_po_pusat_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = PO.FrmPOPusat.GetInstance();
            this.ShowChild(frm);
        }
    }
}