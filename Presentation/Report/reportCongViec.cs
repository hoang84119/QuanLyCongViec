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

        private void calculatedField1_GetValue(object sender, GetValueEventArgs e)
        {
            CONGVIEC cv = (CONGVIEC) e.GetColumnValue("CONGVIEC");
            bool tt = (bool) e.GetColumnValue("TrangThai");
            string trangthai = "";
            if(!tt)
            {
                if (DateTime.Compare(cv.NgayHetHan, DateTime.Now) < 0)
                {
                    trangthai = "Chậm tiến độ";
                }
                else
                {
                    trangthai = "Đang tiến hành";
                }
            }
            else
            {
                trangthai = "Đã hoàn thành";
            }
            e.Value = trangthai;
            //e.Value = (int)((DateTime)columnValue).DayOfWeek;
        }
    }
}
