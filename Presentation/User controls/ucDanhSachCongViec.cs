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
        QLCONGVIECEntities db = new QLCONGVIECEntities();
        CONGVIEC congviec;

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
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            gcDanhSachCongViec.DataSource = db.CongViecDuocGiao(user.MaNhanVien).Select(cv => new
            {
                cv.MaCongViec,
                cv.TenCV,
                cv.HoTen,
                cv.NgayBatDau,
                cv.NgayHetHan,
                cv.MoTa,
                TrangThai = cv.TrangThai == true ? "Hoàn thành" : "Chưa hoàn thành"
            });
            //gvDanhSachCongViec.BeginSort();
            //try
            //{
            //    gvDanhSachCongViec.ClearSorting();
            //    gvDanhSachCongViec.Columns["TrangThai"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            //}
            //finally
            //{
            //    gvDanhSachCongViec.EndSort();
            //}
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

        private void gcDanhSachCongViec_Click(object sender, EventArgs e)
        {
            clearControls();
            int index = gvDanhSachCongViec.GetSelectedRows()[0];
            int maCV = int.Parse(gvDanhSachCongViec.GetRowCellValue(index, "MaCongViec").ToString());
            congviec = db.CONGVIEC
                            .Where(cv => cv.MaCongViec == maCV).FirstOrDefault();
            if (congviec.TrangThai == true) thayDoiTrangThaiButton(true);
            else thayDoiTrangThaiButton(false);
            loadCongViec(congviec);
            flyoutPanelEdit.ShowPopup();
        }

        private void thayDoiTrangThaiButton(bool v)
        {
            foreach(DevExpress.Utils.PeekFormButton button in flyoutPanelEdit.OptionsButtonPanel.Buttons)
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
            congviec.TrangThai = !congviec.TrangThai;
            db.Entry(congviec).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            //thayDoiTrangThai(congviec.TrangThai.Value);
            flyoutPanelEdit.HidePopup();
            loadDuLieuGirdView();
        }

        private void clearControls()
        {
            congviec = null;
            cbbDuAn.SelectedIndex = -1;
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
            if (congviec.MaDuAn != null) cbbDuAn.SelectedValue = congviec.MaDuAn;
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
                }
            }
        }
    }
}
