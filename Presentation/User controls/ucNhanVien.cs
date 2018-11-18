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
using System.IO;

namespace Presentation.User_controls
{
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucNhanVien _instance;
        private QLCONGVIECEntities db = new QLCONGVIECEntities();
        NHANVIEN nhanvien;

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

            loadDuLieuCbb();
            loadDuLieuGirdView();
        }

        private void loadDuLieuCbb()
        {
            cbbPhongBan.DataSource = db.PHONGBAN.ToList();
            cbbPhongBan.DisplayMember = "TenPhong";
            cbbPhongBan.ValueMember = "MaPhongBan";
            cbbPhongBan.SelectedIndex = -1;

        }

        private void loadDuLieuGirdView()
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            if (user.MaPhongBan == "GD")
            {

                gcNhanVien.DataSource = (db.NHANVIEN
                    .Where(nv => nv.MaNhanVien != user.MaNhanVien)
                    .ToList());
            }
            else
            {
                gcNhanVien.DataSource = db.NHANVIEN
                    .Where(nv => nv.MaNhanVien != user.MaNhanVien && nv.MaPhongBan == user.MaPhongBan)
                    .ToList();
            }
        }

        private void gcNhanVien_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }

        private void clearControls()
        {
            nhanvien = null;
            cbbPhongBan.SelectedIndex = -1;
            txtHoTen.Text = txtDiaChi.Text = txtNgaySinh.Text = txtChucVu.Text = txtTenDangNhap.Text = txtMatKhau.Text = "";
            pictureHinhDaiDien.Image = null;
        }

        private void capNhatTrangThai(bool isEdit)
        {
            layoutEdit.Visible = btnLuu.Visible = btnHuy.Visible = isEdit;
            btnThem.Visible = btnSua.Visible = !isEdit;
            if (isEdit)
            {
                if (nhanvien.MaNhanVien == 0) btnXoa.Visible = false;
            }
            else btnXoa.Visible = true;
        }

        private void loadNhanVien()
        {
            txtHoTen.Text = nhanvien.HoTen;
            txtNgaySinh.Text = nhanvien.NgaySinh.ToLongDateString();
            txtTenDangNhap.Text = nhanvien.TenDangNhap;
            txtMatKhau.Text = nhanvien.MatKhau;
            txtDiaChi.Text = nhanvien.DiaChi;
            txtChucVu.Text = nhanvien.ChucVu;
            cbbPhongBan.SelectedValue = nhanvien.MaPhongBan;
            pictureHinhDaiDien.Image = nhanvien.Hinh;
        }

        private void suaNhanVien()
        {
            int index = tvNhanVien.GetSelectedRows()[0];
            int maNV = int.Parse(tvNhanVien.GetRowCellValue(index, "MaNhanVien").ToString());

            nhanvien = db.NHANVIEN
                            .Where(nv => nv.MaNhanVien == maNV).FirstOrDefault();

            loadNhanVien();
            capNhatTrangThai(true);
        }

        private void tvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            suaNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaNhanVien();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            capNhatTrangThai(false);
            clearControls();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanvien = new NHANVIEN();
            capNhatTrangThai(true);
        }
    }
}
