//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Presentation
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHANCONG
    {
        public int MaPhanCong { get; set; }
        public int MaCongViec { get; set; }
        public int NguoiNhan { get; set; }
        public Nullable<bool> TrangThai { get; set; }
        public Nullable<System.DateTime> NgayHoanThanh { get; set; }
        public string MoTa { get; set; }
    
        public virtual CONGVIEC CONGVIEC { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
