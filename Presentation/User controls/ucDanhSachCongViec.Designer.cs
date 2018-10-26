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
            this.gcNgayGiao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
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
            // 
            // gcDanhSachCongViec
            // 
            this.gcDanhSachCongViec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaCV,
            this.gcTenCV,
            this.gcNguoiGiao,
            this.gcNgayGiao,
            this.gcNgayHetHan,
            this.gcTrangThai});
            this.gcDanhSachCongViec.GridControl = this.gvDanhSachCongViec;
            this.gcDanhSachCongViec.GroupPanelText = "Kéo tiêu đề của một cột vào đây để nhóm theo cột đó";
            this.gcDanhSachCongViec.Name = "gcDanhSachCongViec";
            // 
            // gcMaCV
            // 
            this.gcMaCV.Caption = "Mã CV";
            this.gcMaCV.FieldName = "MaCongViec";
            this.gcMaCV.Name = "gcMaCV";
            this.gcMaCV.Visible = true;
            this.gcMaCV.VisibleIndex = 0;
            // 
            // gcTenCV
            // 
            this.gcTenCV.Caption = "Tên công việc";
            this.gcTenCV.FieldName = "TenCV";
            this.gcTenCV.Name = "gcTenCV";
            this.gcTenCV.Visible = true;
            this.gcTenCV.VisibleIndex = 1;
            // 
            // gcNguoiGiao
            // 
            this.gcNguoiGiao.Caption = "Người giao";
            this.gcNguoiGiao.FieldName = "HoTen";
            this.gcNguoiGiao.Name = "gcNguoiGiao";
            this.gcNguoiGiao.Visible = true;
            this.gcNguoiGiao.VisibleIndex = 2;
            // 
            // gcNgayGiao
            // 
            this.gcNgayGiao.Caption = "Ngày giao";
            this.gcNgayGiao.FieldName = "NgayGiao";
            this.gcNgayGiao.Name = "gcNgayGiao";
            this.gcNgayGiao.Visible = true;
            this.gcNgayGiao.VisibleIndex = 3;
            // 
            // gcNgayHetHan
            // 
            this.gcNgayHetHan.Caption = "Ngày hết hạn";
            this.gcNgayHetHan.FieldName = "NgayHetHan";
            this.gcNgayHetHan.Name = "gcNgayHetHan";
            this.gcNgayHetHan.Visible = true;
            this.gcNgayHetHan.VisibleIndex = 4;
            // 
            // gcTrangThai
            // 
            this.gcTrangThai.Caption = "Trạng thái";
            this.gcTrangThai.FieldName = "TrangThai";
            this.gcTrangThai.Name = "gcTrangThai";
            this.gcTrangThai.Visible = true;
            this.gcTrangThai.VisibleIndex = 5;
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
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayGiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn gcTrangThai;
    }
}
