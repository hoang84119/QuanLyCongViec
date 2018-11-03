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
    public partial class ucCongViecDaGiao : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucCongViecDaGiao _instance;

        public static ucCongViecDaGiao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCongViecDaGiao();
                return _instance;
            }
            set => _instance = value;
        }

        public ucCongViecDaGiao()
        {
            InitializeComponent();
        }

        private void ucCongViecDaGiao_Load(object sender, EventArgs e)
        {
            using (var db = new QLCONGVIECEntities())
            {
                NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
                var BangCongViec = db.CONGVIEC
                    .Where(cv => cv.NguoiGiao == user.MaNhanVien)
                    .AsEnumerable()
                    .Select(cv => new
                    {
                        cv.MaCongViec,
                        cv.TenCV,
                        cv.NgayBatDau,
                        cv.NgayHetHan,
                        cv.MoTa,
                        cv.TrangThai,
                        NguoiNhan = String.Join(", ", (cv.PHANCONG.Select(pc=>pc.NHANVIEN.HoTen).ToArray()))
                        //PhanCong = cv.PHANCONG.Select(pc => pc.NHANVIEN.HoTen)
                    }).ToList();

                gvDanhSachCongViec.DataSource = BangCongViec;
            }
        }
    }
}
