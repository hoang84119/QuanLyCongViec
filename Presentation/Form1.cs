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
        private static frmQuanLyCongViec _instance;

        public static frmQuanLyCongViec Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmQuanLyCongViec();
                return _instance;
            }
        }

        private NHANVIEN user;
        public NHANVIEN User { get => user; set => user = value; }
        private QLCONGVIECEntities dbQuanLyCV;
        public QLCONGVIECEntities DbQuanLyCV
        {
            get
            {
                if (dbQuanLyCV == null)
                {
                    dbQuanLyCV = new QLCONGVIECEntities();
                }
                return dbQuanLyCV;
            }
        }

        public frmQuanLyCongViec()
        {
            InitializeComponent();
        }

        

        private void acDSCV_Click(object sender, EventArgs e)
        {

        }

        private void frmQuanLyCongViec_Load(object sender, EventArgs e)
        {
            container.Controls.Add(ucDanhSachCongViec.Instance);
            ucDanhSachCongViec.Instance.Dock = DockStyle.Fill;
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
    }
}
