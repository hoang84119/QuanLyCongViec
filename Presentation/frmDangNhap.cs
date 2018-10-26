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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            
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
                if(nhanVien.ToList().Count==0)
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
        }
    }
}
