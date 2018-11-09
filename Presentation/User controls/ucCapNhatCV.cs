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
    public partial class ucCapNhatCV : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucCapNhatCV _instance;
        private CONGVIEC congViec;
        DataTable bangPhanCong;

        public static ucCapNhatCV Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucCapNhatCV();
                return _instance;
            }
            set => _instance = value;
        }

        public CONGVIEC CongViec { get => congViec; set => congViec = value; }

        public ucCapNhatCV()
        {
            InitializeComponent();
        }

        private void txtNgayBatDau_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ucCapNhatCV_Load(object sender, EventArgs e)
        {
            bangPhanCong = new DataTable("BangPhanCong");
            bangPhanCong.Columns.Add("HoTen", typeof(string));
            bangPhanCong.Columns.Add("MoTa", typeof(string));
            gridControl1.DataSource = bangPhanCong;

            loadNhanVienBangPhanCong();
            loadCongViec();
            
        }

        private void loadNhanVienBangPhanCong()
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            using (var db = new QLCONGVIECEntities())
            {
                if (user.MaPhongBan == "GD")
                {
                    this.HoTenEditor.DataSource = db.NHANVIEN
                                        .Where(nv => nv.MaNhanVien != user.MaNhanVien)
                                        .Select(nv => new { nv.MaNhanVien, nv.HoTen }).ToList();
                }
                else
                {
                    this.HoTenEditor.DataSource = db.NHANVIEN
                                        .Where(nv => nv.MaNhanVien != user.MaNhanVien && nv.MaPhongBan == user.MaPhongBan)
                                        .Select(nv => new { nv.MaNhanVien, nv.HoTen }).ToList();
                }
            }
        }

        private void loadCongViec()
        {
            
            txtTenCongViec.Text = congViec.TenCV;
            txtNgayBatDau.Properties.MinValue = congViec.NgayBatDau;
            txtNgayBatDau.Text = congViec.NgayBatDau.ToLongDateString();
            txtNgayHetHan.Text = congViec.NgayHetHan.ToLongDateString();
            txtMoTa.Text = congViec.MoTa;
            var test = congViec.PHANCONG
                .Select(pc => new
                {
                    //pc.NHANVIEN.HoTen,
                    pc.NHANVIEN.MaNhanVien,
                    pc.MoTa
                });
                //.ToList();
            gridControl1.DataSource = new BindingSource(test,"");
            
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            gvDSNhanVien.AddNewRow();
        }
    }
}
