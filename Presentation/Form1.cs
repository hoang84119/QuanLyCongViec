using DevExpress.XtraBars;
using DevExpress.XtraSplashScreen;
using Presentation.User_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmQuanLyCongViec : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public NHANVIEN User { get; set; }

        private bool loadNV = false;
        private bool loadCVDaGiao = false;
        private bool loadCVDuocGiao = false;
        private bool loadPhong = false;

        IOverlaySplashScreenHandle handle = null;

        public frmQuanLyCongViec()
        {
            InitializeComponent();
        }

        private void frmQuanLyCongViec_Load(object sender, EventArgs e)
        {
            using (var db = new QLCONGVIECEntities())
            {
                User = db.NHANVIEN.Where(nv => nv.TenDangNhap == "thaian").FirstOrDefault();
                var phong = db.PHONGBAN.Where(p => p.TruongPhong == User.MaNhanVien).Select(p => p);
                if(phong.Count()==0)
                {
                    chucNangQuanLy(false);
                }
            }
        }

        private void chucNangQuanLy(bool v)
        {
            acQuanLy.Visible = v;
            acCongViecDaGiao.Visible = v;
        }

        private void acDSCV_Click(object sender, EventArgs e)
        {
            if (!loadCVDuocGiao)
            {
                ShowLoading();
                loadCVDuocGiao = true;
            }
            if (!container.Controls.Contains(ucDanhSachCongViec.Instance))
            {
                container.Controls.Add(ucDanhSachCongViec.Instance);
                ucDanhSachCongViec.Instance.Dock = DockStyle.Fill;
            }
            ucDanhSachCongViec.Instance.BringToFront();
        }

        private void acNhanVien_Click(object sender, EventArgs e)
        {
            if (!loadNV)
            {
                ShowLoading();
                loadNV = true;
            }
            if (!container.Controls.Contains(ucNhanVien.Instance))
            {
                container.Controls.Add(ucNhanVien.Instance);
                ucNhanVien.Instance.Dock = DockStyle.Fill;
            }
            ucNhanVien.Instance.BringToFront();
            CloseLoading();
        }

        private void acCongViecDaGiao_Click(object sender, EventArgs e)
        {
            if (!loadCVDaGiao)
            {
                ShowLoading();
                loadCVDaGiao = true;
            }
            if (!container.Controls.Contains(ucCongViecDaGiao.Instance))
            {
                container.Controls.Add(ucCongViecDaGiao.Instance);
                ucCongViecDaGiao.Instance.Dock = DockStyle.Fill;
            }
            ucCongViecDaGiao.Instance.BringToFront();
        }

        private void acDanhSachPhongBan_Click(object sender, EventArgs e)
        {
            if (!loadPhong)
            {
                ShowLoading();
                loadPhong = true;
            }
            if (!container.Controls.Contains(ucPhong.Instance))
            {
                container.Controls.Add(ucPhong.Instance);
                ucPhong.Instance.Dock = DockStyle.Fill;
            }
            ucPhong.Instance.BringToFront();
        }

        private void acDangXuat_Click(object sender, EventArgs e)
        {
            //xoaUC();
            this.Hide();
        }

        private void xoaUC()
        {
            ucDanhSachCongViec.Instance = null;
            ucNhanVien.Instance = null;
            ucPhong.Instance = null;
            ucCongViecDaGiao.Instance = null;
        }

        private void frmQuanLyCongViec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
            xoaUC();
        }

        public void ShowLoading()
        {
            bool useFadeIn = false;
            bool useFadeOut = false;
            Color backColor = Color.Black;
            Color foreColor = Color.Black;
            double opacity = 0.5;
            Image waitImage = Image.FromFile("../../Images/loading.png");
            OverlayWindowOptions options = new OverlayWindowOptions(
                useFadeIn,
                useFadeOut,
                backColor,
                foreColor,
                opacity,
                waitImage);
            handle = ShowProgressPanel(options);
        }

        IOverlaySplashScreenHandle ShowProgressPanel(OverlayWindowOptions option)
        {
            return SplashScreenManager.ShowOverlayForm(container, option);
        }

        public void CloseLoading()
        {
            if (handle != null)
                SplashScreenManager.CloseOverlayForm(handle);
        }

    }
}
