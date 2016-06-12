﻿namespace Jotun.Views.Master
{
    partial class FrmCustomerAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerAdd));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_simpan = new DevExpress.XtraBars.BarButtonItem();
            this.btn_batal = new DevExpress.XtraBars.BarButtonItem();
            this.btn_tutup = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txt_no_telepon = new DevExpress.XtraEditors.TextEdit();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.txt_alamat = new DevExpress.XtraEditors.MemoEdit();
            this.txt_nama = new DevExpress.XtraEditors.TextEdit();
            this.txt_kd_customer = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cbo_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spin_diskon = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_no_telepon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alamat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kd_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_diskon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_simpan,
            this.btn_batal,
            this.btn_tutup});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_simpan, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_batal, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_tutup, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_simpan
            // 
            this.btn_simpan.Caption = "Simpan";
            this.btn_simpan.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_simpan.Glyph")));
            this.btn_simpan.Id = 0;
            this.btn_simpan.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_simpan.LargeGlyph")));
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_simpan_ItemClick);
            // 
            // btn_batal
            // 
            this.btn_batal.Caption = "Batal";
            this.btn_batal.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_batal.Glyph")));
            this.btn_batal.Id = 1;
            this.btn_batal.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_batal.LargeGlyph")));
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_batal_ItemClick);
            // 
            // btn_tutup
            // 
            this.btn_tutup.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btn_tutup.Caption = "Tutup";
            this.btn_tutup.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_tutup.Glyph")));
            this.btn_tutup.Id = 2;
            this.btn_tutup.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_tutup.LargeGlyph")));
            this.btn_tutup.Name = "btn_tutup";
            this.btn_tutup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_tutup_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(730, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 231);
            this.barDockControlBottom.Size = new System.Drawing.Size(730, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 205);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(730, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 205);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(730, 205);
            this.panelControl1.TabIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spin_diskon);
            this.layoutControl1.Controls.Add(this.cbo_status);
            this.layoutControl1.Controls.Add(this.txt_no_telepon);
            this.layoutControl1.Controls.Add(this.txt_email);
            this.layoutControl1.Controls.Add(this.txt_alamat);
            this.layoutControl1.Controls.Add(this.txt_nama);
            this.layoutControl1.Controls.Add(this.txt_kd_customer);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(726, 201);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_no_telepon
            // 
            this.txt_no_telepon.Location = new System.Drawing.Point(467, 90);
            this.txt_no_telepon.MenuManager = this.barManager1;
            this.txt_no_telepon.Name = "txt_no_telepon";
            this.txt_no_telepon.Size = new System.Drawing.Size(241, 20);
            this.txt_no_telepon.StyleController = this.layoutControl1;
            this.txt_no_telepon.TabIndex = 11;
            this.txt_no_telepon.Tag = "No. Telepon";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(123, 90);
            this.txt_email.MenuManager = this.barManager1;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(223, 20);
            this.txt_email.StyleController = this.layoutControl1;
            this.txt_email.TabIndex = 7;
            this.txt_email.Tag = "Email";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(123, 126);
            this.txt_alamat.MenuManager = this.barManager1;
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(585, 57);
            this.txt_alamat.StyleController = this.layoutControl1;
            this.txt_alamat.TabIndex = 6;
            this.txt_alamat.Tag = "Alamat";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(123, 54);
            this.txt_nama.MenuManager = this.barManager1;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(223, 20);
            this.txt_nama.StyleController = this.layoutControl1;
            this.txt_nama.TabIndex = 5;
            this.txt_nama.Tag = "Nama";
            // 
            // txt_kd_customer
            // 
            this.txt_kd_customer.Enabled = false;
            this.txt_kd_customer.Location = new System.Drawing.Point(123, 18);
            this.txt_kd_customer.MenuManager = this.barManager1;
            this.txt_kd_customer.Name = "txt_kd_customer";
            this.txt_kd_customer.Size = new System.Drawing.Size(585, 20);
            this.txt_kd_customer.StyleController = this.layoutControl1;
            this.txt_kd_customer.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 30;
            this.layoutControlGroup1.Size = new System.Drawing.Size(726, 201);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_kd_customer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem1.Size = new System.Drawing.Size(706, 36);
            this.layoutControlItem1.Text = "Kode Karyawan";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_nama;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem2.Size = new System.Drawing.Size(344, 36);
            this.layoutControlItem2.Text = "Nama";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_email;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem4.Size = new System.Drawing.Size(344, 36);
            this.layoutControlItem4.Text = "Email";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txt_no_telepon;
            this.layoutControlItem8.Location = new System.Drawing.Point(344, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem8.Size = new System.Drawing.Size(362, 36);
            this.layoutControlItem8.Text = "No. Telepon";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(75, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_alamat;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(706, 73);
            this.layoutControlItem3.Text = "Alamat";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(75, 13);
            // 
            // cbo_status
            // 
            this.cbo_status.Location = new System.Drawing.Point(467, 54);
            this.cbo_status.MenuManager = this.barManager1;
            this.cbo_status.Name = "cbo_status";
            this.cbo_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_status.Properties.Items.AddRange(new object[] {
            "Langgaan",
            "Bukan Langganan"});
            this.cbo_status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbo_status.Size = new System.Drawing.Size(113, 20);
            this.cbo_status.StyleController = this.layoutControl1;
            this.cbo_status.TabIndex = 12;
            this.cbo_status.SelectedIndexChanged += new System.EventHandler(this.cbo_status_SelectedIndexChanged);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbo_status;
            this.layoutControlItem5.Location = new System.Drawing.Point(344, 36);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem5.Size = new System.Drawing.Size(234, 36);
            this.layoutControlItem5.Text = "Status";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(75, 13);
            // 
            // spin_diskon
            // 
            this.spin_diskon.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_diskon.Location = new System.Drawing.Point(651, 54);
            this.spin_diskon.MenuManager = this.barManager1;
            this.spin_diskon.Name = "spin_diskon";
            this.spin_diskon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_diskon.Size = new System.Drawing.Size(57, 20);
            this.spin_diskon.StyleController = this.layoutControl1;
            this.spin_diskon.TabIndex = 13;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.spin_diskon;
            this.layoutControlItem6.Location = new System.Drawing.Point(578, 36);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem6.Size = new System.Drawing.Size(128, 36);
            this.layoutControlItem6.Text = "Diskon";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(50, 20);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // FrmCustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 253);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmCustomerAdd";
            this.Text = "Tambah Data Customer";
            this.Load += new System.EventHandler(this.FrmCustomerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_no_telepon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alamat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kd_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_diskon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarButtonItem btn_simpan;
        private DevExpress.XtraBars.BarButtonItem btn_batal;
        private DevExpress.XtraBars.BarButtonItem btn_tutup;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.MemoEdit txt_alamat;
        private DevExpress.XtraEditors.TextEdit txt_nama;
        private DevExpress.XtraEditors.TextEdit txt_kd_customer;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txt_no_telepon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_status;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SpinEdit spin_diskon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}