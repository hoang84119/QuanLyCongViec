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
using Presentation.Report;
using DevExpress.XtraReports.UI;

namespace Presentation.User_controls
{
    public partial class ucBaoCao : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucBaoCao _instance;
        private NHANVIEN user;

        public static ucBaoCao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBaoCao();
                return _instance;
            }
            set => _instance = value;
        }

        public NHANVIEN User { get => user; set => user = value; }

        public ucBaoCao()
        {
            InitializeComponent();
        }

        public void showReport()
        {
            barToggleSwitchItemChiTiet.Enabled = false;
            using (var db = new QLCONGVIECEntities())
            {
                reportCongViec report = new reportCongViec();
                user = db.NHANVIEN.Where(nv => nv.TenDangNhap == user.TenDangNhap).First();
                report.createReport(user.PHANCONG.ToList());
                documentViewer1.DocumentSource = report;
                report.CreateDocument();
            }
        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
            ((frmQuanLyCongViec)this.ParentForm).CloseLoading();
        }

        internal void showReportCVDaGiao()
        {
            barToggleSwitchItemChiTiet.Enabled = true;
            if(barToggleSwitchItemChiTiet.Checked)
            {
                using (var db = new QLCONGVIECEntities())
                {
                    reportCongViecDaGiao report = new reportCongViecDaGiao();
                    user = db.NHANVIEN.Where(nv => nv.TenDangNhap == user.TenDangNhap).First();
                    report.createReport(user);
                    documentViewer1.DocumentSource = report;
                    report.CreateDocument();
                }
            }
            else
            {
                using (var db = new QLCONGVIECEntities())
                {
                    reportTongQuatCVDaGiao report = new reportTongQuatCVDaGiao();
                    user = db.NHANVIEN.Where(nv => nv.TenDangNhap == user.TenDangNhap).First();
                    report.createReport(user);
                    documentViewer1.DocumentSource = report;
                    report.CreateDocument();
                }
            }
            
        }

        private void barToggleSwitchItemChiTiet_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            showReportCVDaGiao();
        }
    }
}
