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
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using DevExpress.XtraGrid.Views.Grid;

namespace Presentation.User_controls
{
    public partial class ucDanhSachCongViec : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDanhSachCongViec _instance;
        QLCONGVIECEntities db;
        //CONGVIEC congviec;
        PHANCONG phancong;
        int MaNV;

        public static ucDanhSachCongViec Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDanhSachCongViec();
                return _instance;
            }
            set => _instance = value;
        }

        //static QLCONGVIECEntities db = new QLCONGVIECEntities();
        private ucDanhSachCongViec()
        {
            InitializeComponent();
        }

        private void ucDanhSachCongViec_Load(object sender, EventArgs e)
        {
            //((frmQuanLyCongViec)this.ParentForm).ShowLoading();

            loadDuLieuGirdView();
        }

        private void loadDuLieuGirdView()
        {
            db = new QLCONGVIECEntities();
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            MaNV = user.MaNhanVien;
            gcDanhSachCongViec.DataSource = db.NHANVIEN.Where(nv => nv.MaNhanVien == user.MaNhanVien).First()
                            .PHANCONG
                            .Select(pc => new
                            {
                                pc.MaCongViec,
                                pc.CONGVIEC.TenCV,
                                pc.CONGVIEC.NHANVIEN.HoTen,
                                pc.CONGVIEC.NgayBatDau,
                                pc.CONGVIEC.NgayHetHan,
                                pc.CONGVIEC.MoTa,
                                pc.CONGVIEC.TienDo,
                                TrangThai = pc.TrangThai == true ? "Hoàn thành" : "Chưa hoàn thành"
                            });
            gvDanhSachCongViec.ExpandAllGroups();
            if (user.PHONGBAN1.Count != 0) loadChucNangTruongPhong(user);
            else layoutBtnThem.Visibility = layoutBtnXoa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void loadChucNangTruongPhong(NHANVIEN user)
        {
            cbbNhanVien.DataSource = db.NHANVIEN
                                    .Where(nv => nv.MaNhanVien != user.MaNhanVien && nv.MaPhongBan == user.MaPhongBan)
                                    .Select(nv => new { nv.MaNhanVien, nv.HoTen }).ToList();
            cbbNhanVien.ValueMember = "MaNhanVien";
            cbbNhanVien.DisplayMember = "HoTen";
            layoutBtnThem.Visibility = layoutBtnXoa.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
        }

        private void gcDanhSachCongViec_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }

        private void thayDoiTrangThaiButton(bool v)
        {
            foreach (DevExpress.Utils.PeekFormButton button in flyoutPanelEdit.OptionsButtonPanel.Buttons)
            {
                string tag = button.Tag.ToString();
                switch (tag)
                {
                    case "HoanThanh": button.Visible = !v; break;
                    case "ChuaHoanThanh": button.Visible = v; break;
                }
            }
        }

        private void flyoutPanelEdit_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            string tag = e.Button.Tag.ToString();
            switch (tag)
            {
                case "HoanThanh": trangThaiCongViec(); break;
                case "ChuaHoanThanh": trangThaiCongViec(); break;
                case "Cancel":  clearControls(); flyoutPanelEdit.HidePopup(); break;
            }
        }

        private void trangThaiCongViec()
        {
            phancong.TrangThai = !phancong.TrangThai;
            phancong.NgayHoanThanh = DateTime.Now;
            db.Entry(phancong).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            //thayDoiTrangThai(congviec.TrangThai.Value);
            loadDuLieuGirdView();
            flyoutPanelEdit.HidePopup();
        }

        private void clearControls()
        {
            //congviec = null;
            phancong = null;
            //cbbDuAn.SelectedIndex = -1;
            txtNgayBatDau.Properties.MinValue = txtNgayHetHan.Properties.MinValue = DateTime.Now;
            txtTenCongViec.Text = txtMoTa.Text = txtNgayBatDau.Text = txtNgayHetHan.Text = "";
            gvDSNhanVien.RefreshData();
        }

        private void loadCongViec(CONGVIEC congViec)
        {
            txtTenCongViec.Text = congViec.TenCV;
            txtNgayBatDau.Properties.MinValue = congViec.NgayBatDau;
            txtNgayBatDau.Text = congViec.NgayBatDau.ToLongDateString();
            txtNgayHetHan.Text = congViec.NgayHetHan.ToLongDateString();
            txtMoTa.Text = congViec.MoTa;
            //gcDSNhanVien.DataSource
            gcDSNhanVien.DataSource = congViec.PHANCONG.ToList();
            //if (congViec.MaDuAn != null) cbbDuAn.SelectedValue = congViec.MaDuAn;
        }

        private void gvDanhSachCongViec_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string trangThai = view.GetRowCellDisplayText(e.RowHandle, view.Columns["TrangThai"]);
                DateTime ngayHetHan = (DateTime)view.GetRowCellValue(e.RowHandle, view.Columns["NgayHetHan"]);
                if (trangThai == "Chưa hoàn thành")
                {
                    if (DateTime.Compare(ngayHetHan, DateTime.Now) < 0)
                    {
                        e.Appearance.BackColor = Color.FromArgb(150, Color.LightCoral);
                        e.Appearance.BackColor2 = Color.White;
                    }
                    else
                    {
                        TimeSpan interval = ngayHetHan.Subtract(DateTime.Now);
                        if (interval.Days <= 2)
                        {
                            e.Appearance.BackColor = Color.FromArgb(255, 165, 0);
                            e.Appearance.BackColor2 = Color.White;
                        }
                    }
                }
            }
        }

        //private void gvDanhSachCongViec_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        //{
        //    if(e.FocusedRowHandle >= 0)
        //    {
        //        clearControls();
        //        int maCV = int.Parse(gvDanhSachCongViec.GetRowCellValue(e.FocusedRowHandle, "MaCongViec").ToString());
        //        phancong = db.PHANCONG
        //                        .Where(pc => pc.MaCongViec == maCV && pc.NguoiNhan == MaNV).FirstOrDefault();
        //        if (phancong.TrangThai == true) thayDoiTrangThaiButton(true);
        //        else thayDoiTrangThaiButton(false);
        //        loadCongViec(phancong.CONGVIEC);
        //        flyoutPanelEdit.ShowPopup();
        //    }
        //}

        private void flyoutPanelThemNV_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            string tag = e.Button.Tag.ToString();
            switch (tag)
            {
                case "Save": ThemNhanVien(); break;
                case "Cancel": flyoutPanelThemNV.HidePopup(); cbbNhanVien.SelectedIndex = -1; txtMoTaPC.Text = ""; break;
            }
        }

        private void ThemNhanVien()
        {
            if(cbbNhanVien.SelectedIndex < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn nhân viên", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bool check = false;
                for(int i =0; i< gvDSNhanVien.DataRowCount;i++)
                {
                    int ma = (int)gvDSNhanVien.GetRowCellValue(i, "NguoiNhan");
                    if ((int)gvDSNhanVien.GetRowCellValue(i, "NguoiNhan") == int.Parse(cbbNhanVien.SelectedValue.ToString()))
                    {
                        check = true;
                        break;
                    }
                }
                if (!check)
                {
                    PHANCONG pc = new PHANCONG();
                    pc.MaCongViec = phancong.MaCongViec;
                    pc.NguoiNhan = int.Parse(cbbNhanVien.SelectedValue.ToString());
                    pc.MoTa = txtMoTaPC.Text;
                    pc.TrangThai = false;
                    db.PHANCONG.Add(pc);
                    db.SaveChanges();
                    db = new QLCONGVIECEntities();
                    flyoutPanelThemNV.HidePopup();
                    phancong = db.PHANCONG
                                    .Where(p => p.MaCongViec == pc.MaCongViec && p.NguoiNhan == MaNV).FirstOrDefault();
                    loadCongViec(phancong.CONGVIEC);
                    cbbNhanVien.SelectedIndex = -1; txtMoTaPC.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("Bạn chọn nhân viên này rồi", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flyoutPanelThemNV.ShowPopup();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            PHANCONG pc = (PHANCONG) gvDSNhanVien.GetFocusedRow();
            if(pc.NHANVIEN.MaPhongBan != phancong.NHANVIEN.MaPhongBan)
            {
                XtraMessageBox.Show("Không được xóa nhân viên phòng khác", "Thông báo", MessageBoxButtons.OK);
            }
            else if (pc.NHANVIEN.MaNhanVien == phancong.NHANVIEN.MaNhanVien)
            {
                XtraMessageBox.Show("Không được trốn việc :)", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                db.PHANCONG.Remove(pc);
                db.SaveChanges();
                //db = new QLCONGVIECEntities();
                loadCongViec(phancong.CONGVIEC);
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            int index = gvDanhSachCongViec.GetSelectedRows()[0];
            if(index >= 0)
            {
                int maCV = int.Parse(gvDanhSachCongViec.GetRowCellValue(index, "MaCongViec").ToString());
                phancong = db.PHANCONG
                                .Where(pc => pc.MaCongViec == maCV && pc.NguoiNhan == MaNV).FirstOrDefault();
                if (phancong.TrangThai == true) thayDoiTrangThaiButton(true);
                else thayDoiTrangThaiButton(false);
                loadCongViec(phancong.CONGVIEC);
                flyoutPanelEdit.ShowPopup();
            }
        }
    }
}
