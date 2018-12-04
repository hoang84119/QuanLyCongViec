using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Presentation.Report
{
    public partial class reportCongViecDaGiao : DevExpress.XtraReports.UI.XtraReport
    {
        public reportCongViecDaGiao()
        {
            InitializeComponent();
        }

        internal void createReport(NHANVIEN nHANVIEN)
        {
            objectDataSourceDSCV.DataSource = nHANVIEN.CONGVIEC;
        }
    }
}
