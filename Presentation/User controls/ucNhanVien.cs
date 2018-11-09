using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Presentation.User_controls
{
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucNhanVien _instance;

        public static ucNhanVien Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucNhanVien();
                return _instance;
            }
            set => _instance = value;
        }

        private ucNhanVien()
        {
            InitializeComponent();
        }

        private void ucNhanVien_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).ShowLoading();
            using (var db = new QLCONGVIECEntities())
            {
                NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;

                if (user.MaPhongBan == "GD")
                {
                    gcNhanVien.DataSource = db.NHANVIEN
                        .Where(nv => nv.MaNhanVien != user.MaNhanVien)
                        .ToList();
                }
                else
                {
                    gcNhanVien.DataSource = db.NHANVIEN
                        .Where(nv => nv.MaNhanVien != user.MaNhanVien && nv.MaPhongBan == user.MaPhongBan)
                        .ToList();
                }
            }

        }

        private void gcNhanVien_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }
    }
}
