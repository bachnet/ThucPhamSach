﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thuc_pham_sach_hd.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ThucPhamSachEntities : DbContext
    {
        public ThucPhamSachEntities()
            : base("name=ThucPhamSachEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }
        public virtual DbSet<DanhMuc> DanhMuc { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<NghiepVu> NghiepVu { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<QuanTri> QuanTri { get; set; }
        public virtual DbSet<QuyenHan> QuyenHan { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<Slide> Slide { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }
    }
}