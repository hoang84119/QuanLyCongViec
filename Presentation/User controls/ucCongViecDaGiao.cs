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
        private CONGVIEC congviec;
        private List<PHANCONG> dsPhanCong = new List<PHANCONG>();
        private QLCONGVIECEntities db;

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
            txtNgayBatDau.Properties.MinValue = DateTime.Now;
            txtNgayHetHan.Properties.MinValue = DateTime.Now;

            //((frmQuanLyCongViec)this.ParentForm).ShowLoading();

            loadDuLieuGirdView();

            gcDSNhanVien.DataSource = dsPhanCong;

            loadNhanVienBangPhanCong();
        }

        private void loadDuLieuGirdView()
        {
            db = new QLCONGVIECEntities();
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
               //TrangThai = cv.TrangThai == true ? "hòa thành" : "chưa hoàn thành",
               cv.TienDo,
               NguoiNhan = String.Join(", ", (cv.PHANCONG.Select(pc => pc.NHANVIEN.HoTen).ToArray()))
                   //PhanCong = cv.PHANCONG.Select(pc => pc.NHANVIEN.HoTen)
               }).ToList();

            gcCongViecDaGiao.DataSource = BangCongViec;

        }

        private void gvDanhSachCongViec_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }

        private void txtNgayBatDau_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (txtNgayBatDau.Text != "")
            {
                txtNgayHetHan.Properties.MinValue = DateTime.Parse(txtNgayBatDau.Text);
            }
        }

        private void loadNhanVienBangPhanCong()
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;

            if (user.MaPhongBan == "GD")
            {
                //db.CONGVIEC
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            congviec = new CONGVIEC();
            //gvDSNhanVien.AddNewRow();
            flyoutPanelEdit.ShowPopup();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flyoutPanelEdit.ShowPopup();
            int index = gvCongViecDaGiao.GetSelectedRows()[0];
            int maCV = int.Parse(gvCongViecDaGiao.GetRowCellValue(index, "MaCongViec").ToString());

            congviec = db.CONGVIEC
                            .Where(cv => cv.MaCongViec == maCV).FirstOrDefault();
            loadCongViec(congviec);

        }

        private void loadCongViec(CONGVIEC congViec)
        {
            txtTenCongViec.Text = congViec.TenCV;
            txtNgayBatDau.Properties.MinValue = congViec.NgayBatDau;
            txtNgayBatDau.Text = congViec.NgayBatDau.ToLongDateString();
            txtNgayHetHan.Text = congViec.NgayHetHan.ToLongDateString();
            txtMoTa.Text = congViec.MoTa;
            //gcDSNhanVien.DataSource
            dsPhanCong = congViec.PHANCONG.ToList();
            //if (congviec.MaDuAn != null) cbbDuAn.SelectedValue = congviec.MaDuAn;
            gcDSNhanVien.DataSource = dsPhanCong;
        }

        private void luuCongViec()
        {
            if (txtTenCongViec.Text == "")
            {
                XtraMessageBox.Show("Tên không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCongViec.Focus();
            }
            else if (txtNgayBatDau.Text == "")
            {
                XtraMessageBox.Show("Ngày bắt đầu không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayBatDau.Focus();
            }
            else if (txtNgayHetHan.Text == "")
            {
                XtraMessageBox.Show("Ngày hết hạn không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNgayHetHan.Focus();
            }
            else if (dsPhanCong.Count == 0)
            {
                XtraMessageBox.Show("Bảng phân công không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
                congviec.TenCV = txtTenCongViec.Text;
                congviec.NguoiGiao = user.MaNhanVien;
                //if (cbbDuAn.SelectedIndex != -1) congviec.MaDuAn = int.Parse(cbbDuAn.SelectedValue.ToString());
                congviec.NgayBatDau = DateTime.Parse(txtNgayBatDau.Text);
                congviec.NgayHetHan = DateTime.Parse(txtNgayHetHan.Text);
                congviec.MoTa = txtMoTa.Text;
                //congviec.PHANCONG = dsPhanCong;

                //congviec.PHANCONG.Clear();

                if (congviec.PHANCONG.Count == 0)
                {
                    foreach (PHANCONG pc in dsPhanCong)
                    {
                        congviec.PHANCONG.Add(pc);
                    }
                }
                else
                {
                    int i = 0;
                    foreach (PHANCONG pc in congviec.PHANCONG.ToList())
                    {
                        try
                        {
                            pc.NguoiNhan = dsPhanCong.ElementAt(i).NguoiNhan;
                            pc.MoTa = dsPhanCong.ElementAt(i).MoTa;
                            pc.TrangThai = dsPhanCong.ElementAt(i).TrangThai;
                            pc.NgayHoanThanh = dsPhanCong.ElementAt(i).NgayHoanThanh;
                            pc.NHANVIEN = db.NHANVIEN.Where(nv => nv.MaNhanVien == pc.NguoiNhan).FirstOrDefault();
                            i++;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            congviec.PHANCONG.Remove(pc);
                        }

                    }
                    if (i < dsPhanCong.Count)
                    {
                        for (; i < dsPhanCong.Count; i++)
                        {
                            PHANCONG p = dsPhanCong.ElementAt(i);
                            p.MaCongViec = congviec.MaCongViec;
                            db.PHANCONG.Add(p);
                            //congviec.PHANCONG.Add(p);
                        }
                    }
                }
                if (congviec.MaCongViec == 0)
                    db.CONGVIEC.Add(congviec);
                else
                    db.Entry(congviec).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                flyoutPanelEdit.HidePopup();
                clearControls();
                loadDuLieuGirdView();
                XtraMessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void clearControls()
        {
            congviec = null;
            //cbbDuAn.SelectedIndex = -1;
            txtNgayBatDau.Properties.MinValue = txtNgayHetHan.Properties.MinValue = DateTime.Now;
            txtTenCongViec.Text = txtMoTa.Text = txtNgayBatDau.Text = txtNgayHetHan.Text = "";
            dsPhanCong = new List<PHANCONG>();
            gcDSNhanVien.DataSource = dsPhanCong;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            //gvDSNhanVien.AddNewRow();
            dsPhanCong.Add(new PHANCONG() { TrangThai = false });
            gcDSNhanVien.RefreshDataSource();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (congviec == null)
                {
                    int index = gvCongViecDaGiao.GetSelectedRows()[0];
                    int maCV = int.Parse(gvCongViecDaGiao.GetRowCellValue(index, "MaCongViec").ToString());
                    congviec = db.CONGVIEC
                        .Where(cv => cv.MaCongViec == maCV).FirstOrDefault();
                }
                var entry = db.Entry(congviec);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                    db.CONGVIEC.Attach(congviec);
                db.CONGVIEC.Remove(congviec);
                db.SaveChanges();

                loadDuLieuGirdView();
                //MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void flyoutPanelEdit_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            string tag = e.Button.Tag.ToString();
            switch (tag)
            {
                case "Save": luuCongViec(); break;
                case "Cancel": flyoutPanelEdit.HidePopup(); clearControls(); break;
            }
        }

        private void gvDSNhanVien_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "TrangThai")
            {
                if ((bool)e.Value) e.DisplayText = "Đã hoàn thành";
                else e.DisplayText = "Chưa hoàn thành";
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsPhanCong.RemoveAt(gvDSNhanVien.GetSelectedRows()[0]);
                XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                gcDSNhanVien.RefreshDataSource();
            }

        }

        private void HoTenEditor_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            NHANVIEN nv = db.NHANVIEN.Where(n => n.MaNhanVien == (int)e.NewValue).First();
            int count = nv.PHANCONG.Where(pc => pc.CONGVIEC.NgayHetHan >= DateTime.Parse(txtNgayBatDau.Text) && pc.TrangThai == false).Count();
            if(count > 3)
            {
                XtraMessageBox.Show("Người này đã được giao tối đa 3 công việc. Vui lòng chọn ngày bắt đầu khác" , "Thông báo", MessageBoxButtons.OK);
                e.Cancel = true;
            }
            else foreach(PHANCONG pc in dsPhanCong)
            {
                if(pc.NguoiNhan == (int) e.NewValue)
                {
                    XtraMessageBox.Show("Bạn chọn nhân viên này rồi", "Thông báo", MessageBoxButtons.OK);
                    e.Cancel = true;
                    break;
                }
            }
        }
    }
}
