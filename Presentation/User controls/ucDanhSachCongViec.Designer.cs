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
            this.gvDanhSachCongViec = new DevExpress.XtraGrid.GridControl();
            this.gcDanhSachCongViec = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNguoiGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCongViec)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachCongViec
            // 
            this.gvDanhSachCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachCongViec.Location = new System.Drawing.Point(0, 0);
            this.gvDanhSachCongViec.MainView = this.gcDanhSachCongViec;
            this.gvDanhSachCongViec.Name = "gvDanhSachCongViec";
            this.gvDanhSachCongViec.Size = new System.Drawing.Size(887, 385);
            this.gvDanhSachCongViec.TabIndex = 0;
            this.gvDanhSachCongViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcDanhSachCongViec});
            this.gvDanhSachCongViec.Load += new System.EventHandler(this.gvDanhSachCongViec_Load);
            // 
            // gcDanhSachCongViec
            // 
            this.gcDanhSachCongViec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaCV,
            this.gcTenCV,
            this.gcNguoiGiao,
            this.gcNgayBatDau,
            this.gcNgayHetHan,
            this.gcMoTa,
            this.gcTrangThai});
            this.gcDanhSachCongViec.GridControl = this.gvDanhSachCongViec;
            this.gcDanhSachCongViec.GroupPanelText = "Kéo tiêu đề của một cột vào đây để nhóm theo cột đó";
            this.gcDanhSachCongViec.Name = "gcDanhSachCongViec";
            this.gcDanhSachCongViec.OptionsView.ShowIndicator = false;
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
            // ucDanhSachCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDanhSachCongViec);
            this.Name = "ucDanhSachCongViec";
            this.Size = new System.Drawing.Size(887, 385);
            this.Load += new System.EventHandler(this.ucDanhSachCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachCongViec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gvDanhSachCongViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gcDanhSachCongViec;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcNguoiGiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn gcTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn gcMoTa;
    }
}
