using DevExpress.XtraBars;
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

        public frmQuanLyCongViec()
        {
            InitializeComponent();
        }

        private void acDSCV_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucDanhSachCongViec.Instance))
            {
                container.Controls.Add(ucDanhSachCongViec.Instance);
                ucDanhSachCongViec.Instance.Dock = DockStyle.Fill;
            }
            ucDanhSachCongViec.Instance.BringToFront();
        }

        private void frmQuanLyCongViec_Load(object sender, EventArgs e)
        {
            using (var db = new QLCONGVIECEntities())
            {
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
            acThemCongViec.Visible = v;
            acThemDuAn.Visible = v;
            acCongViecDaGiao.Visible = v;
        }

        private void acNhanVien_Click(object sender, EventArgs e)
        {
            if(!container.Controls.Contains(ucNhanVien.Instance))
            {
                container.Controls.Add(ucNhanVien.Instance);
                ucNhanVien.Instance.Dock = DockStyle.Fill;
            }
            ucNhanVien.Instance.BringToFront();
        }

        private void acThemCongViec_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucThemCongViec.Instance))
            {
                container.Controls.Add(ucThemCongViec.Instance);
                ucThemCongViec.Instance.Dock = DockStyle.Right;
            }
            ucThemCongViec.Instance.BringToFront();
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
            ucThemCongViec.Instance = null;
            ucCongViecDaGiao.Instance = null;
        }

        private void frmQuanLyCongViec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
            xoaUC();
        }

        private void acCongViecDaGiao_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucCongViecDaGiao.Instance))
            {
                container.Controls.Add(ucCongViecDaGiao.Instance);
                ucCongViecDaGiao.Instance.Dock = DockStyle.Fill;
            }
            ucCongViecDaGiao.Instance.BringToFront();
        }
    }
}
