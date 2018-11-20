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
            loadDuLieuCbb();
            loadDuLieuGirdView();
        }

        private void loadDuLieuGirdView()
        {
            
        }

        private void loadDuLieuCbb()
        {
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
                gridEditNV.Properties.DataSource = db.NHANVIEN
                                    .Where(nv => nv.MaNhanVien != user.MaNhanVien)
                                    .ToList();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flyoutPanelEdit.ShowPopup();
        }

        
    }
}
