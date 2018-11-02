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
        }
        private ucThemCongViec()
        {
            InitializeComponent();
        }


        private void ucThemCongViec_Load(object sender, EventArgs e)
        {
            txtNgayBatDau.Properties.MinValue = DateTime.Now;
            txtNgayHetHan.Properties.MinValue = DateTime.Now;

            cbbDuAn.DataSource = frmQuanLyCongViec.Instance.DbQuanLyCV.DUAN
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

            this.HoTenEditor.DataSource = frmQuanLyCongViec.Instance.DbQuanLyCV.NHANVIEN
                .Where(nv=>nv.MaNhanVien!=frmQuanLyCongViec.Instance.User.MaNhanVien)
                .Select(nv => new { nv.MaNhanVien, nv.HoTen }).ToList();
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
            frmQuanLyCongViec.Instance.getContainer.Controls.Remove(this);
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
            CONGVIEC cv = new CONGVIEC();
            cv.TenCV = txtTenCongViec.Text;
            cv.NguoiGiao = frmQuanLyCongViec.Instance.User.MaNhanVien;
            cv.NgayHetHan = DateTime.Parse(txtNgayHetHan.Text);
            cv.MoTa = txtMoTa.Text;
            foreach(DataRow row in bangPhanCong.Rows)
            {
                cv.PHANCONG.Add(new PHANCONG {NguoiNhan = Int32.Parse(row["HoTen"].ToString()) });
            }
            frmQuanLyCongViec.Instance.DbQuanLyCV.CONGVIEC.Add(cv);
            frmQuanLyCongViec.Instance.DbQuanLyCV.SaveChanges();
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
