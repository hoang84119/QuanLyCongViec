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
            this.gcDanhSachCongViec.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDanhSachCongViec.Appearance.HeaderPanel.Options.UseFont = true;
            this.gcDanhSachCongViec.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcDanhSachCongViec.Appearance.Row.Options.UseFont = true;
            this.gcDanhSachCongViec.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaCV,
            this.gcTenCV,
            this.gcNguoiGiao,
            this.gcNgayBatDau,
            this.gcNgayHetHan,
            this.gcTrangThai});
            this.gcDanhSachCongViec.GridControl = this.gvDanhSachCongViec;
            this.gcDanhSachCongViec.GroupPanelText = "Kéo tiêu đề của một cột vào đây để nhóm theo cột đó";
            this.gcDanhSachCongViec.Name = "gcDanhSachCongViec";
            this.gcDanhSachCongViec.RowHeight = 50;
            // 
            // gcMaCV
            // 
            this.gcMaCV.Caption = "Mã CV";
            this.gcMaCV.FieldName = "MaCongViec";
            this.gcMaCV.Name = "gcMaCV";
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
            // gcNguoiGiao
            // 
            this.gcNguoiGiao.Caption = "Người giao";
            this.gcNguoiGiao.FieldName = "HoTen";
            this.gcNguoiGiao.Name = "gcNguoiGiao";
            this.gcNguoiGiao.Visible = true;
            this.gcNguoiGiao.VisibleIndex = 2;
            this.gcNguoiGiao.Width = 87;
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
            // gcTrangThai
            // 
            this.gcTrangThai.Caption = "Trạng thái";
            this.gcTrangThai.FieldName = "TrangThai";
            this.gcTrangThai.Name = "gcTrangThai";
            this.gcTrangThai.Visible = true;
            this.gcTrangThai.VisibleIndex = 5;
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
    }
}
