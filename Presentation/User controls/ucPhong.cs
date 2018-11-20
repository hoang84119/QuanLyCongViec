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
    public partial class ucPhong : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucPhong _instance;
        private QLCONGVIECEntities db = new QLCONGVIECEntities();
        PHONGBAN phong;

        public static ucPhong Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucPhong();
                return _instance;
            }
            set => _instance = value;
        }

        public ucPhong()
        {
            InitializeComponent();
        }

        private void ucPhong_Load(object sender, EventArgs e)
        {
            //loadDuLieuCbb();
            loadDuLieuGirdView();
        }

        public void loadDuLieuGirdView()
        {
            gcPhong.DataSource = db.PHONGBAN.ToList();
        }

        private void loadDuLieuCbb()
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            gridEditNV.Properties.DataSource = db.NHANVIEN
                                .Where(nv => nv.MaNhanVien != user.MaNhanVien && nv.PHONGBAN.MaPhongBan == phong.MaPhongBan)
                                .ToList();
            if(phong.NHANVIEN1 != null)
            {
                gridEditNV.EditValue = phong.NHANVIEN1.MaNhanVien;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            clearControls();
            phong = new PHONGBAN();
            chinhSua(false);
            flyoutPanelEdit.ShowPopup();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            chinhSua(true);
            phong = (PHONGBAN)gvPhong.GetFocusedRow();
            loadDuLieuCbb();
            flyoutPanelEdit.ShowPopup();
            loadPhong();
        }

        private void chinhSua(bool v)
        {
            txtMaPhong.Enabled = !v;
            gridEditNV.Enabled = v;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (phong == null)
                {
                    phong = (PHONGBAN)gvPhong.GetFocusedRow();
                }
                var entry = db.Entry(phong);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                    db.PHONGBAN.Attach(phong);
                db.PHONGBAN.Remove(phong);
                db.SaveChanges();
                loadDuLieuGirdView();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void flyoutPanelEdit_ButtonClick(object sender, DevExpress.Utils.FlyoutPanelButtonClickEventArgs e)
        {
            string tag = e.Button.Tag.ToString();
            switch (tag)
            {
                case "Save": luuPhong(); break;
                case "Cancel": flyoutPanelEdit.HidePopup(); break;
            }
        }

        private void loadPhong()
        {
            txtMaPhong.Text = phong.MaPhongBan;
            txtTenPhong.Text = phong.TenPhong;
        }

        private void luuPhong()
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Mã phòng không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaPhong.Focus();
            }
            else if (txtTenPhong.Text == "")
            {
                MessageBox.Show("Tên phòng không được rỗng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenPhong.Focus();
            }
            else
            {
                phong.TenPhong = txtTenPhong.Text;
                if (phong.MaPhongBan != txtMaPhong.Text)
                {
                    phong.MaPhongBan = txtMaPhong.Text;
                    db.PHONGBAN.Add(phong);
                }
                else
                {
                    NHANVIEN nv = (NHANVIEN)gridEditNVView.GetFocusedRow();
                    phong.TruongPhong = nv.MaNhanVien;
                    db.Entry(phong).State = System.Data.Entity.EntityState.Modified;
                }
                db.SaveChanges();
                loadDuLieuGirdView();
                flyoutPanelEdit.HidePopup();
                //MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void clearControls()
        {
            phong = null;
            txtMaPhong.Text = txtTenPhong.Text = "";
            gridEditNV.EditValue = null;
        }

        private void gcPhong_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }
    }
}
