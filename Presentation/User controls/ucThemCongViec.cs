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
    public partial class ucThemCongViec : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucThemCongViec _instance;
        DataTable bangPhanCong;
        BindingManagerBase danhsach;

        public static ucThemCongViec Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucThemCongViec();
                return _instance;
            }
            set => _instance = value;
        }

        private ucThemCongViec()
        {
            InitializeComponent();
        }


        private void ucThemCongViec_Load(object sender, EventArgs e)
        {
            txtNgayBatDau.Properties.MinValue = DateTime.Now;
            txtNgayHetHan.Properties.MinValue = DateTime.Now;
            using (var db = new QLCONGVIECEntities())
            {
                cbbDuAn.DataSource = db.DUAN
                    .Select(da => new { da.MaDuAn, da.TenDA }).ToList();
                cbbDuAn.DisplayMember = "TenDA";
                cbbDuAn.ValueMember = "MaDuAn";
                cbbDuAn.SelectedIndex = -1;

                bangPhanCong = new DataTable("BangPhanCong");
                bangPhanCong.Columns.Add("HoTen", typeof(string));
                bangPhanCong.Columns.Add("MoTa", typeof(string));
                gridControl1.DataSource = bangPhanCong;

                danhsach = this.BindingContext[bangPhanCong];
                danhsach.AddNew();

                NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
                this.HoTenEditor.DataSource = db.NHANVIEN
                    .Where(nv => nv.MaNhanVien != user.MaNhanVien)
                    .Select(nv => new { nv.MaNhanVien, nv.HoTen }).ToList();
            }
        }

        private void HoTenEditor_EditValueChanged(object sender, EventArgs e)
        {
            //this.gvDSNhanVien.PostEditor();
            //this.gvDSNhanVien.SetFocusedRowCellValue("MaNhanVien", this.HoTenEditor);
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            danhsach.AddNew();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            xoaDuLieu();
            this.Parent.Controls.Remove(this);
        }

        private void xoaDuLieu()
        {
            txtTenCongViec.Text = "";
            txtMoTa.Text = "";
            txtNgayBatDau.Text = "";
            txtNgayHetHan.Text = "";
            bangPhanCong.Clear();
            danhsach.AddNew();
            cbbDuAn.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            CONGVIEC cv = new CONGVIEC();
            cv.TenCV = txtTenCongViec.Text;
            cv.NguoiGiao = user.MaNhanVien;
            cv.NgayGiao = DateTime.Now;
            cv.NgayBatDau = DateTime.Parse(txtNgayBatDau.Text);
            cv.NgayHetHan = DateTime.Parse(txtNgayHetHan.Text);
            cv.TrangThai = false;
            cv.MoTa = txtMoTa.Text;
            foreach(DataRow row in bangPhanCong.Rows)
            {
                cv.PHANCONG.Add(new PHANCONG {NguoiNhan = Int32.Parse(row["HoTen"].ToString()), MoTa=row["MoTa"].ToString() });
            }
            using (var db = new QLCONGVIECEntities())
            {
                db.CONGVIEC.Add(cv);
                db.SaveChanges();
            }
            xoaDuLieu();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void txtNgayBatDau_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(txtNgayBatDau.Text!="")
            {
                txtNgayHetHan.Properties.MinValue = DateTime.Parse(txtNgayBatDau.Text);
            }
        }
    }
}
