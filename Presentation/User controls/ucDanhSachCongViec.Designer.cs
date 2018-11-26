namespace Presentation.User_controls
{
    partial class ucDanhSachCongViec
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDanhSachCongViec));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.gcDanhSachCongViec = new DevExpress.XtraGrid.GridControl();
            this.gvDanhSachCongViec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNguoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flyoutPanelEdit = new DevExpress.Utils.FlyoutPanel();
            this.flyoutPanelControl1 = new DevExpress.Utils.FlyoutPanelControl();
            this.layoutEdit = new DevExpress.XtraLayout.LayoutControl();
            this.gcDSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvDSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtNgayBatDau = new DevExpress.XtraEditors.DateEdit();
            this.cbbDuAn = new System.Windows.Forms.ComboBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTenCongViec = new DevExpress.XtraEditors.TextEdit();
            this.txtNgayHetHan = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelEdit)).BeginInit();
            this.flyoutPanelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).BeginInit();
            this.flyoutPanelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEdit)).BeginInit();
            this.layoutEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDanhSachCongViec
            // 
            this.gcDanhSachCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDanhSachCongViec.Location = new System.Drawing.Point(0, 0);
            this.gcDanhSachCongViec.MainView = this.gvDanhSachCongViec;
            this.gcDanhSachCongViec.Name = "gcDanhSachCongViec";
            this.gcDanhSachCongViec.Size = new System.Drawing.Size(887, 542);
            this.gcDanhSachCongViec.TabIndex = 0;
            this.gcDanhSachCongViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDanhSachCongViec});
            this.gcDanhSachCongViec.Load += new System.EventHandler(this.gcDanhSachCongViec_Load);
            this.gcDanhSachCongViec.Click += new System.EventHandler(this.gcDanhSachCongViec_Click);
            // 
            // gvDanhSachCongViec
            // 
            this.gvDanhSachCongViec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaCV,
            this.gcTenCV,
            this.gcNguoiGiao,
            this.gcNgayBatDau,
            this.gcNgayHetHan,
            this.gcMoTa,
            this.gcTrangThai});
            this.gvDanhSachCongViec.GridControl = this.gcDanhSachCongViec;
            this.gvDanhSachCongViec.GroupPanelText = "Kéo tiêu đề của một cột vào đây để nhóm theo cột đó";
            this.gvDanhSachCongViec.Name = "gvDanhSachCongViec";
            this.gvDanhSachCongViec.OptionsView.ShowIndicator = false;
            this.gvDanhSachCongViec.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcTrangThai, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcNgayHetHan, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDanhSachCongViec.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvDanhSachCongViec_RowStyle);
            // 
            // gcMaCV
            // 
            this.gcMaCV.Caption = "Mã CV";
            this.gcMaCV.FieldName = "MaCongViec";
            this.gcMaCV.Name = "gcMaCV";
            this.gcMaCV.OptionsColumn.AllowEdit = false;
            this.gcMaCV.OptionsColumn.FixedWidth = true;
            this.gcMaCV.Visible = true;
            this.gcMaCV.VisibleIndex = 0;
            this.gcMaCV.Width = 45;
            // 
            // gcTenCV
            // 
            this.gcTenCV.Caption = "Tên công việc";
            this.gcTenCV.FieldName = "TenCV";
            this.gcTenCV.Name = "gcTenCV";
            this.gcTenCV.OptionsColumn.AllowEdit = false;
            this.gcTenCV.Visible = true;
            this.gcTenCV.VisibleIndex = 1;
            this.gcTenCV.Width = 87;
            // 
            // gcNguoiGiao
            // 
            this.gcNguoiGiao.Caption = "Người giao";
            this.gcNguoiGiao.FieldName = "HoTen";
            this.gcNguoiGiao.Name = "gcNguoiGiao";
            this.gcNguoiGiao.OptionsColumn.AllowEdit = false;
            this.gcNguoiGiao.Visible = true;
            this.gcNguoiGiao.VisibleIndex = 2;
            this.gcNguoiGiao.Width = 87;
            // 
            // gcNgayBatDau
            // 
            this.gcNgayBatDau.Caption = "Ngày bắt đầu";
            this.gcNgayBatDau.FieldName = "NgayBatDau";
            this.gcNgayBatDau.Name = "gcNgayBatDau";
            this.gcNgayBatDau.OptionsColumn.AllowEdit = false;
            this.gcNgayBatDau.Visible = true;
            this.gcNgayBatDau.VisibleIndex = 3;
            this.gcNgayBatDau.Width = 87;
            // 
            // gcNgayHetHan
            // 
            this.gcNgayHetHan.Caption = "Ngày hết hạn";
            this.gcNgayHetHan.FieldName = "NgayHetHan";
            this.gcNgayHetHan.Name = "gcNgayHetHan";
            this.gcNgayHetHan.OptionsColumn.AllowEdit = false;
            this.gcNgayHetHan.Visible = true;
            this.gcNgayHetHan.VisibleIndex = 4;
            this.gcNgayHetHan.Width = 87;
            // 
            // gcMoTa
            // 
            this.gcMoTa.Caption = "Mô tả";
            this.gcMoTa.FieldName = "MoTa";
            this.gcMoTa.Name = "gcMoTa";
            this.gcMoTa.OptionsColumn.AllowEdit = false;
            this.gcMoTa.Visible = true;
            this.gcMoTa.VisibleIndex = 5;
            // 
            // gcTrangThai
            // 
            this.gcTrangThai.Caption = "Trạng thái";
            this.gcTrangThai.FieldName = "TrangThai";
            this.gcTrangThai.Name = "gcTrangThai";
            this.gcTrangThai.Visible = true;
            this.gcTrangThai.VisibleIndex = 6;
            this.gcTrangThai.Width = 95;
            // 
            // flyoutPanelEdit
            // 
            this.flyoutPanelEdit.Controls.Add(this.flyoutPanelControl1);
            this.flyoutPanelEdit.Location = new System.Drawing.Point(3, 3);
            this.flyoutPanelEdit.Name = "flyoutPanelEdit";
            this.flyoutPanelEdit.Options.AnchorType = DevExpress.Utils.Win.PopupToolWindowAnchor.Right;
            this.flyoutPanelEdit.Options.CloseOnOuterClick = true;
            this.flyoutPanelEdit.OptionsButtonPanel.ButtonPanelHeight = 40;
            this.flyoutPanelEdit.OptionsButtonPanel.ButtonPanelLocation = DevExpress.Utils.FlyoutPanelButtonPanelLocation.Bottom;
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            this.flyoutPanelEdit.OptionsButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.Utils.PeekFormButton("Hoàn thành", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "HoanThanh", -1, false),
            new DevExpress.Utils.PeekFormButton("Chưa hoàn thành", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "ChuaHoanThanh", -1, false),
            new DevExpress.Utils.PeekFormButton("Hủy", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "Cancel", -1, false)});
            this.flyoutPanelEdit.OptionsButtonPanel.ShowButtonPanel = true;
            this.flyoutPanelEdit.OwnerControl = this;
            this.flyoutPanelEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 40);
            this.flyoutPanelEdit.Size = new System.Drawing.Size(374, 535);
            this.flyoutPanelEdit.TabIndex = 6;
            this.flyoutPanelEdit.ButtonClick += new DevExpress.Utils.FlyoutPanelButtonClickEventHandler(this.flyoutPanelEdit_ButtonClick);
            // 
            // flyoutPanelControl1
            // 
            this.flyoutPanelControl1.Controls.Add(this.layoutEdit);
            this.flyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flyoutPanelControl1.FlyoutPanel = this.flyoutPanelEdit;
            this.flyoutPanelControl1.Location = new System.Drawing.Point(0, 0);
            this.flyoutPanelControl1.Name = "flyoutPanelControl1";
            this.flyoutPanelControl1.Size = new System.Drawing.Size(374, 495);
            this.flyoutPanelControl1.TabIndex = 0;
            // 
            // layoutEdit
            // 
            this.layoutEdit.Controls.Add(this.gcDSNhanVien);
            this.layoutEdit.Controls.Add(this.txtNgayBatDau);
            this.layoutEdit.Controls.Add(this.cbbDuAn);
            this.layoutEdit.Controls.Add(this.txtMoTa);
            this.layoutEdit.Controls.Add(this.txtTenCongViec);
            this.layoutEdit.Controls.Add(this.txtNgayHetHan);
            this.layoutEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutEdit.Location = new System.Drawing.Point(2, 2);
            this.layoutEdit.Name = "layoutEdit";
            this.layoutEdit.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 0, 650, 400);
            this.layoutEdit.Root = this.layoutControlGroup1;
            this.layoutEdit.Size = new System.Drawing.Size(370, 491);
            this.layoutEdit.TabIndex = 0;
            this.layoutEdit.Text = "layoutControl1";
            // 
            // gcDSNhanVien
            // 
            this.gcDSNhanVien.Location = new System.Drawing.Point(12, 207);
            this.gcDSNhanVien.MainView = this.gvDSNhanVien;
            this.gcDSNhanVien.Name = "gcDSNhanVien";
            this.gcDSNhanVien.Size = new System.Drawing.Size(346, 207);
            this.gcDSNhanVien.TabIndex = 39;
            this.gcDSNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDSNhanVien});
            // 
            // gvDSNhanVien
            // 
            this.gvDSNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnTenNV,
            this.gridColumnMoTa});
            this.gvDSNhanVien.GridControl = this.gcDSNhanVien;
            this.gvDSNhanVien.Name = "gvDSNhanVien";
            this.gvDSNhanVien.OptionsView.ShowGroupPanel = false;
            this.gvDSNhanVien.OptionsView.ShowIndicator = false;
            // 
            // gridColumnTenNV
            // 
            this.gridColumnTenNV.Caption = "Họ Tên";
            this.gridColumnTenNV.FieldName = "NHANVIEN.HoTen";
            this.gridColumnTenNV.Name = "gridColumnTenNV";
            this.gridColumnTenNV.OptionsColumn.AllowEdit = false;
            this.gridColumnTenNV.Visible = true;
            this.gridColumnTenNV.VisibleIndex = 0;
            // 
            // gridColumnMoTa
            // 
            this.gridColumnMoTa.Caption = "Mô tả";
            this.gridColumnMoTa.FieldName = "MoTa";
            this.gridColumnMoTa.Name = "gridColumnMoTa";
            this.gridColumnMoTa.OptionsColumn.AllowEdit = false;
            this.gridColumnMoTa.Visible = true;
            this.gridColumnMoTa.VisibleIndex = 1;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.EditValue = null;
            this.txtNgayBatDau.Enabled = false;
            this.txtNgayBatDau.Location = new System.Drawing.Point(81, 36);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayBatDau.Properties.DisplayFormat.FormatString = "";
            this.txtNgayBatDau.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBatDau.Properties.EditFormat.FormatString = "";
            this.txtNgayBatDau.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayBatDau.Properties.Mask.EditMask = "";
            this.txtNgayBatDau.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgayBatDau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNgayBatDau.Size = new System.Drawing.Size(277, 20);
            this.txtNgayBatDau.StyleController = this.layoutEdit;
            this.txtNgayBatDau.TabIndex = 38;
            // 
            // cbbDuAn
            // 
            this.cbbDuAn.Enabled = false;
            this.cbbDuAn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbDuAn.FormattingEnabled = true;
            this.cbbDuAn.Location = new System.Drawing.Point(81, 84);
            this.cbbDuAn.Name = "cbbDuAn";
            this.cbbDuAn.Size = new System.Drawing.Size(277, 22);
            this.cbbDuAn.TabIndex = 37;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Enabled = false;
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtMoTa.Location = new System.Drawing.Point(81, 109);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(277, 77);
            this.txtMoTa.TabIndex = 36;
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Enabled = false;
            this.txtTenCongViec.Location = new System.Drawing.Point(81, 12);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(277, 20);
            this.txtTenCongViec.StyleController = this.layoutEdit;
            this.txtTenCongViec.TabIndex = 34;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.EditValue = null;
            this.txtNgayHetHan.Enabled = false;
            this.txtNgayHetHan.Location = new System.Drawing.Point(81, 60);
            this.txtNgayHetHan.Name = "txtNgayHetHan";
            this.txtNgayHetHan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayHetHan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNgayHetHan.Properties.DisplayFormat.FormatString = "";
            this.txtNgayHetHan.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayHetHan.Properties.EditFormat.FormatString = "";
            this.txtNgayHetHan.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtNgayHetHan.Properties.Mask.EditMask = "";
            this.txtNgayHetHan.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtNgayHetHan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtNgayHetHan.Size = new System.Drawing.Size(277, 20);
            this.txtNgayHetHan.StyleController = this.layoutEdit;
            this.txtNgayHetHan.TabIndex = 35;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.simpleLabelItem1,
            this.layoutControlItem6,
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(370, 491);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNgayBatDau;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem1.Text = "Ngày bắt đầu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbDuAn;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 25);
            this.layoutControlItem2.Text = "Dự án";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMoTa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 81);
            this.layoutControlItem3.Text = "Mô tả";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTenCongViec;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem4.Text = "Tên công việc";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtNgayHetHan;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem5.Text = "Ngày hết hạn";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 178);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(350, 17);
            this.simpleLabelItem1.Text = "Phân công";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcDSNhanVien;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 195);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(350, 211);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 406);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(350, 65);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucDanhSachCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flyoutPanelEdit);
            this.Controls.Add(this.gcDanhSachCongViec);
            this.Name = "ucDanhSachCongViec";
            this.Size = new System.Drawing.Size(887, 542);
            this.Load += new System.EventHandler(this.ucDanhSachCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelEdit)).EndInit();
            this.flyoutPanelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flyoutPanelControl1)).EndInit();
            this.flyoutPanelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutEdit)).EndInit();
            this.layoutEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDanhSachCongViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDanhSachCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcNguoiGiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn gcTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn gcMoTa;
        private DevExpress.Utils.FlyoutPanel flyoutPanelEdit;
        private DevExpress.Utils.FlyoutPanelControl flyoutPanelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutEdit;
        private DevExpress.XtraGrid.GridControl gcDSNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMoTa;
        private DevExpress.XtraEditors.DateEdit txtNgayBatDau;
        private System.Windows.Forms.ComboBox cbbDuAn;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtTenCongViec;
        private DevExpress.XtraEditors.DateEdit txtNgayHetHan;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
