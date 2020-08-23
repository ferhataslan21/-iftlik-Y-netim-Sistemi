namespace CYSLAU.Formlar.Hayvan
{
    partial class frmMuayeneListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuayeneListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.sAGLIKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colSIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN_KAYITNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVETERINER_SIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISLEM_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISLEM_ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTLAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAGLIK_ASI_TURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAGLIK_ILAC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVETERINER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAGLIKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sAGLIKBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(719, 492);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.AliceBlue;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSIRANO,
            this.colHAYVAN_KAYITNO,
            this.colVETERINER_SIRANO,
            this.colISLEM_TARIHI,
            this.colISLEM_ACIKLAMA,
            this.colNOTLAR,
            this.colHAYVAN,
            this.colSAGLIK_ASI_TURU,
            this.colSAGLIK_ILAC,
            this.colVETERINER});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 27;
            // 
            // sAGLIKBindingSource
            // 
            this.sAGLIKBindingSource.DataSource = typeof(CYSLAU.DB.SAGLIK);
            // 
            // colSIRANO
            // 
            this.colSIRANO.Caption = "Kayıt No";
            this.colSIRANO.FieldName = "SIRANO";
            this.colSIRANO.Name = "colSIRANO";
            this.colSIRANO.OptionsColumn.AllowEdit = false;
            this.colSIRANO.OptionsColumn.AllowFocus = false;
            this.colSIRANO.OptionsColumn.ReadOnly = true;
            this.colSIRANO.Visible = true;
            this.colSIRANO.VisibleIndex = 0;
            // 
            // colHAYVAN_KAYITNO
            // 
            this.colHAYVAN_KAYITNO.FieldName = "HAYVAN_KAYITNO";
            this.colHAYVAN_KAYITNO.Name = "colHAYVAN_KAYITNO";
            this.colHAYVAN_KAYITNO.OptionsColumn.AllowEdit = false;
            this.colHAYVAN_KAYITNO.OptionsColumn.AllowFocus = false;
            this.colHAYVAN_KAYITNO.OptionsColumn.ReadOnly = true;
            // 
            // colVETERINER_SIRANO
            // 
            this.colVETERINER_SIRANO.FieldName = "VETERINER_SIRANO";
            this.colVETERINER_SIRANO.Name = "colVETERINER_SIRANO";
            this.colVETERINER_SIRANO.OptionsColumn.AllowEdit = false;
            this.colVETERINER_SIRANO.OptionsColumn.AllowFocus = false;
            this.colVETERINER_SIRANO.OptionsColumn.ReadOnly = true;
            // 
            // colISLEM_TARIHI
            // 
            this.colISLEM_TARIHI.Caption = "Muayene Tarihi";
            this.colISLEM_TARIHI.FieldName = "ISLEM_TARIHI";
            this.colISLEM_TARIHI.Name = "colISLEM_TARIHI";
            this.colISLEM_TARIHI.OptionsColumn.AllowEdit = false;
            this.colISLEM_TARIHI.OptionsColumn.AllowFocus = false;
            this.colISLEM_TARIHI.OptionsColumn.ReadOnly = true;
            this.colISLEM_TARIHI.Visible = true;
            this.colISLEM_TARIHI.VisibleIndex = 1;
            // 
            // colISLEM_ACIKLAMA
            // 
            this.colISLEM_ACIKLAMA.Caption = "Açıklama";
            this.colISLEM_ACIKLAMA.FieldName = "ISLEM_ACIKLAMA";
            this.colISLEM_ACIKLAMA.Name = "colISLEM_ACIKLAMA";
            this.colISLEM_ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colISLEM_ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.colISLEM_ACIKLAMA.OptionsColumn.ReadOnly = true;
            this.colISLEM_ACIKLAMA.Visible = true;
            this.colISLEM_ACIKLAMA.VisibleIndex = 2;
            // 
            // colNOTLAR
            // 
            this.colNOTLAR.Caption = "Notlar";
            this.colNOTLAR.FieldName = "NOTLAR";
            this.colNOTLAR.Name = "colNOTLAR";
            this.colNOTLAR.OptionsColumn.AllowEdit = false;
            this.colNOTLAR.OptionsColumn.AllowFocus = false;
            this.colNOTLAR.OptionsColumn.ReadOnly = true;
            this.colNOTLAR.Visible = true;
            this.colNOTLAR.VisibleIndex = 3;
            // 
            // colHAYVAN
            // 
            this.colHAYVAN.Caption = "Hayvan";
            this.colHAYVAN.FieldName = "HAYVAN";
            this.colHAYVAN.Name = "colHAYVAN";
            this.colHAYVAN.OptionsColumn.AllowEdit = false;
            this.colHAYVAN.OptionsColumn.AllowFocus = false;
            this.colHAYVAN.OptionsColumn.ReadOnly = true;
            this.colHAYVAN.Visible = true;
            this.colHAYVAN.VisibleIndex = 4;
            // 
            // colSAGLIK_ASI_TURU
            // 
            this.colSAGLIK_ASI_TURU.FieldName = "SAGLIK_ASI_TURU";
            this.colSAGLIK_ASI_TURU.Name = "colSAGLIK_ASI_TURU";
            this.colSAGLIK_ASI_TURU.OptionsColumn.AllowEdit = false;
            this.colSAGLIK_ASI_TURU.OptionsColumn.AllowFocus = false;
            this.colSAGLIK_ASI_TURU.OptionsColumn.ReadOnly = true;
            // 
            // colSAGLIK_ILAC
            // 
            this.colSAGLIK_ILAC.FieldName = "SAGLIK_ILAC";
            this.colSAGLIK_ILAC.Name = "colSAGLIK_ILAC";
            this.colSAGLIK_ILAC.OptionsColumn.AllowEdit = false;
            this.colSAGLIK_ILAC.OptionsColumn.AllowFocus = false;
            this.colSAGLIK_ILAC.OptionsColumn.ReadOnly = true;
            // 
            // colVETERINER
            // 
            this.colVETERINER.Caption = "Veteriner";
            this.colVETERINER.FieldName = "VETERINER.VETERINER_ADI";
            this.colVETERINER.Name = "colVETERINER";
            this.colVETERINER.OptionsColumn.AllowEdit = false;
            this.colVETERINER.OptionsColumn.AllowFocus = false;
            this.colVETERINER.OptionsColumn.ReadOnly = true;
            this.colVETERINER.Visible = true;
            this.colVETERINER.VisibleIndex = 5;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection2;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6});
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(719, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 492);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(719, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 492);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(719, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 492);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni Muayene";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageIndex = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Muayene Kartını Aç";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "İlaç İşlemleri";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Aşı İşlemleri";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Muayene Kaydını Sil";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.ImageIndex = 13;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Kapat";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.ImageIndex = 22;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // frmMuayeneListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 518);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMuayeneListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muayene Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAGLIKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource sAGLIKBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN_KAYITNO;
        private DevExpress.XtraGrid.Columns.GridColumn colVETERINER_SIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colISLEM_TARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colISLEM_ACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTLAR;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSAGLIK_ASI_TURU;
        private DevExpress.XtraGrid.Columns.GridColumn colSAGLIK_ILAC;
        private DevExpress.XtraGrid.Columns.GridColumn colVETERINER;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection2;
    }
}