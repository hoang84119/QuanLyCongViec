using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Presentation.Report
{
    public partial class reportCongViec : DevExpress.XtraReports.UI.XtraReport
    {
        public reportCongViec()
        {
            InitializeComponent();
        }

        public void createReport(List<PHANCONG> pc)
        {
            objectDataSource1.DataSource = pc;
        }
    }
}
