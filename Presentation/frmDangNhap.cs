using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmDangNhap : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            //using (var db = new QLCONGVIECEntities())
            //{
            //    IEnumerable<NHANVIEN> nhanVien = from nv in db.NHANVIEN
            //                                     where nv.TenDangNhap == "admin" && nv.MatKhau == "123456"
            //                                     select nv;

            //        foreach (NHANVIEN nv in nhanVien)
            //        {
            //            frmQuanLyCongViec.Instance.User = nv;
            //        }
            //        this.Hide();
            //        frmQuanLyCongViec.Instance.ShowDialog();
            //        this.Close();
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (var db = new QLCONGVIECEntities())
            {
                IEnumerable<NHANVIEN> nhanVien = from nv in db.NHANVIEN
                               where nv.TenDangNhap == txtTenDangNhap.Text && nv.MatKhau == txtMatKhau.Text
                               select nv;
                if(nhanVien.Count()==0)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo",MessageBoxButtons.OK);
                }
                else
                {
                    using (frmQuanLyCongViec congViec =new frmQuanLyCongViec())
                    {
                        this.Hide();
                        foreach (NHANVIEN nv in nhanVien)
                        {
                            congViec.User = nv;
                        }
                        congViec.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        public void XoaDuLieu()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }
    }
}
