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

namespace Presentation.User_controls
{
    public partial class ucDanhSachCongViec : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDanhSachCongViec _instance;

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

        static QLCONGVIECEntities db = new QLCONGVIECEntities();
        private ucDanhSachCongViec()
        {
            InitializeComponent();
        }

        private void ucDanhSachCongViec_Load(object sender, EventArgs e)
        {
            var BangCongViec = db.CONGVIEC;
            NHANVIEN user = ((frmQuanLyCongViec)this.ParentForm).User;
            ObjectResult<CongViecDuocGiao_Result> ds = db.CongViecDuocGiao(user.MaNhanVien);
            gvDanhSachCongViec.DataSource = ds;
        }
    }
}
