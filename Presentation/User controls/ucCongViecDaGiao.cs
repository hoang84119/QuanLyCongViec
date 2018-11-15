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
        //DataTable bangPhanCong;

        private QLCONGVIECEntities db = new QLCONGVIECEntities();

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

            ((frmQuanLyCongViec)this.ParentForm).ShowLoading();

            loadDuLieuGirdView();

            cbbDuAn.DataSource = db.DUAN
                .Select(da => new { da.MaDuAn, da.TenDA }).ToList();
            cbbDuAn.DisplayMember = "TenDA";
            cbbDuAn.ValueMember = "MaDuAn";
            cbbDuAn.SelectedIndex = -1;

            gcDSNhanVien.DataSource = dsPhanCong ;

            loadNhanVienBangPhanCong();
        }

        private void loadDuLieuGirdView()
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
                    NguoiNhan = String.Join(", ", (cv.PHANCONG.Select(pc => pc.NHANVIEN.HoTen).ToArray()))
                        //PhanCong = cv.PHANCONG.Select(pc => pc.NHANVIEN.HoTen)
                    }).ToList();

            gcCongViecDaGiao.DataSource = BangCongViec;
        }

        private void gvDanhSachCongViec_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }

        //private void buttonPanelEditor_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        //{
        //    if (e.Button == buttonPanelEditor.Buttons[0])
        //    {
        //        suaCongViec();
        //    }
        //}

        private void suaCongViec()
        {
            int index = gvCongViecDaGiao.GetSelectedRows()[0];
            int maCV = int.Parse(gvCongViecDaGiao.GetRowCellValue(index, "MaCongViec").ToString());
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

        private void txtNgayBatDau_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (txtNgayBatDau.Text != "")
            {
                txtNgayHetHan.Properties.MinValue = DateTime.Parse(txtNgayBatDau.Text);
            }
        }


        private void loadCongViec(CONGVIEC congViec)
        {
            txtTenCongViec.Text = congViec.TenCV;
            txtNgayBatDau.Properties.MinValue = congViec.NgayBatDau;
            txtNgayBatDau.Text = congViec.NgayBatDau.ToLongDateString();
            txtNgayHetHan.Text = congViec.NgayHetHan.ToLongDateString();
            txtMoTa.Text = congViec.MoTa;
            //gcDSNhanVien.DataSource
            dsPhanCong = congViec.PHANCONG
                .Select(pc => new PHANCONG()
                {
                    //pc.NHANVIEN.HoTen,
                    NguoiNhan = pc.NHANVIEN.MaNhanVien,
                    MoTa = pc.MoTa
                })
                .ToList();
            gcDSNhanVien.DataSource = dsPhanCong;
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
            gvDSNhanVien.AddNewRow();
            capNhatTrangThai(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int index = gvCongViecDaGiao.GetSelectedRows()[0];
            int maCV = int.Parse(gvCongViecDaGiao.GetRowCellValue(index, "MaCongViec").ToString());
            congviec = db.CONGVIEC
                .Where(cv => cv.MaCongViec == maCV).FirstOrDefault();
            loadCongViec(congviec);
            capNhatTrangThai(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            capNhatTrangThai(false);
            clearControls();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            congviec.TenCV = txtTenCongViec.Text;
            congviec.NguoiGiao = user.MaNhanVien;
            congviec.NgayGiao = DateTime.Now;
            congviec.NgayBatDau = DateTime.Parse(txtNgayBatDau.Text);
            congviec.NgayHetHan = DateTime.Parse(txtNgayHetHan.Text);
            congviec.TrangThai = false;
            congviec.MoTa = txtMoTa.Text;

            //congviec.PHANCONG.Clear();
            if(congviec.PHANCONG.Count == 0)
            {
                foreach (PHANCONG pc in dsPhanCong)
                {
                    congviec.PHANCONG.Add(pc);
                }
            }
            else
            {
                int i = 0;
                foreach (PHANCONG pc in congviec.PHANCONG)
                {
                    pc.NguoiNhan = dsPhanCong.ElementAt(i).NguoiNhan;
                    pc.MoTa = dsPhanCong.ElementAt(i).MoTa;
                    i++;
                }
                if(i<dsPhanCong.Count)
                {
                    for(;i<dsPhanCong.Count;i++)
                    {
                        congviec.PHANCONG.Add(dsPhanCong.ElementAt(i));
                    }
                }
            }

            if (congviec.MaCongViec == 0)
                db.CONGVIEC.Add(congviec);
            else
                db.Entry(congviec).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            clearControls();
            loadDuLieuGirdView();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            capNhatTrangThai(false);
        }

        private void clearControls()
        {
            congviec = null;
            txtTenCongViec.Text = txtMoTa.Text = txtNgayBatDau.Text = txtNgayHetHan.Text = "";
            cbbDuAn.SelectedIndex = -1;
            txtNgayBatDau.Properties.MinValue = txtNgayHetHan.Properties.MinValue = DateTime.Now;
            dsPhanCong.Clear();
            gvDSNhanVien.RefreshData();
        }

        private void capNhatTrangThai(bool isEdit)
        {
            layoutEdit.Visible = btnLuu.Visible = btnHuy.Visible = isEdit;
            btnThem.Visible = btnSua.Visible = !isEdit;
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            //gvDSNhanVien.AddNewRow();
            dsPhanCong.Add(new PHANCONG());
            gcDSNhanVien.RefreshDataSource();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?","Thông báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                if(congviec == null)
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
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                capNhatTrangThai(false);
                clearControls();
            }
        }
    }
}
