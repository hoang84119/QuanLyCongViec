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
    public partial class ucDangNhap : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDangNhap _instance;

        public static ucDangNhap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDangNhap();
                return _instance;
            }
        }

        public ucDangNhap()
        {
            InitializeComponent();
        }
    }
}
