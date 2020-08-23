namespace CYSLAU.Formlar.Hayvan
{
    partial class frmHayvanListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHayvanListesi));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.hAYVANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKAYITNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKAYIT_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEVLET_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBOYUN_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKULAK_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCINSIYETI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colANNE_KAYITNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBABA_KAYITNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVANCINSI_SIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVANKAYITTURU_SIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOGUM_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN_CINSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN_DOGUM_TURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN_YEM_KARISIM_YEM_TURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN_KAYIT_TURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAGLIKs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSUTs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hAYVANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.hAYVANBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(928, 503);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // hAYVANBindingSource
            // 
            this.hAYVANBindingSource.DataSource = typeof(CYSLAU.DB.HAYVAN);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.AliceBlue;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKAYITNO,
            this.colKAYIT_TARIHI,
            this.colDEVLET_NO,
            this.colBOYUN_NO,
            this.colKULAK_NO,
            this.colCINSIYETI,
            this.colANNE_KAYITNO,
            this.colBABA_KAYITNO,
            this.colHAYVANCINSI_SIRANO,
            this.colHAYVANKAYITTURU_SIRANO,
            this.colDOGUM_TARIHI,
            this.colHAYVAN_CINSI,
            this.colHAYVAN_DOGUM_TURU,
            this.colHAYVAN_YEM_KARISIM_YEM_TURU,
            this.colHAYVAN_KAYIT_TURU,
            this.colSAGLIKs,
            this.colSUTs});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 27;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            // 
            // colKAYITNO
            // 
            this.colKAYITNO.Caption = "Kayıt No";
            this.colKAYITNO.FieldName = "KAYITNO";
            this.colKAYITNO.Name = "colKAYITNO";
            this.colKAYITNO.OptionsColumn.AllowEdit = false;
            this.colKAYITNO.OptionsColumn.AllowFocus = false;
            this.colKAYITNO.OptionsColumn.ReadOnly = true;
            this.colKAYITNO.Visible = true;
            this.colKAYITNO.VisibleIndex = 0;
            // 
            // colKAYIT_TARIHI
            // 
            this.colKAYIT_TARIHI.Caption = "Kayıt Tarihi";
            this.colKAYIT_TARIHI.FieldName = "KAYIT_TARIHI";
            this.colKAYIT_TARIHI.Name = "colKAYIT_TARIHI";
            this.colKAYIT_TARIHI.OptionsColumn.AllowEdit = false;
            this.colKAYIT_TARIHI.OptionsColumn.AllowFocus = false;
            this.colKAYIT_TARIHI.OptionsColumn.ReadOnly = true;
            this.colKAYIT_TARIHI.Visible = true;
            this.colKAYIT_TARIHI.VisibleIndex = 1;
            // 
            // colDEVLET_NO
            // 
            this.colDEVLET_NO.Caption = "Devlet Kayıt No";
            this.colDEVLET_NO.FieldName = "DEVLET_NO";
            this.colDEVLET_NO.Name = "colDEVLET_NO";
            this.colDEVLET_NO.OptionsColumn.AllowEdit = false;
            this.colDEVLET_NO.OptionsColumn.AllowFocus = false;
            this.colDEVLET_NO.OptionsColumn.ReadOnly = true;
            this.colDEVLET_NO.Visible = true;
            this.colDEVLET_NO.VisibleIndex = 2;
            // 
            // colBOYUN_NO
            // 
            this.colBOYUN_NO.Caption = "Boyun No";
            this.colBOYUN_NO.FieldName = "BOYUN_NO";
            this.colBOYUN_NO.Name = "colBOYUN_NO";
            this.colBOYUN_NO.OptionsColumn.AllowEdit = false;
            this.colBOYUN_NO.OptionsColumn.AllowFocus = false;
            this.colBOYUN_NO.OptionsColumn.ReadOnly = true;
            this.colBOYUN_NO.Visible = true;
            this.colBOYUN_NO.VisibleIndex = 3;
            // 
            // colKULAK_NO
            // 
            this.colKULAK_NO.Caption = "Kulak No";
            this.colKULAK_NO.FieldName = "KULAK_NO";
            this.colKULAK_NO.Name = "colKULAK_NO";
            this.colKULAK_NO.OptionsColumn.AllowEdit = false;
            this.colKULAK_NO.OptionsColumn.AllowFocus = false;
            this.colKULAK_NO.OptionsColumn.ReadOnly = true;
            this.colKULAK_NO.Visible = true;
            this.colKULAK_NO.VisibleIndex = 4;
            // 
            // colCINSIYETI
            // 
            this.colCINSIYETI.Caption = "Cinsiyeti";
            this.colCINSIYETI.FieldName = "CINSIYETI";
            this.colCINSIYETI.Name = "colCINSIYETI";
            this.colCINSIYETI.OptionsColumn.AllowEdit = false;
            this.colCINSIYETI.OptionsColumn.AllowFocus = false;
            this.colCINSIYETI.OptionsColumn.ReadOnly = true;
            this.colCINSIYETI.Visible = true;
            this.colCINSIYETI.VisibleIndex = 5;
            // 
            // colANNE_KAYITNO
            // 
            this.colANNE_KAYITNO.FieldName = "ANNE_KAYITNO";
            this.colANNE_KAYITNO.Name = "colANNE_KAYITNO";
            this.colANNE_KAYITNO.OptionsColumn.AllowEdit = false;
            this.colANNE_KAYITNO.OptionsColumn.AllowFocus = false;
            this.colANNE_KAYITNO.OptionsColumn.ReadOnly = true;
            // 
            // colBABA_KAYITNO
            // 
            this.colBABA_KAYITNO.FieldName = "BABA_KAYITNO";
            this.colBABA_KAYITNO.Name = "colBABA_KAYITNO";
            this.colBABA_KAYITNO.OptionsColumn.AllowEdit = false;
            this.colBABA_KAYITNO.OptionsColumn.AllowFocus = false;
            this.colBABA_KAYITNO.OptionsColumn.ReadOnly = true;
            // 
            // colHAYVANCINSI_SIRANO
            // 
            this.colHAYVANCINSI_SIRANO.FieldName = "HAYVANCINSI_SIRANO";
            this.colHAYVANCINSI_SIRANO.Name = "colHAYVANCINSI_SIRANO";
            this.colHAYVANCINSI_SIRANO.OptionsColumn.AllowEdit = false;
            this.colHAYVANCINSI_SIRANO.OptionsColumn.AllowFocus = false;
            this.colHAYVANCINSI_SIRANO.OptionsColumn.ReadOnly = true;
            // 
            // colHAYVANKAYITTURU_SIRANO
            // 
            this.colHAYVANKAYITTURU_SIRANO.FieldName = "HAYVANKAYITTURU_SIRANO";
            this.colHAYVANKAYITTURU_SIRANO.Name = "colHAYVANKAYITTURU_SIRANO";
            this.colHAYVANKAYITTURU_SIRANO.OptionsColumn.AllowEdit = false;
            this.colHAYVANKAYITTURU_SIRANO.OptionsColumn.AllowFocus = false;
            this.colHAYVANKAYITTURU_SIRANO.OptionsColumn.ReadOnly = true;
            // 
            // colDOGUM_TARIHI
            // 
            this.colDOGUM_TARIHI.Caption = "Doğum Tarihi";
            this.colDOGUM_TARIHI.FieldName = "DOGUM_TARIHI";
            this.colDOGUM_TARIHI.Name = "colDOGUM_TARIHI";
            this.colDOGUM_TARIHI.OptionsColumn.AllowEdit = false;
            this.colDOGUM_TARIHI.OptionsColumn.AllowFocus = false;
            this.colDOGUM_TARIHI.OptionsColumn.ReadOnly = true;
            this.colDOGUM_TARIHI.Visible = true;
            this.colDOGUM_TARIHI.VisibleIndex = 6;
            // 
            // colHAYVAN_CINSI
            // 
            this.colHAYVAN_CINSI.Caption = "Cinsi";
            this.colHAYVAN_CINSI.FieldName = "HAYVAN_CINSI.CINS_ADI";
            this.colHAYVAN_CINSI.Name = "colHAYVAN_CINSI";
            this.colHAYVAN_CINSI.OptionsColumn.AllowEdit = false;
            this.colHAYVAN_CINSI.OptionsColumn.AllowFocus = false;
            this.colHAYVAN_CINSI.OptionsColumn.ReadOnly = true;
            this.colHAYVAN_CINSI.Visible = true;
            this.colHAYVAN_CINSI.VisibleIndex = 7;
            // 
            // colHAYVAN_DOGUM_TURU
            // 
            this.colHAYVAN_DOGUM_TURU.FieldName = "HAYVAN_DOGUM_TURU";
            this.colHAYVAN_DOGUM_TURU.Name = "colHAYVAN_DOGUM_TURU";
            this.colHAYVAN_DOGUM_TURU.OptionsColumn.AllowEdit = false;
            this.colHAYVAN_DOGUM_TURU.OptionsColumn.AllowFocus = false;
            this.colHAYVAN_DOGUM_TURU.OptionsColumn.ReadOnly = true;
            // 
            // colHAYVAN_YEM_KARISIM_YEM_TURU
            // 
            this.colHAYVAN_YEM_KARISIM_YEM_TURU.FieldName = "HAYVAN_YEM_KARISIM_YEM_TURU";
            this.colHAYVAN_YEM_KARISIM_YEM_TURU.Name = "colHAYVAN_YEM_KARISIM_YEM_TURU";
            this.colHAYVAN_YEM_KARISIM_YEM_TURU.OptionsColumn.AllowEdit = false;
            this.colHAYVAN_YEM_KARISIM_YEM_TURU.OptionsColumn.AllowFocus = false;
            this.colHAYVAN_YEM_KARISIM_YEM_TURU.OptionsColumn.ReadOnly = true;
            // 
            // colHAYVAN_KAYIT_TURU
            // 
            this.colHAYVAN_KAYIT_TURU.Caption = "Kayıt Türü";
            this.colHAYVAN_KAYIT_TURU.FieldName = "HAYVAN_KAYIT_TURU.KAYIT_TURU_ADU";
            this.colHAYVAN_KAYIT_TURU.Name = "colHAYVAN_KAYIT_TURU";
            this.colHAYVAN_KAYIT_TURU.OptionsColumn.AllowEdit = false;
            this.colHAYVAN_KAYIT_TURU.OptionsColumn.AllowFocus = false;
            this.colHAYVAN_KAYIT_TURU.OptionsColumn.ReadOnly = true;
            this.colHAYVAN_KAYIT_TURU.Visible = true;
            this.colHAYVAN_KAYIT_TURU.VisibleIndex = 8;
            // 
            // colSAGLIKs
            // 
            this.colSAGLIKs.FieldName = "SAGLIKs";
            this.colSAGLIKs.Name = "colSAGLIKs";
            this.colSAGLIKs.OptionsColumn.AllowEdit = false;
            this.colSAGLIKs.OptionsColumn.AllowFocus = false;
            this.colSAGLIKs.OptionsColumn.ReadOnly = true;
            // 
            // colSUTs
            // 
            this.colSUTs.FieldName = "SUTs";
            this.colSUTs.Name = "colSUTs";
            this.colSUTs.OptionsColumn.AllowEdit = false;
            this.colSUTs.OptionsColumn.AllowFocus = false;
            this.colSUTs.OptionsColumn.ReadOnly = true;
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Images = this.imageCollection2;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9});
            this.barManager2.MaxItemId = 9;
            this.barManager2.StatusBar = this.bar4;
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem9),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem8)});
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Yeni";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.ImageIndex = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Hayvan Kartını Aç";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Sil";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.ImageOptions.ImageIndex = 13;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Süt Sağım İşlemleri";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Yemleme İşlemleri";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Doğum İşlemleri";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Listeyi Yazdır";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.ImageOptions.ImageIndex = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Kapat";
            this.barButtonItem8.Id = 7;
            this.barButtonItem8.ImageOptions.ImageIndex = 22;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem8.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem8_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(928, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 503);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(928, 26);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 503);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(928, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 503);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Muayene İşlemleri";
            this.barButtonItem9.Id = 8;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // frmHayvanListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 529);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHayvanListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hayvan Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hAYVANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private System.Windows.Forms.BindingSource hAYVANBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colKAYITNO;
        private DevExpress.XtraGrid.Columns.GridColumn colKAYIT_TARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colDEVLET_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBOYUN_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colKULAK_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colCINSIYETI;
        private DevExpress.XtraGrid.Columns.GridColumn colANNE_KAYITNO;
        private DevExpress.XtraGrid.Columns.GridColumn colBABA_KAYITNO;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVANCINSI_SIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVANKAYITTURU_SIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colDOGUM_TARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN_CINSI;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN_DOGUM_TURU;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN_YEM_KARISIM_YEM_TURU;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN_KAYIT_TURU;
        private DevExpress.XtraGrid.Columns.GridColumn colSAGLIKs;
        private DevExpress.XtraGrid.Columns.GridColumn colSUTs;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
    }
}