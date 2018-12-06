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

        private void cfThoiGianHoanThanhTong_GetValue(object sender, GetValueEventArgs e)
        {
            DateTime ngayBatDau = (DateTime) e.GetColumnValue("NgayBatDau");
            DateTime ngayHoanThanh;
            try
            {
                ngayHoanThanh = (DateTime)e.GetColumnValue("NgayHoanThanh");
                TimeSpan interval = ngayHoanThanh.Subtract(ngayBatDau);
                string thoiGian = "";

                if (interval.Days != 0)
                {
                    thoiGian = interval.Days + " ngày";
                }
                else
                {
                    thoiGian = interval.Hours + " giờ";
                }
                e.Value = thoiGian;
            }
            catch
            {
                e.Value = null;
            }
        }
    }
}
