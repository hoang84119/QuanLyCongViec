namespace Presentation.User_controls
{
    partial class ucCongViecDaGiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCongViecDaGiao));
            this.gcCongViecDaGiao = new DevExpress.XtraGrid.GridControl();
            this.gvCongViecDaGiao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutEdit = new DevExpress.XtraLayout.LayoutControl();
            this.gcDSNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gvDSNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTenEditor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
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
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemNV = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecDaGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecDaGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEdit)).BeginInit();
            this.layoutEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCongViecDaGiao
            // 
            this.gcCongViecDaGiao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCongViecDaGiao.Location = new System.Drawing.Point(0, 271);
            this.gcCongViecDaGiao.MainView = this.gvCongViecDaGiao;
            this.gcCongViecDaGiao.Name = "gcCongViecDaGiao";
            this.gcCongViecDaGiao.Size = new System.Drawing.Size(837, 309);
            this.gcCongViecDaGiao.TabIndex = 3;
            this.gcCongViecDaGiao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCongViecDaGiao});
            this.gcCongViecDaGiao.Load += new System.EventHandler(this.gvDanhSachCongViec_Load);
            // 
            // gvCongViecDaGiao
            // 
            this.gvCongViecDaGiao.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCongViecDaGiao.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvCongViecDaGiao.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvCongViecDaGiao.Appearance.Row.Options.UseFont = true;
            this.gvCongViecDaGiao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaCV,
            this.gcTenCV,
            this.gcNguoiNhan,
            this.gcNgayBatDau,
            this.gcNgayHetHan,
            this.gcMoTa,
            this.gcTrangThai});
            this.gvCongViecDaGiao.GridControl = this.gcCongViecDaGiao;
            this.gvCongViecDaGiao.GroupPanelText = "Kéo tiêu đề của một cột vào đây để nhóm theo cột đó";
            this.gvCongViecDaGiao.Name = "gvCongViecDaGiao";
            this.gvCongViecDaGiao.OptionsView.ShowIndicator = false;
            this.gvCongViecDaGiao.RowHeight = 50;
            // 
            // gcMaCV
            // 
            this.gcMaCV.Caption = "Mã CV";
            this.gcMaCV.FieldName = "MaCongViec";
            this.gcMaCV.Name = "gcMaCV";
            this.gcMaCV.OptionsColumn.AllowEdit = false;
            this.gcMaCV.Visible = true;
            this.gcMaCV.VisibleIndex = 0;
            this.gcMaCV.Width = 45;
            // 
            // gcTenCV
            // 
            this.gcTenCV.Caption = "Tên công việc";
            this.gcTenCV.FieldName = "TenCV";
            this.gcTenCV.Name = "gcTenCV";
            this.gcTenCV.Visible = true;
            this.gcTenCV.VisibleIndex = 1;
            this.gcTenCV.Width = 87;
            // 
            // gcNguoiNhan
            // 
            this.gcNguoiNhan.Caption = "Người nhận";
            this.gcNguoiNhan.FieldName = "NguoiNhan";
            this.gcNguoiNhan.Name = "gcNguoiNhan";
            this.gcNguoiNhan.Visible = true;
            this.gcNguoiNhan.VisibleIndex = 2;
            this.gcNguoiNhan.Width = 87;
            // 
            // gcNgayBatDau
            // 
            this.gcNgayBatDau.Caption = "Ngày bắt đầu";
            this.gcNgayBatDau.FieldName = "NgayBatDau";
            this.gcNgayBatDau.Name = "gcNgayBatDau";
            this.gcNgayBatDau.Visible = true;
            this.gcNgayBatDau.VisibleIndex = 3;
            this.gcNgayBatDau.Width = 87;
            // 
            // gcNgayHetHan
            // 
            this.gcNgayHetHan.Caption = "Ngày hết hạn";
            this.gcNgayHetHan.FieldName = "NgayHetHan";
            this.gcNgayHetHan.Name = "gcNgayHetHan";
            this.gcNgayHetHan.Visible = true;
            this.gcNgayHetHan.VisibleIndex = 4;
            this.gcNgayHetHan.Width = 87;
            // 
            // gcMoTa
            // 
            this.gcMoTa.Caption = "Mô tả";
            this.gcMoTa.FieldName = "MoTa";
            this.gcMoTa.Name = "gcMoTa";
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
            // layoutEdit
            // 
            this.layoutEdit.Controls.Add(this.btnThemNV);
            this.layoutEdit.Controls.Add(this.gcDSNhanVien);
            this.layoutEdit.Controls.Add(this.txtNgayBatDau);
            this.layoutEdit.Controls.Add(this.cbbDuAn);
            this.layoutEdit.Controls.Add(this.txtMoTa);
            this.layoutEdit.Controls.Add(this.txtTenCongViec);
            this.layoutEdit.Controls.Add(this.txtNgayHetHan);
            this.layoutEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutEdit.Location = new System.Drawing.Point(0, 0);
            this.layoutEdit.Name = "layoutEdit";
            this.layoutEdit.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 0, 650, 400);
            this.layoutEdit.Root = this.layoutControlGroup1;
            this.layoutEdit.Size = new System.Drawing.Size(837, 218);
            this.layoutEdit.TabIndex = 0;
            this.layoutEdit.Text = "layoutControl1";
            this.layoutEdit.Visible = false;
            // 
            // gcDSNhanVien
            // 
            this.gcDSNhanVien.Location = new System.Drawing.Point(421, 29);
            this.gcDSNhanVien.MainView = this.gvDSNhanVien;
            this.gcDSNhanVien.Name = "gcDSNhanVien";
            this.gcDSNhanVien.Size = new System.Drawing.Size(404, 137);
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
            this.gridColumnTenNV.ColumnEdit = this.HoTenEditor;
            this.gridColumnTenNV.FieldName = "NguoiNhan";
            this.gridColumnTenNV.Name = "gridColumnTenNV";
            this.gridColumnTenNV.Visible = true;
            this.gridColumnTenNV.VisibleIndex = 0;
            // 
            // HoTenEditor
            // 
            this.HoTenEditor.AutoHeight = false;
            this.HoTenEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.HoTenEditor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HoTen", "Họ tên", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.HoTenEditor.DisplayMember = "HoTen";
            this.HoTenEditor.Name = "HoTenEditor";
            this.HoTenEditor.NullText = "Chọn nhân viên";
            this.HoTenEditor.ValueMember = "MaNhanVien";
            // 
            // gridColumnMoTa
            // 
            this.gridColumnMoTa.Caption = "Mô tả";
            this.gridColumnMoTa.FieldName = "MoTa";
            this.gridColumnMoTa.Name = "gridColumnMoTa";
            this.gridColumnMoTa.Visible = true;
            this.gridColumnMoTa.VisibleIndex = 1;
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.EditValue = null;
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
            this.txtNgayBatDau.Properties.EditValueChanged += new System.EventHandler(this.txtNgayBatDau_Properties_EditValueChanged);
            this.txtNgayBatDau.Size = new System.Drawing.Size(336, 20);
            this.txtNgayBatDau.StyleController = this.layoutEdit;
            this.txtNgayBatDau.TabIndex = 38;
            // 
            // cbbDuAn
            // 
            this.cbbDuAn.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbDuAn.FormattingEnabled = true;
            this.cbbDuAn.Location = new System.Drawing.Point(81, 84);
            this.cbbDuAn.Name = "cbbDuAn";
            this.cbbDuAn.Size = new System.Drawing.Size(336, 22);
            this.cbbDuAn.TabIndex = 37;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.txtMoTa.Location = new System.Drawing.Point(81, 109);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(336, 97);
            this.txtMoTa.TabIndex = 36;
            // 
            // txtTenCongViec
            // 
            this.txtTenCongViec.Location = new System.Drawing.Point(81, 12);
            this.txtTenCongViec.Name = "txtTenCongViec";
            this.txtTenCongViec.Size = new System.Drawing.Size(336, 20);
            this.txtTenCongViec.StyleController = this.layoutEdit;
            this.txtTenCongViec.TabIndex = 34;
            // 
            // txtNgayHetHan
            // 
            this.txtNgayHetHan.EditValue = null;
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
            this.txtNgayHetHan.Size = new System.Drawing.Size(336, 20);
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
            this.layoutControlItem6,
            this.simpleLabelItem1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem7});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(837, 218);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNgayBatDau;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItem1.Text = "Ngày bắt đầu";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbDuAn;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(409, 25);
            this.layoutControlItem2.Text = "Dự án";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtMoTa;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 97);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(409, 101);
            this.layoutControlItem3.Text = "Mô tả";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.gcDSNhanVien;
            this.layoutControlItem6.Location = new System.Drawing.Point(409, 17);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(408, 141);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(409, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(408, 17);
            this.simpleLabelItem1.Text = "Phân công";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtTenCongViec;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItem4.Text = "Tên công việc";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtNgayHetHan;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(409, 24);
            this.layoutControlItem5.Text = "Ngày hết hạn";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(66, 13);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(105, 9);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(72, 34);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(192, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(72, 34);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(17, 9);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 34);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(105, 9);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(72, 34);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(17, 9);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(72, 34);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThemNV
            // 
            this.btnThemNV.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnThemNV.Location = new System.Drawing.Point(421, 170);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(118, 36);
            this.btnThemNV.StyleController = this.layoutEdit;
            this.btnThemNV.TabIndex = 40;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btnThemNV;
            this.layoutControlItem7.Location = new System.Drawing.Point(409, 158);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(122, 40);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(122, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(122, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(531, 158);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(286, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ucCongViecDaGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCongViecDaGiao);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.layoutEdit);
            this.Name = "ucCongViecDaGiao";
            this.Size = new System.Drawing.Size(837, 580);
            this.Load += new System.EventHandler(this.ucCongViecDaGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecDaGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecDaGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutEdit)).EndInit();
            this.layoutEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoTenEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayBatDau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenCongViec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNgayHetHan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCongViecDaGiao;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCongViecDaGiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcNguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn gcMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn gcTrangThai;
        private DevExpress.XtraLayout.LayoutControl layoutEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit txtNgayBatDau;
        private System.Windows.Forms.ComboBox cbbDuAn;
        private System.Windows.Forms.TextBox txtMoTa;
        private DevExpress.XtraEditors.TextEdit txtTenCongViec;
        private DevExpress.XtraEditors.DateEdit txtNgayHetHan;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl gcDSNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDSNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTenNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit HoTenEditor;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMoTa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThemNV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
