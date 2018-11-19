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
            flyoutPanelEdit.ShowPopup();
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
            else if (cbbPhongBan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng ban", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbbPhongBan.Focus();
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
                        pictureHinhDaiDien.Image.Save(path + nhanvien.MaNhanVien.ToString() + ".png");
                    }
                }
                nhanvien.MaPhongBan = cbbPhongBan.SelectedValue.ToString();

                //congviec.PHANCONG.Clear();
                //if (congviec.PHANCONG.Count == 0)
                //{
                //    foreach (PHANCONG pc in dsPhanCong)
                //    {
                //        congviec.PHANCONG.Add(pc);
                //    }
                //}
                //else
                //{
                //    int i = 0;
                //    foreach (PHANCONG pc in congviec.PHANCONG)
                //    {
                //        pc.NguoiNhan = dsPhanCong.ElementAt(i).NguoiNhan;
                //        pc.MoTa = dsPhanCong.ElementAt(i).MoTa;
                //        pc.NHANVIEN = db.NHANVIEN.Where(nv => nv.MaNhanVien == pc.NguoiNhan).FirstOrDefault();
                //        i++;
                //    }
                //    if (i < dsPhanCong.Count)
                //    {
                //        for (; i < dsPhanCong.Count; i++)
                //        {
                //            PHANCONG p = dsPhanCong.ElementAt(i);
                //            p.MaCongViec = congviec.MaCongViec;
                //            db.PHANCONG.Add(p);
                //            //congviec.PHANCONG.Add(p);
                //        }
                //    }
                //}
                //if (congviec.MaCongViec == 0)
                //    db.CONGVIEC.Add(congviec);
                //else
                //    db.Entry(congviec).State = System.Data.Entity.EntityState.Modified;
                //db.SaveChanges();

                clearControls();
                //loadDuLieuGirdView();
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
                flyoutPanelEdit.HidePopup();
            }
        }

        private void pictureHinhDaiDien_Modified(object sender, EventArgs e)
        {
            isPictureModified = true;
        }
    }
}
