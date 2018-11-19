namespace Presentation
{
    partial class frmQuanLyCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyCongViec));
            this.container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.acCongViec = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acCongViecDaGiao = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acDSCV = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acThongKe = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acQuanLy = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acNhanVien = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acDanhSachPhongBan = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement12 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.acDangXuat = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(287, 30);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(675, 570);
            this.container.TabIndex = 0;
            // 
            // accordionControl1
            // 
            this.accordionControl1.AllowItemSelection = true;
            this.accordionControl1.Appearance.Item.Disabled.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Disabled.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Hovered.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Normal.Options.UseFont = true;
            this.accordionControl1.Appearance.Item.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accordionControl1.Appearance.Item.Pressed.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acCongViec,
            this.acQuanLy,
            this.accordionControlElement11});
            this.accordionControl1.Location = new System.Drawing.Point(0, 30);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.OptionsMinimizing.NormalWidth = 287;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.accordionControl1.Size = new System.Drawing.Size(287, 570);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // acCongViec
            // 
            this.acCongViec.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acCongViecDaGiao,
            this.acDSCV,
            this.acThongKe});
            this.acCongViec.Expanded = true;
            this.acCongViec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acCongViec.ImageOptions.Image")));
            this.acCongViec.Name = "acCongViec";
            this.acCongViec.Text = "Công việc";
            // 
            // acCongViecDaGiao
            // 
            this.acCongViecDaGiao.Name = "acCongViecDaGiao";
            this.acCongViecDaGiao.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acCongViecDaGiao.Text = "Công việc đã giao";
            this.acCongViecDaGiao.Click += new System.EventHandler(this.acCongViecDaGiao_Click);
            // 
            // acDSCV
            // 
            this.acDSCV.Name = "acDSCV";
            this.acDSCV.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDSCV.Text = "Công việc được giao";
            this.acDSCV.Click += new System.EventHandler(this.acDSCV_Click);
            // 
            // acThongKe
            // 
            this.acThongKe.Name = "acThongKe";
            this.acThongKe.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acThongKe.Text = "Thống kê";
            // 
            // acQuanLy
            // 
            this.acQuanLy.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.acNhanVien,
            this.acDanhSachPhongBan});
            this.acQuanLy.Expanded = true;
            this.acQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("acQuanLy.ImageOptions.Image")));
            this.acQuanLy.Name = "acQuanLy";
            this.acQuanLy.Text = "Quản lý";
            // 
            // acNhanVien
            // 
            this.acNhanVien.Name = "acNhanVien";
            this.acNhanVien.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acNhanVien.Text = "Nhân viên";
            this.acNhanVien.Click += new System.EventHandler(this.acNhanVien_Click);
            // 
            // acDanhSachPhongBan
            // 
            this.acDanhSachPhongBan.Name = "acDanhSachPhongBan";
            this.acDanhSachPhongBan.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDanhSachPhongBan.Text = "Danh sách phòng ban";
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement12,
            this.acDangXuat});
            this.accordionControlElement11.Expanded = true;
            this.accordionControlElement11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement11.ImageOptions.Image")));
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Text = "Tài khoản";
            // 
            // accordionControlElement12
            // 
            this.accordionControlElement12.Name = "accordionControlElement12";
            this.accordionControlElement12.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement12.Text = "Thông tin";
            // 
            // acDangXuat
            // 
            this.acDangXuat.Name = "acDangXuat";
            this.acDangXuat.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.acDangXuat.Text = "Đăng xuất";
            this.acDangXuat.Click += new System.EventHandler(this.acDangXuat_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Margin = new System.Windows.Forms.Padding(2);
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(962, 30);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // frmQuanLyCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 600);
            this.ControlContainer = this.container;
            this.Controls.Add(this.container);
            this.Controls.Add(this.accordionControl1);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "frmQuanLyCongViec";
            this.NavigationControl = this.accordionControl1;
            this.Text = "Quản lý công việc";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyCongViec_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLyCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acCongViec;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acQuanLy;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acCongViecDaGiao;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDSCV;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acNhanVien;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDanhSachPhongBan;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acThongKe;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement12;
        private DevExpress.XtraBars.Navigation.AccordionControlElement acDangXuat;
    }
}

