namespace Jotun.Views
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_karyawan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_barang = new DevExpress.XtraBars.BarButtonItem();
            this.btn_customer = new DevExpress.XtraBars.BarButtonItem();
            this.btn_po = new DevExpress.XtraBars.BarButtonItem();
            this.btn_surat_jalan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_invoice = new DevExpress.XtraBars.BarButtonItem();
            this.btn_penerimaan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_login = new DevExpress.XtraBars.BarButtonItem();
            this.btn_logout = new DevExpress.XtraBars.BarButtonItem();
            this.lbl_hak_akses = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.lbl_kd_karyawan = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.lbl_nama_karyawan = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem6 = new DevExpress.XtraBars.BarStaticItem();
            this.btn_rpt_penerimaan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_po = new DevExpress.XtraBars.BarButtonItem();
            this.btn_rpt_barang = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_po_pusat = new DevExpress.XtraBars.BarButtonItem();
            this.page_master = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pagegroup_karyawan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pagegroup_barang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_autentifikasi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_po = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_penjualan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.page_laporan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_karyawan,
            this.btn_barang,
            this.btn_customer,
            this.btn_po,
            this.btn_surat_jalan,
            this.btn_invoice,
            this.btn_penerimaan,
            this.btn_login,
            this.btn_logout,
            this.lbl_hak_akses,
            this.barStaticItem2,
            this.lbl_kd_karyawan,
            this.barStaticItem4,
            this.lbl_nama_karyawan,
            this.barStaticItem6,
            this.btn_rpt_penerimaan,
            this.btn_rpt_po,
            this.btn_rpt_barang,
            this.barButtonItem1,
            this.btn_po_pusat});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.page_master,
            this.page_po,
            this.page_penjualan,
            this.page_laporan});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.Size = new System.Drawing.Size(991, 134);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_karyawan
            // 
            this.btn_karyawan.Caption = "Karyawan";
            this.btn_karyawan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_karyawan.Glyph")));
            this.btn_karyawan.Id = 1;
            this.btn_karyawan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_karyawan.LargeGlyph")));
            this.btn_karyawan.Name = "btn_karyawan";
            this.btn_karyawan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_karyawan_ItemClick);
            // 
            // btn_barang
            // 
            this.btn_barang.Caption = "Data Barang";
            this.btn_barang.Glyph = global::Jotun.Properties.Resources.barang_copy;
            this.btn_barang.Id = 2;
            this.btn_barang.LargeGlyph = global::Jotun.Properties.Resources.barang_copy;
            this.btn_barang.Name = "btn_barang";
            this.btn_barang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_barang_ItemClick);
            // 
            // btn_customer
            // 
            this.btn_customer.Caption = "Customer";
            this.btn_customer.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_customer.Glyph")));
            this.btn_customer.Id = 3;
            this.btn_customer.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_customer.LargeGlyph")));
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_konsumen_ItemClick);
            // 
            // btn_po
            // 
            this.btn_po.Caption = "Purchase Order";
            this.btn_po.Glyph = global::Jotun.Properties.Resources.po;
            this.btn_po.Id = 4;
            this.btn_po.LargeGlyph = global::Jotun.Properties.Resources.po;
            this.btn_po.Name = "btn_po";
            this.btn_po.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_po_ItemClick);
            // 
            // btn_surat_jalan
            // 
            this.btn_surat_jalan.Caption = "Surat Jalan";
            this.btn_surat_jalan.Id = 5;
            this.btn_surat_jalan.LargeGlyph = global::Jotun.Properties.Resources.surat_jalan;
            this.btn_surat_jalan.Name = "btn_surat_jalan";
            this.btn_surat_jalan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_surat_jalan_ItemClick);
            // 
            // btn_invoice
            // 
            this.btn_invoice.Caption = "Invoice";
            this.btn_invoice.Id = 6;
            this.btn_invoice.LargeGlyph = global::Jotun.Properties.Resources.invoice;
            this.btn_invoice.Name = "btn_invoice";
            this.btn_invoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_invoice_ItemClick);
            // 
            // btn_penerimaan
            // 
            this.btn_penerimaan.Caption = "Penerimaan Barang";
            this.btn_penerimaan.Id = 7;
            this.btn_penerimaan.LargeGlyph = global::Jotun.Properties.Resources.penerimaan;
            this.btn_penerimaan.Name = "btn_penerimaan";
            this.btn_penerimaan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_penerimaan_ItemClick);
            // 
            // btn_login
            // 
            this.btn_login.Caption = "Login";
            this.btn_login.Id = 8;
            this.btn_login.LargeGlyph = global::Jotun.Properties.Resources.login1;
            this.btn_login.Name = "btn_login";
            this.btn_login.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_login_ItemClick_1);
            // 
            // btn_logout
            // 
            this.btn_logout.Caption = "Logout";
            this.btn_logout.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_logout.Glyph")));
            this.btn_logout.Id = 9;
            this.btn_logout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_logout.LargeGlyph")));
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_logout_ItemClick_1);
            // 
            // lbl_hak_akses
            // 
            this.lbl_hak_akses.Caption = "barStaticItem1";
            this.lbl_hak_akses.Id = 10;
            this.lbl_hak_akses.Name = "lbl_hak_akses";
            this.lbl_hak_akses.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Kode Karyawan : ";
            this.barStaticItem2.Id = 11;
            this.barStaticItem2.Name = "barStaticItem2";
            this.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbl_kd_karyawan
            // 
            this.lbl_kd_karyawan.Caption = "barStaticItem3";
            this.lbl_kd_karyawan.Id = 12;
            this.lbl_kd_karyawan.Name = "lbl_kd_karyawan";
            this.lbl_kd_karyawan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Nama : ";
            this.barStaticItem4.Id = 13;
            this.barStaticItem4.Name = "barStaticItem4";
            this.barStaticItem4.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // lbl_nama_karyawan
            // 
            this.lbl_nama_karyawan.Caption = "barStaticItem5";
            this.lbl_nama_karyawan.Id = 14;
            this.lbl_nama_karyawan.Name = "lbl_nama_karyawan";
            this.lbl_nama_karyawan.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem6
            // 
            this.barStaticItem6.Caption = "Hak Akses : ";
            this.barStaticItem6.Id = 15;
            this.barStaticItem6.Name = "barStaticItem6";
            this.barStaticItem6.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btn_rpt_penerimaan
            // 
            this.btn_rpt_penerimaan.Caption = "Penerimaan Barang";
            this.btn_rpt_penerimaan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_penerimaan.Glyph")));
            this.btn_rpt_penerimaan.Id = 16;
            this.btn_rpt_penerimaan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_penerimaan.LargeGlyph")));
            this.btn_rpt_penerimaan.Name = "btn_rpt_penerimaan";
            this.btn_rpt_penerimaan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_penerimaan_ItemClick);
            // 
            // btn_rpt_po
            // 
            this.btn_rpt_po.Caption = "Purchase Order Customer";
            this.btn_rpt_po.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_po.Glyph")));
            this.btn_rpt_po.Id = 17;
            this.btn_rpt_po.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_po.LargeGlyph")));
            this.btn_rpt_po.Name = "btn_rpt_po";
            this.btn_rpt_po.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_po_ItemClick);
            // 
            // btn_rpt_barang
            // 
            this.btn_rpt_barang.Caption = "Barang";
            this.btn_rpt_barang.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_barang.Glyph")));
            this.btn_rpt_barang.Id = 18;
            this.btn_rpt_barang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_rpt_barang.LargeGlyph")));
            this.btn_rpt_barang.Name = "btn_rpt_barang";
            this.btn_rpt_barang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_rpt_barang_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Penjualan Per Customer";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_po_pusat
            // 
            this.btn_po_pusat.Caption = "Purchase Order";
            this.btn_po_pusat.Id = 21;
            this.btn_po_pusat.LargeGlyph = global::Jotun.Properties.Resources.po;
            this.btn_po_pusat.Name = "btn_po_pusat";
            this.btn_po_pusat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_po_pusat_ItemClick);
            // 
            // page_master
            // 
            this.page_master.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pagegroup_karyawan,
            this.pagegroup_barang,
            this.page_autentifikasi});
            this.page_master.Name = "page_master";
            this.page_master.Text = "Master";
            // 
            // pagegroup_karyawan
            // 
            this.pagegroup_karyawan.ItemLinks.Add(this.btn_karyawan);
            this.pagegroup_karyawan.ItemLinks.Add(this.btn_customer);
            this.pagegroup_karyawan.Name = "pagegroup_karyawan";
            // 
            // pagegroup_barang
            // 
            this.pagegroup_barang.ItemLinks.Add(this.btn_barang);
            this.pagegroup_barang.Name = "pagegroup_barang";
            // 
            // page_autentifikasi
            // 
            this.page_autentifikasi.ItemLinks.Add(this.btn_login);
            this.page_autentifikasi.ItemLinks.Add(this.btn_logout);
            this.page_autentifikasi.Name = "page_autentifikasi";
            // 
            // page_po
            // 
            this.page_po.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5});
            this.page_po.Name = "page_po";
            this.page_po.Text = "Purchase Order";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btn_po);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Customer";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_po_pusat);
            this.ribbonPageGroup5.ItemLinks.Add(this.btn_penerimaan, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Pusat";
            // 
            // page_penjualan
            // 
            this.page_penjualan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.page_penjualan.Name = "page_penjualan";
            this.page_penjualan.Text = "Penjualan";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_surat_jalan);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_invoice);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // page_laporan
            // 
            this.page_laporan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup6,
            this.ribbonPageGroup8});
            this.page_laporan.Name = "page_laporan";
            this.page_laporan.Text = "Laporan";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btn_rpt_barang);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Barang";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_rpt_po);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "PO Customer";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btn_rpt_penerimaan);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Penerimaan Barang";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_kd_karyawan);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem4);
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_nama_karyawan);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem6);
            this.ribbonStatusBar.ItemLinks.Add(this.lbl_hak_akses);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 499);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(991, 23);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 522);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_master;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagegroup_karyawan;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem btn_karyawan;
        private DevExpress.XtraBars.BarButtonItem btn_barang;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_po;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_penjualan;
        private DevExpress.XtraBars.BarButtonItem btn_customer;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pagegroup_barang;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btn_po;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btn_surat_jalan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_invoice;
        private DevExpress.XtraBars.BarButtonItem btn_penerimaan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_login;
        private DevExpress.XtraBars.BarButtonItem btn_logout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup page_autentifikasi;
        private DevExpress.XtraBars.BarStaticItem lbl_hak_akses;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.BarStaticItem lbl_kd_karyawan;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraBars.BarStaticItem lbl_nama_karyawan;
        private DevExpress.XtraBars.BarStaticItem barStaticItem6;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_penerimaan;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_po;
        private DevExpress.XtraBars.BarButtonItem btn_rpt_barang;
        private DevExpress.XtraBars.Ribbon.RibbonPage page_laporan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_po_pusat;
    }
}