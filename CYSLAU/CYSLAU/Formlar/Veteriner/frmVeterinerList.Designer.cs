namespace CYSLAU.Formlar.Veteriner
{
    partial class frmVeterinerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVeterinerList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vETERINERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVETERINER_ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEPOSTA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOTLAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAYVAN_DOGUM_TURU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAGLIKs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vETERINERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vETERINERBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(535, 481);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // vETERINERBindingSource
            // 
            this.vETERINERBindingSource.DataSource = typeof(CYSLAU.DB.VETERINER);
            // 
            // gridView1
            // 
            this.gridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.AliceBlue;
            this.gridView1.Appearance.EvenRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSIRANO,
            this.colVETERINER_ADI,
            this.colADRES,
            this.colTELEFON1,
            this.colTELEFON2,
            this.colEPOSTA,
            this.colNOTLAR,
            this.colHAYVAN_DOGUM_TURU,
            this.colSAGLIKs});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.RowHeight = 27;
            // 
            // colSIRANO
            // 
            this.colSIRANO.FieldName = "SIRANO";
            this.colSIRANO.Name = "colSIRANO";
            this.colSIRANO.OptionsColumn.AllowEdit = false;
            this.colSIRANO.OptionsColumn.AllowFocus = false;
            this.colSIRANO.OptionsColumn.ReadOnly = true;
            // 
            // colVETERINER_ADI
            // 
            this.colVETERINER_ADI.Caption = "Veteriner Adı";
            this.colVETERINER_ADI.FieldName = "VETERINER_ADI";
            this.colVETERINER_ADI.Name = "colVETERINER_ADI";
            this.colVETERINER_ADI.OptionsColumn.AllowEdit = false;
            this.colVETERINER_ADI.OptionsColumn.AllowFocus = false;
            this.colVETERINER_ADI.OptionsColumn.ReadOnly = true;
            this.colVETERINER_ADI.Visible = true;
            this.colVETERINER_ADI.VisibleIndex = 0;
            // 
            // colADRES
            // 
            this.colADRES.Caption = "Adres";
            this.colADRES.FieldName = "ADRES";
            this.colADRES.Name = "colADRES";
            this.colADRES.OptionsColumn.AllowEdit = false;
            this.colADRES.OptionsColumn.AllowFocus = false;
            this.colADRES.OptionsColumn.ReadOnly = true;
            this.colADRES.Visible = true;
            this.colADRES.VisibleIndex = 1;
            // 
            // colTELEFON1
            // 
            this.colTELEFON1.Caption = "Telefon #1";
            this.colTELEFON1.FieldName = "TELEFON1";
            this.colTELEFON1.Name = "colTELEFON1";
            this.colTELEFON1.OptionsColumn.AllowEdit = false;
            this.colTELEFON1.OptionsColumn.AllowFocus = false;
            this.colTELEFON1.OptionsColumn.ReadOnly = true;
            this.colTELEFON1.Visible = true;
            this.colTELEFON1.VisibleIndex = 2;
            // 
            // colTELEFON2
            // 
            this.colTELEFON2.Caption = "Telefon #2";
            this.colTELEFON2.FieldName = "TELEFON2";
            this.colTELEFON2.Name = "colTELEFON2";
            this.colTELEFON2.OptionsColumn.AllowEdit = false;
            this.colTELEFON2.OptionsColumn.AllowFocus = false;
            this.colTELEFON2.OptionsColumn.ReadOnly = true;
            this.colTELEFON2.Visible = true;
            this.colTELEFON2.VisibleIndex = 3;
            // 
            // colEPOSTA
            // 
            this.colEPOSTA.Caption = "E-Posta";
            this.colEPOSTA.FieldName = "EPOSTA";
            this.colEPOSTA.Name = "colEPOSTA";
            this.colEPOSTA.OptionsColumn.AllowEdit = false;
            this.colEPOSTA.OptionsColumn.AllowFocus = false;
            this.colEPOSTA.OptionsColumn.ReadOnly = true;
            this.colEPOSTA.Visible = true;
            this.colEPOSTA.VisibleIndex = 4;
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
            this.colNOTLAR.VisibleIndex = 5;
            // 
            // colHAYVAN_DOGUM_TURU
            // 
            this.colHAYVAN_DOGUM_TURU.FieldName = "HAYVAN_DOGUM_TURU";
            this.colHAYVAN_DOGUM_TURU.Name = "colHAYVAN_DOGUM_TURU";
            this.colHAYVAN_DOGUM_TURU.OptionsColumn.AllowEdit = false;
            this.colHAYVAN_DOGUM_TURU.OptionsColumn.AllowFocus = false;
            this.colHAYVAN_DOGUM_TURU.OptionsColumn.ReadOnly = true;
            // 
            // colSAGLIKs
            // 
            this.colSAGLIKs.FieldName = "SAGLIKs";
            this.colSAGLIKs.Name = "colSAGLIKs";
            this.colSAGLIKs.OptionsColumn.AllowEdit = false;
            this.colSAGLIKs.OptionsColumn.AllowFocus = false;
            this.colSAGLIKs.OptionsColumn.ReadOnly = true;
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
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem5),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
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
            this.barButtonItem2.Caption = "Kartı Aç";
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
            this.barButtonItem4.Caption = "Muayene İşlemleri";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.ImageIndex = 0;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Listeyi Yazdır";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.ImageOptions.ImageIndex = 9;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(535, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(535, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(535, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // frmVeterinerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 507);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmVeterinerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veteriner Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vETERINERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private System.Windows.Forms.BindingSource vETERINERBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colVETERINER_ADI;
        private DevExpress.XtraGrid.Columns.GridColumn colADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON1;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON2;
        private DevExpress.XtraGrid.Columns.GridColumn colEPOSTA;
        private DevExpress.XtraGrid.Columns.GridColumn colNOTLAR;
        private DevExpress.XtraGrid.Columns.GridColumn colHAYVAN_DOGUM_TURU;
        private DevExpress.XtraGrid.Columns.GridColumn colSAGLIKs;
    }
}