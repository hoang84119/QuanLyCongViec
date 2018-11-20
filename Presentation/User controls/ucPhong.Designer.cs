namespace Presentation.User_controls
{
    partial class ucPhong
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPhong));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableSpan tableSpan1 = new DevExpress.XtraEditors.TableLayout.TableSpan();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.flyoutPanelEdit = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.layoutEdit = new DevExpress.XtraLayout.LayoutControl();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gridEditNV = new DevExpress.XtraEditors.GridLookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridEditNVView = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colHinh = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelEdit)).BeginInit();
            this.flyoutPanelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEdit)).BeginInit();
            this.layoutEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditNVView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 53);
            this.panel1.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(113, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 34);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(201, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 34);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(22, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 34);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // flyoutPanelEdit
            // 
            this.flyoutPanelEdit.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanelEdit.Location = new System.Drawing.Point(0, 59);
            this.flyoutPanelEdit.Name = "flyoutPanelEdit";
            this.flyoutPanelEdit.OptionsButtonPanel.ButtonPanelHeight = 40;
            this.flyoutPanelEdit.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            this.flyoutPanelEdit.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Lưu", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Save", -1, false),
            new DevExpress.Utils.PeekFormButton("Hủy", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Cancel", -1, false)});
            this.flyoutPanelEdit.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanelEdit.OwnerControl = this;
            this.flyoutPanelEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.flyoutPanelEdit.Size = new System.Drawing.Size(839, 89);
            this.flyoutPanelEdit.TabIndex = 5;
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.layoutEdit);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanelEdit;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(839, 49);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // layoutEdit
            // 
            this.layoutEdit.Controls.Add(this.gridEditNV);
            this.layoutEdit.Controls.Add(this.txtTenPhong);
            this.layoutEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutEdit.Location = new System.Drawing.Point(2, 2);
            this.layoutEdit.Name = "layoutEdit";
            this.layoutEdit.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 0, 650, 400);
            this.layoutEdit.Root = this.layoutControlGroup1;
            this.layoutEdit.Size = new System.Drawing.Size(835, 45);
            this.layoutEdit.TabIndex = 2;
            this.layoutEdit.Text = "layoutControl1";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(66, 12);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(201, 20);
            this.txtTenPhong.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(835, 45);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTenPhong;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(259, 25);
            this.layoutControlItem1.Text = "Tên phòng";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(259, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(127, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gridEditNV
            // 
            this.gridEditNV.Location = new System.Drawing.Point(452, 12);
            this.gridEditNV.Name = "gridEditNV";
            this.gridEditNV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridEditNV.Properties.PopupView = this.gridEditNVView;
            this.gridEditNV.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView;
            this.gridEditNV.Size = new System.Drawing.Size(371, 20);
            this.gridEditNV.StyleController = this.layoutEdit;
            this.gridEditNV.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridEditNV;
            this.layoutControlItem2.Location = new System.Drawing.Point(386, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(429, 25);
            this.layoutControlItem2.Text = "Nhân viên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // gridEditNVView
            // 
            this.gridEditNVView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colHinh});
            this.gridEditNVView.Name = "gridEditNVView";
            this.gridEditNVView.OptionsBehavior.AllowMousePanning = false;
            this.gridEditNVView.OptionsBehavior.AllowSmoothScrolling = true;
            this.gridEditNVView.OptionsTiles.AllowPressAnimation = false;
            this.gridEditNVView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List;
            this.gridEditNVView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.gridEditNVView.OptionsTiles.Padding = new System.Windows.Forms.Padding(0);
            this.gridEditNVView.TileColumns.Add(tableColumnDefinition1);
            this.gridEditNVView.TileColumns.Add(tableColumnDefinition2);
            this.gridEditNVView.TileRows.Add(tableRowDefinition1);
            this.gridEditNVView.TileRows.Add(tableRowDefinition2);
            tableSpan1.RowSpan = 2;
            this.gridEditNVView.TileSpans.Add(tableSpan1);
            tileViewItemElement1.Column = this.colMaNV;
            tileViewItemElement1.ColumnIndex = 1;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colMaNV";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colHinh;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "colHinh";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colHoTen;
            tileViewItemElement3.ColumnIndex = 1;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "colHoTen";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.gridEditNVView.TileTemplate.Add(tileViewItemElement1);
            this.gridEditNVView.TileTemplate.Add(tileViewItemElement2);
            this.gridEditNVView.TileTemplate.Add(tileViewItemElement3);
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã NV";
            this.colMaNV.FieldName = "MaNhanVien";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colHinh
            // 
            this.colHinh.Caption = "Hình";
            this.colHinh.FieldName = "Hinh";
            this.colHinh.Name = "colHinh";
            this.colHinh.Visible = true;
            this.colHinh.VisibleIndex = 2;
            // 
            // ucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanelEdit);
            this.Controls.Add(this.panel1);
            this.Name = "ucPhong";
            this.Size = new System.Drawing.Size(841, 492);
            this.Load += new System.EventHandler(this.ucPhong_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelEdit)).EndInit();
            this.flyoutPanelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutEdit)).EndInit();
            this.layoutEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditNVView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.Utils.FlyoutPanel flyoutPanelEdit;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutEdit;
        private System.Windows.Forms.TextBox txtTenPhong;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.GridLookUpEdit gridEditNV;
        private DevExpress.XtraGrid.Views.Tile.TileView gridEditNVView;
        private DevExpress.XtraGrid.Columns.TileViewColumn colMaNV;
        private DevExpress.XtraGrid.Columns.TileViewColumn colHoTen;
        private DevExpress.XtraGrid.Columns.TileViewColumn colHinh;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
