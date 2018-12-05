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
            //gcDanhSachCongViec.DataSource = db.CongViecDuocGiao(user.MaNhanVien).Select(cv => new
            //{
            //    cv.MaCongViec,
            //    cv.TenCV,
            //    cv.HoTen,
            //    cv.NgayBatDau,
            //    cv.NgayHetHan,
            //    cv.MoTa,
            //    TrangThai = cv.TrangThai == true ? "Hoàn thành" : "Chưa hoàn thành"
            //});
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
        }

        private bool kiemTraPhanCong(ICollection<PHANCONG> dsPhanCong, NHANVIEN user)
        {
            foreach (PHANCONG pc in dsPhanCong)
            {
                if (pc.NguoiNhan == user.MaNhanVien) return true;
            }
            return false;
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
                case "Cancel": flyoutPanelEdit.HidePopup(); clearControls(); break;
            }
        }

        private void trangThaiCongViec()
        {
            //PHANCONG phancong = congviec.PHANCONG.Where(pc => pc.NguoiNhan == MaNV).First();
            //congviec.PHANCONG.Where(pc =>pc.NguoiNhan == MaNV).First().TrangThai = !congviec.TrangThai;
            //if (congviec.TrangThai == true)
            //{
            //    congviec.NgayHoanThanh = DateTime.Now;
            //}
            //else
            //{
            //    congviec.NgayHoanThanh = null;
            //}
            phancong.TrangThai = !phancong.TrangThai;
            phancong.NgayHoanThanh = DateTime.Now;
            db.Entry(phancong).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            //thayDoiTrangThai(congviec.TrangThai.Value);
            flyoutPanelEdit.HidePopup();
            loadDuLieuGirdView();
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

        private void gvDanhSachCongViec_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle >= 0)
            {
                clearControls();
                int maCV = int.Parse(gvDanhSachCongViec.GetRowCellValue(e.FocusedRowHandle, "MaCongViec").ToString());
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
