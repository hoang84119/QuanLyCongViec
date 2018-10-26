using DevExpress.XtraBars;
using Presentation.User_controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frmQuanLyCongViec : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private NHANVIEN user;

        public frmQuanLyCongViec()
        {
            InitializeComponent();
        }

        public NHANVIEN User { get => user; set => user = value; }

        private void acDSCV_Click(object sender, EventArgs e)
        {
            if(!container.Contains(ucDanhSachCongViec.Instance))
            {
                container.Controls.Add(ucDanhSachCongViec.Instance);
                ucDanhSachCongViec.Instance.Dock = DockStyle.Fill;
            }
            ucDanhSachCongViec.Instance.BringToFront();
        }
    }
}
