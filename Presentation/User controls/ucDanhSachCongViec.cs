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
        }

        static QLCONGVIECEntities db = new QLCONGVIECEntities();
        public ucDanhSachCongViec()
        {
            InitializeComponent();
        }

        private void ucDanhSachCongViec_Load(object sender, EventArgs e)
        {
            //var BangCongViec = db.CONGVIEC.Join(db.CONGVIEC,
            //cv => cv.MaCongViec,
            //pc => pc.MaCongViec,
            //(cv, pc) => new { CONGVIEC = cv, PHANCONG = pc });
            var BangCongViec = db.CONGVIEC;
            gvDanhSachCongViec.DataSource = BangCongViec.ToList();
        }
    }
}
