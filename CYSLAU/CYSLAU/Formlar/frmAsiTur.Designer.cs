﻿namespace CYSLAU.Formlar
{
    partial class frmAsiTur
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsiTur));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcAsiTuru = new DevExpress.XtraGrid.GridControl();
            this.aSITURUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAsiTuru = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colASI_ADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSAGLIKs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtAsiAdi = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsiTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSITURUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsiTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcAsiTuru);
            this.layoutControl1.Controls.Add(this.txtAsiAdi);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(347, 320);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcAsiTuru
            // 
            this.gcAsiTuru.DataSource = this.aSITURUBindingSource;
            this.gcAsiTuru.Location = new System.Drawing.Point(3, 27);
            this.gcAsiTuru.MainView = this.gvAsiTuru;
            this.gcAsiTuru.Name = "gcAsiTuru";
            this.gcAsiTuru.Size = new System.Drawing.Size(341, 290);
            this.gcAsiTuru.TabIndex = 5;
            this.gcAsiTuru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAsiTuru});
            // 
            // aSITURUBindingSource
            // 
            this.aSITURUBindingSource.DataSource = typeof(CYSLAU.DB.ASI_TURU);
            // 
            // gvAsiTuru
            // 
            this.gvAsiTuru.Appearance.EvenRow.BackColor = System.Drawing.Color.AliceBlue;
            this.gvAsiTuru.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvAsiTuru.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSIRANO,
            this.colASI_ADI,
            this.colSAGLIKs});
            this.gvAsiTuru.GridControl = this.gcAsiTuru;
            this.gvAsiTuru.Name = "gvAsiTuru";
            this.gvAsiTuru.OptionsView.EnableAppearanceEvenRow = true;
            this.gvAsiTuru.OptionsView.ShowGroupPanel = false;
            this.gvAsiTuru.OptionsView.ShowIndicator = false;
            this.gvAsiTuru.RowHeight = 27;
            this.gvAsiTuru.Click += new System.EventHandler(this.gvAsiTuru_Click);
            // 
            // colSIRANO
            // 
            this.colSIRANO.Caption = "Kayıt No";
            this.colSIRANO.FieldName = "SIRANO";
            this.colSIRANO.Name = "colSIRANO";
            this.colSIRANO.OptionsColumn.AllowEdit = false;
            this.colSIRANO.OptionsColumn.AllowFocus = false;
            this.colSIRANO.OptionsColumn.FixedWidth = true;
            this.colSIRANO.OptionsColumn.ReadOnly = true;
            this.colSIRANO.Visible = true;
            this.colSIRANO.VisibleIndex = 0;
            this.colSIRANO.Width = 55;
            // 
            // colASI_ADI
            // 
            this.colASI_ADI.Caption = "Aşı Adı";
            this.colASI_ADI.FieldName = "ASI_ADI";
            this.colASI_ADI.Name = "colASI_ADI";
            this.colASI_ADI.OptionsColumn.AllowEdit = false;
            this.colASI_ADI.OptionsColumn.AllowFocus = false;
            this.colASI_ADI.OptionsColumn.ReadOnly = true;
            this.colASI_ADI.Visible = true;
            this.colASI_ADI.VisibleIndex = 1;
            this.colASI_ADI.Width = 339;
            // 
            // colSAGLIKs
            // 
            this.colSAGLIKs.FieldName = "SAGLIKs";
            this.colSAGLIKs.Name = "colSAGLIKs";
            this.colSAGLIKs.OptionsColumn.AllowEdit = false;
            this.colSAGLIKs.OptionsColumn.AllowFocus = false;
            this.colSAGLIKs.OptionsColumn.ReadOnly = true;
            // 
            // txtAsiAdi
            // 
            this.txtAsiAdi.Location = new System.Drawing.Point(38, 3);
            this.txtAsiAdi.Name = "txtAsiAdi";
            this.txtAsiAdi.Size = new System.Drawing.Size(306, 20);
            this.txtAsiAdi.StyleController = this.layoutControl1;
            this.txtAsiAdi.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Aşı adı girilmelidir";
            this.dxValidationProvider1.SetValidationRule(this.txtAsiAdi, conditionValidationRule1);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.Root.Size = new System.Drawing.Size(347, 320);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtAsiAdi;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(345, 24);
            this.layoutControlItem1.Text = "Aşı Adı";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(32, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcAsiTuru;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(345, 294);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
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
            this.barButtonItem4});
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
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
            this.barButtonItem2.Caption = "Kaydet";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.ImageIndex = 10;
            this.barButtonItem2.ImageOptions.LargeImageIndex = 10;
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
            this.barButtonItem4.Caption = "Kapat";
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.ImageOptions.ImageIndex = 22;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(347, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 320);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(347, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 320);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(347, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 320);
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // frmAsiTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 346);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.Name = "frmAsiTur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aşı Türleri";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAsiTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSITURUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsiTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsiAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcAsiTuru;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAsiTuru;
        private DevExpress.XtraEditors.TextEdit txtAsiAdi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource aSITURUBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colASI_ADI;
        private DevExpress.XtraGrid.Columns.GridColumn colSAGLIKs;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}