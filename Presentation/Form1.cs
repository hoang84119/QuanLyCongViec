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
        //private static frmQuanLyCongViec _instance;

        //public static frmQuanLyCongViec Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new frmQuanLyCongViec();
        //        return _instance;
        //    }
        //}

        private NHANVIEN user;
        public NHANVIEN User { get => user; set => user = value; }

        //private QLCONGVIECEntities dbQuanLyCV;
        //public QLCONGVIECEntities DbQuanLyCV
        //{
        //    get
        //    {
        //        if (dbQuanLyCV == null)
        //        {
        //            dbQuanLyCV = new QLCONGVIECEntities();
        //        }
        //        return dbQuanLyCV;
        //    }
        //}

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
            //container.Controls.Add(ucDanhSachCongViec.Instance);
            //ucDanhSachCongViec.Instance.Dock = DockStyle.Fill;
            
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
        }

        private void frmQuanLyCongViec_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) Application.Exit();
            xoaUC();
        }
    }
}
