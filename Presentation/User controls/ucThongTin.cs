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
using System.Text.RegularExpressions;

namespace Presentation.User_controls
{
    public partial class ucThongTin : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucThongTin _instance;
        private QLCONGVIECEntities db = new QLCONGVIECEntities();
        NHANVIEN user;
        private bool isPictureModified = false;
        private string path = "../../Images/";

        public static ucThongTin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucThongTin();
                return _instance;
            }
            set => _instance = value;
        }
        public ucThongTin()
        {
            InitializeComponent();
        }

        private void ucThongTin_Load(object sender, EventArgs e)
        {
            NHANVIEN u = ((frmQuanLyCongViec)this.ParentForm).User;
            user = db.NHANVIEN.Where(nv => nv.MaNhanVien == u.MaNhanVien).First();
            loadThongTin();
        }

        private void loadThongTin()
        {
            txtHoTen.Text = user.HoTen;
            txtNgaySinh.Text = user.NgaySinh.ToLongDateString();
            txtTenDangNhap.Text = user.TenDangNhap;
            txtMatKhau.Text = user.MatKhau;
            txtDiaChi.Text = user.DiaChi;
            txtChucVu.Text = user.ChucVu;
            txtPhongBan.Text = user.PHONGBAN.TenPhong;
            pictureHinhDaiDien.Image = user.Hinh;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Họ tên không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
            }
            else if (txtNgaySinh.Text == "")
            {
                MessageBox.Show("Ngày sinh không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgaySinh.ShowPopup();
            }
            else if (txtChucVu.Text == "")
            {
                MessageBox.Show("Chức vụ không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVu.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
            }
            else if (txtTenDangNhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else
            {
                user.HoTen = txtHoTen.Text;
                user.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                user.TenDangNhap = txtTenDangNhap.Text;
                user.MatKhau = txtMatKhau.Text;
                user.DiaChi = txtDiaChi.Text;
                user.ChucVu = txtChucVu.Text;
                if (isPictureModified)
                {
                    if (pictureHinhDaiDien.Image != null)
                    {
                        string tenHinh = Path.GetFileName(pictureHinhDaiDien.GetLoadedImageLocation());
                        if (tenHinh == "")
                        {
                            tenHinh = convertToUnSign3(user.HoTen) + ".png";
                        }
                        if (!File.Exists(path + tenHinh)) pictureHinhDaiDien.Image.Save(path + tenHinh);
                        user.HinhDaiDien = tenHinh;
                    }
                }
                
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                loadThongTin();
            }
        }

        private string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        private void pictureHinhDaiDien_Modified(object sender, EventArgs e)
        {
            isPictureModified = true;
        }
    }
}
