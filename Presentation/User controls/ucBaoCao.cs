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

        public ucBaoCao()
        {
            InitializeComponent();
        }

        public void showReport(NHANVIEN nv)
        {
            reportCongViec report = new reportCongViec();
            report.createReport(nv.PHANCONG.ToList());
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
