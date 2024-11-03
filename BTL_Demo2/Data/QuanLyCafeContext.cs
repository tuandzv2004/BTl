using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BTL_Demo2.Data;

public partial class QuanLyCafeContext : DbContext
{
    public QuanLyCafeContext()
    {
    }

    public QuanLyCafeContext(DbContextOptions<QuanLyCafeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietHd> ChiTietHds { get; set; }
    public DbSet<ChiTietGioHang> ChiTietGioHangs { get; set; }

    public virtual DbSet<ChuDe> ChuDes { get; set; }

    public virtual DbSet<GopY> Gopies { get; set; }

    public virtual DbSet<HangHoa> HangHoas { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHang { get; set; }

    public virtual DbSet<Loai> Loais { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhanCong> PhanCongs { get; set; }

    public virtual DbSet<VChiTietHoaDon> VChiTietHoaDons { get; set; }

   // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
     //   => optionsBuilder.UseSqlServer("Data Source=DESKTOP-C31DCFO\\SQLEXPRESS01;Initial Catalog=QuanLyCafe;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietHd>(entity =>
        {
            entity.HasKey(e => e.MaCt).HasName("PK__ChiTietH__27258E749E67AC3B");

            entity.ToTable("ChiTietHD");

            entity.Property(e => e.MaCt)
                .HasMaxLength(10)
                .HasColumnName("MaCT");
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaHh)
                .HasMaxLength(10)
                .HasColumnName("MaHH");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.ChiTietHds)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHD__MaHD__6E01572D");

            entity.HasOne(d => d.MaHhNavigation).WithMany(p => p.ChiTietHds)
                .HasForeignKey(d => d.MaHh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietHD__MaHH__6EF57B66");
        });

        modelBuilder.Entity<ChuDe>(entity =>
        {
            entity.HasKey(e => e.MaCd).HasName("PK__ChuDe__27258E0402A92C1E");

            entity.ToTable("ChuDe");

            entity.Property(e => e.MaCd)
                .HasMaxLength(10)
                .HasColumnName("MaCD");
            entity.Property(e => e.MoTa).HasMaxLength(200);
            entity.Property(e => e.TenCd)
                .HasMaxLength(50)
                .HasColumnName("TenCD");
        });

        modelBuilder.Entity<GopY>(entity =>
        {
            entity.HasKey(e => e.MaGy).HasName("PK__GopY__2725AEF4D66F345A");

            entity.ToTable("GopY");

            entity.Property(e => e.MaGy)
                .HasMaxLength(10)
                .HasColumnName("MaGY");
            entity.Property(e => e.MaCd)
                .HasMaxLength(10)
                .HasColumnName("MaCD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.NgayGy).HasColumnName("NgayGY");
            entity.Property(e => e.NgayTl).HasColumnName("NgayTL");
            entity.Property(e => e.NoiDungTl).HasColumnName("NoiDungTL");

            entity.HasOne(d => d.MaCdNavigation).WithMany(p => p.Gopies)
                .HasForeignKey(d => d.MaCd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GopY__MaCD__6754599E");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Gopies)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__GopY__MaKH__68487DD7");
        });

        modelBuilder.Entity<HangHoa>(entity =>
        {
            entity.HasKey(e => e.MaHh).HasName("PK__HangHoa__2725A6E4AC7B0762");

            entity.ToTable("HangHoa");

            entity.Property(e => e.MaHh)
                .HasMaxLength(10)
                .HasColumnName("MaHH");
            entity.Property(e => e.MaLoai).HasMaxLength(10);
            entity.Property(e => e.NgaySx)
                .HasColumnType("datetime")
                .HasColumnName("NgaySX");
            entity.Property(e => e.TenHh)
                .HasMaxLength(50)
                .HasColumnName("TenHH");

           // entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.HangHoas)
               // .HasForeignKey(d => d.MaLoai)
                //.OnDelete(DeleteBehavior.ClientSetNull)
                //.HasConstraintName("FK__HangHoa__MaLoai__6B24EA82");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E084C36B23");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaKh)
                .HasMaxLength(10)
                .HasColumnName("MaKH");
            entity.Property(e => e.MaTrangThai).HasMaxLength(10);
            entity.Property(e => e.NgayCan).HasColumnType("datetime");
            entity.Property(e => e.NgayDat).HasColumnType("datetime");
            entity.Property(e => e.NgayGiao).HasColumnType("datetime");

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaKH__5441852A");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            // Set the primary key
            entity.HasKey(e => e.MaKH).HasName("PK__KhachHang__2725CF1EA3AB1303");

            // Define the table name
            entity.ToTable("KhachHang");

            // Map properties to columns
            entity.Property(e => e.MaKH)
                .HasMaxLength(10)
                .HasColumnName("MaKH");

            entity.Property(e => e.TenKH)
                .HasMaxLength(50)
                .HasColumnName("TenKH");

            entity.Property(e => e.DienThoai)
                .HasMaxLength(15);

            entity.Property(e => e.Email)
                .HasMaxLength(100);

            

            // Add any other properties you need to map
            // Example:
            // entity.Property(e => e.HieuLuc).IsRequired();
            // entity.Property(e => e.NgaySinh).HasColumnType("datetime");
        });


        modelBuilder.Entity<Loai>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__Loai__730A575989F5E440");

            entity.ToTable("Loai");

            entity.Property(e => e.MaLoai).HasMaxLength(10);
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70AA09AA04C");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.DiaChi).HasMaxLength(200);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.TenNv)
                .HasMaxLength(50)
                .HasColumnName("TenNV");
        });

        modelBuilder.Entity<PhanCong>(entity =>
        {
            entity.HasKey(e => e.MaPc).HasName("PK__PhanCong__2725E7E51A5DF34D");

            entity.ToTable("PhanCong");

            entity.Property(e => e.MaPc)
                .HasMaxLength(10)
                .HasColumnName("MaPC");
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .HasColumnName("MaNV");
            entity.Property(e => e.NgayPhan).HasColumnType("datetime");

            entity.HasOne(d => d.MaHdNavigation).WithMany(p => p.PhanCongs)
                .HasForeignKey(d => d.MaHd)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanCong__MaHD__5FB337D6");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.PhanCongs)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanCong__MaNV__5EBF139D");
        });

        modelBuilder.Entity<VChiTietHoaDon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vChiTietHoaDon");

            entity.Property(e => e.MaCt)
                .HasMaxLength(10)
                .HasColumnName("MaCT");
            entity.Property(e => e.MaHd)
                .HasMaxLength(10)
                .HasColumnName("MaHD");
            entity.Property(e => e.MaHh)
                .HasMaxLength(10)
                .HasColumnName("MaHH");
            entity.Property(e => e.TenHh)
                .HasMaxLength(50)
                .HasColumnName("TenHH");
        });
        modelBuilder.Entity<ChiTietGioHang>(entity =>
        {
            entity.HasKey(e => e.MaCTGH);

            entity.Property(e => e.MaCTGH)
                .ValueGeneratedOnAdd();

            entity.Property(e => e.MaKH)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.MaHH)
                .IsRequired()
                .HasMaxLength(10);

            for (int i = 1; i <= 50; i++)
            {
                entity.Property<int>($"HH{i:D2}")
                    .HasDefaultValue(0);
            }

            entity.Property(e => e.TongTien)
                .HasColumnType("decimal(18, 2)")
                .HasDefaultValue(0);

            entity.Property(e => e.PhuongThuc)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.DiaChi)
                .HasMaxLength(255);

            // Define foreign key relationship to KhachHang
            entity.HasOne(e => e.KhachHang)
                .WithMany(k => k.ChiTietGioHangs)
                .HasForeignKey(e => e.MaKH)
                .OnDelete(DeleteBehavior.Cascade);

            // Define foreign key relationship to HangHoa
            entity.HasOne(e => e.HangHoa)
                .WithMany(h => h.ChiTietGioHangs)
                .HasForeignKey(e => e.MaHH)
                .OnDelete(DeleteBehavior.Cascade);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
