﻿using System;
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
    public partial class ucNhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucNhanVien _instance;
        private QLCONGVIECEntities db;
        private bool isPictureModified = false;
        private string path = "../../Images/";
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
            //((frmQuanLyCongViec)this.ParentForm).ShowLoading();
            loadDuLieuGirdView();
            loadDuLieuCbb();
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
            db = new QLCONGVIECEntities();
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

        private void loadNhanVien()
        {
            txtHoTen.Text = nhanvien.HoTen;
            txtNgaySinh.Text = nhanvien.NgaySinh.ToLongDateString();
            txtTenDangNhap.Text = nhanvien.TenDangNhap;
            txtMatKhau.Text = nhanvien.MatKhau;
            txtDiaChi.Text = nhanvien.DiaChi;
            txtChucVu.Text = nhanvien.ChucVu;
            cbbPhongBan.SelectedIndex = cbbPhongBan.Items.IndexOf(nhanvien.PHONGBAN);
            pictureHinhDaiDien.Image = nhanvien.Hinh;
        }

        private void suaNhanVien()
        {
            nhanvien = (NHANVIEN)tvNhanVien.GetFocusedRow();
            flyoutPanelEdit.ShowPopup();
            loadNhanVien();
        }

        private void tvNhanVien_DoubleClick(object sender, EventArgs e)
        {
            suaNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            nhanvien = new NHANVIEN();
            flyoutPanelEdit.ShowPopup();
        }

        private void flyoutPanelEdit_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            string tag = e.Button.Tag.ToString();
            switch (tag)
            {
                case "Save": luuNhanVien(); break;
                case "Cancel": flyoutPanelEdit.HidePopup(); clearControls(); break;
            }
        }

        private void luuNhanVien()
        {
            if (txtHoTen.Text == "")
            {
                XtraMessageBox.Show("Họ tên không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
            }
            else if (txtNgaySinh.Text == "")
            {
                XtraMessageBox.Show("Ngày sinh không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgaySinh.ShowPopup();
            }
            else if (txtChucVu.Text == "")
            {
                XtraMessageBox.Show("Chức vụ không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtChucVu.Focus();
            }
            else if (cbbPhongBan.SelectedIndex == -1)
            {
                XtraMessageBox.Show("Vui lòng chọn phòng ban", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbPhongBan.Focus();
            }
            else if (txtDiaChi.Text == "")
            {
                XtraMessageBox.Show("Địa chỉ không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
            }
            else if (txtTenDangNhap.Text == "")
            {
                XtraMessageBox.Show("Tên đăng nhập không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                XtraMessageBox.Show("Mật khẩu không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
            }
            else
            {
                nhanvien.HoTen = txtHoTen.Text;
                nhanvien.NgaySinh = DateTime.Parse(txtNgaySinh.Text);
                nhanvien.TenDangNhap = txtTenDangNhap.Text;
                nhanvien.MatKhau = txtMatKhau.Text;
                nhanvien.DiaChi = txtDiaChi.Text;
                nhanvien.ChucVu = txtChucVu.Text;
                if (isPictureModified)
                {
                    if (pictureHinhDaiDien.Image != null)
                    {
                        string tenHinh = Path.GetFileName(pictureHinhDaiDien.GetLoadedImageLocation());
                        if (tenHinh == "")
                        {
                            tenHinh = convertToUnSign3(nhanvien.HoTen) + ".png";
                        }
                        if (!File.Exists(path + tenHinh)) pictureHinhDaiDien.Image.Save(path + tenHinh);
                        nhanvien.HinhDaiDien = tenHinh;
                    }
                }
                nhanvien.MaPhongBan = cbbPhongBan.SelectedValue.ToString();

                if (nhanvien.MaNhanVien == 0)
                    db.NHANVIEN.Add(nhanvien);
                else
                    db.Entry(nhanvien).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();


                clearControls();
                flyoutPanelEdit.HidePopup();
                loadDuLieuGirdView();
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void pictureHinhDaiDien_Modified(object sender, EventArgs e)
        {
            isPictureModified = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (nhanvien == null)
            {
                nhanvien = (NHANVIEN)tvNhanVien.GetFocusedRow();
            }
            if (nhanvien.PHANCONG.Where(pc => pc.TrangThai == false).Count() != 0)
            {
                XtraMessageBox.Show("Không thể xóa nhân viên đang có công việc chưa hoàn thành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhanvien.PHONGBAN1.Count != 0)
            {
                XtraMessageBox.Show("Không thể xóa trưởng phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (nhanvien.CONGVIEC.Count != 0)
            {
                //if (XtraMessageBox.Show("Công việc được giao bởi nhân viên này sẽ được xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                //{
                //    foreach(CONGVIEC cv in nhanvien.CONGVIEC.ToList())
                //    {
                //        db.CONGVIEC.Remove(cv);
                //    }
                //    xoaNhanVien();
                //}
                XtraMessageBox.Show("Không thể xóa nhân viên đã giao công việc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                xoaNhanVien();
            }
        }

        private void xoaNhanVien()
        {
            foreach (PHANCONG pc in nhanvien.PHANCONG.ToList())
            {
                db.PHANCONG.Remove(pc);
            }
            var entry = db.Entry(nhanvien);
            if (entry.State == System.Data.Entity.EntityState.Detached)
                db.NHANVIEN.Attach(nhanvien);
            db.NHANVIEN.Remove(nhanvien);
            db.SaveChanges();
            loadDuLieuGirdView();
            XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
}
