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
            string trangthai = "";
            if(cv.TrangThai == false)
            {
                trangthai = "Chưa hoàn thành";
            }
            else
            {
                if(DateTime.Compare(cv.NgayHetHan, (DateTime) cv.NgayHoanThanh) < 0)
                {
                    trangthai = "Hoàn thành Chậm tiến độ";
                }
                else
                {
                    trangthai = "Hoàn thành đúng tiến độ";
                }
            }
            e.Value = trangthai;
            //e.Value = (int)((DateTime)columnValue).DayOfWeek;
        }
    }
}
