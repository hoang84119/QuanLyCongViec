﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLCONGVIECEntities : DbContext
    {
        public QLCONGVIECEntities()
            : base("name=QLCONGVIECEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CONGVIEC> CONGVIEC { get; set; }
        public virtual DbSet<DUAN> DUAN { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHANCONG> PHANCONG { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBAN { get; set; }
    
        public virtual ObjectResult<DanhSachCongViec_Result> DanhSachCongViec(Nullable<int> maNV)
        {
            var maNVParameter = maNV.HasValue ?
                new ObjectParameter("MaNV", maNV) :
                new ObjectParameter("MaNV", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DanhSachCongViec_Result>("DanhSachCongViec", maNVParameter);
        }
    }
}
