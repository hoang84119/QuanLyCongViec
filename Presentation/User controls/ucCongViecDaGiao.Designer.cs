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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.gvDanhSachCongViec = new DevExpress.XtraGrid.GridControl();
            this.gcCongViecDaGiao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenCV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayBatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayHetHan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttonPanelEditor = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongViec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecDaGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDanhSachCongViec
            // 
            this.gvDanhSachCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvDanhSachCongViec.Location = new System.Drawing.Point(0, 0);
            this.gvDanhSachCongViec.MainView = this.gcCongViecDaGiao;
            this.gvDanhSachCongViec.Name = "gvDanhSachCongViec";
            this.gvDanhSachCongViec.Size = new System.Drawing.Size(700, 465);
            this.gvDanhSachCongViec.TabIndex = 3;
            this.gvDanhSachCongViec.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcCongViecDaGiao});
            this.gvDanhSachCongViec.Load += new System.EventHandler(this.gvDanhSachCongViec_Load);
            // 
            // gcCongViecDaGiao
            // 
            this.gcCongViecDaGiao.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcCongViecDaGiao.Appearance.HeaderPanel.Options.UseFont = true;
            this.gcCongViecDaGiao.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcCongViecDaGiao.Appearance.Row.Options.UseFont = true;
            this.gcCongViecDaGiao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaCV,
            this.gcTenCV,
            this.gcNguoiNhan,
            this.gcNgayBatDau,
            this.gcNgayHetHan,
            this.gcMoTa,
            this.gcTrangThai});
            this.gcCongViecDaGiao.GridControl = this.gvDanhSachCongViec;
            this.gcCongViecDaGiao.GroupPanelText = "Kéo tiêu đề của một cột vào đây để nhóm theo cột đó";
            this.gcCongViecDaGiao.Name = "gcCongViecDaGiao";
            this.gcCongViecDaGiao.OptionsView.ShowIndicator = false;
            this.gcCongViecDaGiao.RowHeight = 50;
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
            // buttonPanelEditor
            // 
            this.buttonPanelEditor.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Sửa", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, false, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.buttonPanelEditor.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonPanelEditor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanelEditor.Location = new System.Drawing.Point(0, 465);
            this.buttonPanelEditor.Name = "buttonPanelEditor";
            this.buttonPanelEditor.Size = new System.Drawing.Size(700, 69);
            this.buttonPanelEditor.TabIndex = 2;
            this.buttonPanelEditor.Text = "buttonPanelEditor";
            this.buttonPanelEditor.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.buttonPanelEditor_ButtonClick);
            // 
            // ucCongViecDaGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvDanhSachCongViec);
            this.Controls.Add(this.buttonPanelEditor);
            this.Name = "ucCongViecDaGiao";
            this.Size = new System.Drawing.Size(700, 534);
            this.Load += new System.EventHandler(this.ucCongViecDaGiao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDanhSachCongViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecDaGiao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gvDanhSachCongViec;
        private DevExpress.XtraGrid.Views.Grid.GridView gcCongViecDaGiao;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenCV;
        private DevExpress.XtraGrid.Columns.GridColumn gcNguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayHetHan;
        private DevExpress.XtraGrid.Columns.GridColumn gcMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn gcTrangThai;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel buttonPanelEditor;
    }
}
