﻿namespace Jotun.Views.Master
{
    partial class FrmBarangAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBarangAdd));
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
            this.txt_harga = new DevExpress.XtraEditors.TextEdit();
            this.txt_tipe = new DevExpress.XtraEditors.TextEdit();
            this.txt_no_batch = new DevExpress.XtraEditors.TextEdit();
            this.txt_nama = new DevExpress.XtraEditors.TextEdit();
            this.txt_kd_barang = new DevExpress.XtraEditors.TextEdit();
            this.txt_ukuran = new DevExpress.XtraEditors.SpinEdit();
            this.txt_stok = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_harga.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tipe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_no_batch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kd_barang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ukuran.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(641, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 235);
            this.barDockControlBottom.Size = new System.Drawing.Size(641, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 209);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(641, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 209);
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 26);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(641, 209);
            this.panelControl1.TabIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txt_harga);
            this.layoutControl1.Controls.Add(this.txt_tipe);
            this.layoutControl1.Controls.Add(this.txt_no_batch);
            this.layoutControl1.Controls.Add(this.txt_nama);
            this.layoutControl1.Controls.Add(this.txt_kd_barang);
            this.layoutControl1.Controls.Add(this.txt_ukuran);
            this.layoutControl1.Controls.Add(this.txt_stok);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(637, 205);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txt_harga
            // 
            this.txt_harga.EditValue = "";
            this.txt_harga.Location = new System.Drawing.Point(109, 162);
            this.txt_harga.MenuManager = this.barManager1;
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_harga.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_harga.Properties.Mask.EditMask = "N0";
            this.txt_harga.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_harga.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_harga.Size = new System.Drawing.Size(201, 20);
            this.txt_harga.StyleController = this.layoutControl1;
            this.txt_harga.TabIndex = 13;
            // 
            // txt_tipe
            // 
            this.txt_tipe.Location = new System.Drawing.Point(109, 126);
            this.txt_tipe.MenuManager = this.barManager1;
            this.txt_tipe.Name = "txt_tipe";
            this.txt_tipe.Size = new System.Drawing.Size(510, 20);
            this.txt_tipe.StyleController = this.layoutControl1;
            this.txt_tipe.TabIndex = 8;
            this.txt_tipe.Tag = "Username";
            // 
            // txt_no_batch
            // 
            this.txt_no_batch.Location = new System.Drawing.Point(109, 90);
            this.txt_no_batch.MenuManager = this.barManager1;
            this.txt_no_batch.Name = "txt_no_batch";
            this.txt_no_batch.Size = new System.Drawing.Size(201, 20);
            this.txt_no_batch.StyleController = this.layoutControl1;
            this.txt_no_batch.TabIndex = 7;
            this.txt_no_batch.Tag = "Email";
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(109, 54);
            this.txt_nama.MenuManager = this.barManager1;
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(510, 20);
            this.txt_nama.StyleController = this.layoutControl1;
            this.txt_nama.TabIndex = 5;
            this.txt_nama.Tag = "Nama";
            // 
            // txt_kd_barang
            // 
            this.txt_kd_barang.Enabled = false;
            this.txt_kd_barang.Location = new System.Drawing.Point(109, 18);
            this.txt_kd_barang.MenuManager = this.barManager1;
            this.txt_kd_barang.Name = "txt_kd_barang";
            this.txt_kd_barang.Size = new System.Drawing.Size(510, 20);
            this.txt_kd_barang.StyleController = this.layoutControl1;
            this.txt_kd_barang.TabIndex = 4;
            // 
            // txt_ukuran
            // 
            this.txt_ukuran.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_ukuran.Location = new System.Drawing.Point(417, 90);
            this.txt_ukuran.MenuManager = this.barManager1;
            this.txt_ukuran.Name = "txt_ukuran";
            this.txt_ukuran.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_ukuran.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_ukuran.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txt_ukuran.Size = new System.Drawing.Size(202, 20);
            this.txt_ukuran.StyleController = this.layoutControl1;
            this.txt_ukuran.TabIndex = 9;
            this.txt_ukuran.Tag = "Password";
            // 
            // txt_stok
            // 
            this.txt_stok.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txt_stok.Location = new System.Drawing.Point(417, 162);
            this.txt_stok.MenuManager = this.barManager1;
            this.txt_stok.Name = "txt_stok";
            this.txt_stok.Properties.Appearance.Options.UseTextOptions = true;
            this.txt_stok.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_stok.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_stok.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txt_stok.Properties.Mask.EditMask = "N0";
            this.txt_stok.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_stok.Size = new System.Drawing.Size(202, 20);
            this.txt_stok.StyleController = this.layoutControl1;
            this.txt_stok.TabIndex = 12;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem7,
            this.layoutControlItem5,
            this.layoutControlItem4,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 30;
            this.layoutControlGroup1.Size = new System.Drawing.Size(637, 205);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_kd_barang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem1.Size = new System.Drawing.Size(617, 36);
            this.layoutControlItem1.Text = "Kode Barang";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_nama;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 36);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem2.Size = new System.Drawing.Size(617, 36);
            this.layoutControlItem2.Text = "Nama";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_stok;
            this.layoutControlItem3.Location = new System.Drawing.Point(308, 144);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem3.Size = new System.Drawing.Size(309, 41);
            this.layoutControlItem3.Text = "Stok";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txt_harga;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem7.Size = new System.Drawing.Size(308, 41);
            this.layoutControlItem7.Text = "Harga";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_tipe;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 108);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem5.Size = new System.Drawing.Size(617, 36);
            this.layoutControlItem5.Text = "Tipe";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txt_ukuran;
            this.layoutControlItem6.Location = new System.Drawing.Point(308, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem6.Size = new System.Drawing.Size(309, 36);
            this.layoutControlItem6.Text = "Ukuran";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txt_no_batch;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.layoutControlItem4.Size = new System.Drawing.Size(308, 36);
            this.layoutControlItem4.Text = "No. Batch";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(61, 13);
            // 
            // FrmBarangAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 257);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmBarangAdd";
            this.Text = "Tambah Data Barang";
            this.Load += new System.EventHandler(this.FrmBarangAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_harga.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tipe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_no_batch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_nama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kd_barang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ukuran.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_stok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txt_nama;
        private DevExpress.XtraEditors.TextEdit txt_kd_barang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txt_no_batch;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit txt_tipe;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txt_harga;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SpinEdit txt_ukuran;
        private DevExpress.XtraEditors.SpinEdit txt_stok;
    }
}