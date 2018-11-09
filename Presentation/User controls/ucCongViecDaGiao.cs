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
            ((frmQuanLyCongViec)this.ParentForm).ShowLoading();
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

        private void gvDanhSachCongViec_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }

        private void buttonPanelEditor_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button == buttonPanelEditor.Buttons[0])
            {
                suaCongViec();
            }
        }

        private void suaCongViec()
        {
            int index = gcCongViecDaGiao.GetSelectedRows()[0];
            int maCV = int.Parse(gcCongViecDaGiao.GetRowCellValue(index,"MaCongViec").ToString());

            using (var db = new QLCONGVIECEntities())
            {
                CONGVIEC congViec = db.CONGVIEC
                    .Where(cv => cv.MaCongViec == maCV).ToList()[0];
                ucCapNhatCV.Instance.CongViec = congViec;
                if (!this.Parent.Controls.Contains(ucCapNhatCV.Instance))
                {
                    this.Parent.Controls.Add(ucCapNhatCV.Instance);
                    ucCapNhatCV.Instance.Dock = DockStyle.Right;
                }
                ucCapNhatCV.Instance.BringToFront();
            }
        }
    }
}
