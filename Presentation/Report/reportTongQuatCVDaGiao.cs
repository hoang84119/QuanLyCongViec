using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace Presentation.Report
{
    public partial class reportTongQuatCVDaGiao : DevExpress.XtraReports.UI.XtraReport
    {
        public reportTongQuatCVDaGiao()
        {
            InitializeComponent();
        }

        private void cfNguoiNhan_GetValue(object sender, GetValueEventArgs e)
        {
            ICollection<PHANCONG> dsPC = (ICollection<PHANCONG>)e.GetColumnValue("PHANCONG");
            string nguoiNhan = "";
            foreach (PHANCONG pc in dsPC)
            {
                if (nguoiNhan != "") nguoiNhan += ", ";
                nguoiNhan += pc.NHANVIEN.HoTen;
            }
            e.Value = nguoiNhan;
        }

        internal void createReport(NHANVIEN nHANVIEN)
        {
            objectDataSource1.DataSource = nHANVIEN.CONGVIEC;
        }

        private void cfTrangThai_GetValue(object sender, GetValueEventArgs e)
        {
            int tienDo = (int)e.GetColumnValue("TienDo");
            string trangthai = "";
            if (tienDo != 100)
            {
                DateTime ngayHetHan = (DateTime)e.GetColumnValue("NgayHetHan");
                if (DateTime.Compare(ngayHetHan, DateTime.Now) < 0)
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
        }
    }
}
