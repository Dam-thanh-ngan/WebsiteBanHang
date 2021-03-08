using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebsiteBanHang.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1Entities")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ChiTietNhap> ChiTietNhaps { get; set; }
        public virtual DbSet<ChiTietXuat> ChiTietXuats { get; set; }
        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<Khachhang> Khachhangs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhapXuatTon> NhapXuatTons { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhap>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietXuat>()
                .Property(e => e.MaPhieuXuat)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietXuat>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<ChiTietXuat>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<Khachhang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhapXuatTon>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaPhieuNhap)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaPhieuXuat)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);
        }
    }
}
