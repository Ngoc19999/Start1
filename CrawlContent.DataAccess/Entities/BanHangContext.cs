//using System;
//using System.Collections.Generic;
//using Microsoft.EntityFrameworkCore;

//namespace CrawlContent.DataAccess.Entities;

//public partial class BanHangContext : DbContext
//{
//    public BanHangContext()
//    {
//    }

//    public BanHangContext(DbContextOptions<BanHangContext> options)
//        : base(options)
//    {
//    }

//    public virtual DbSet<GiaoDich> GiaoDiches { get; set; }

//    public virtual DbSet<GiaoDichMoi> GiaoDichMois { get; set; }

//    public virtual DbSet<KhachHang> KhachHangs { get; set; }

//    public virtual DbSet<KhachHangMoi> KhachHangMois { get; set; }

//    public virtual DbSet<KhoHang> KhoHangs { get; set; }

//    public virtual DbSet<KhoHangMoi> KhoHangMois { get; set; }

//    public virtual DbSet<SanPham> SanPhams { get; set; }

//    public virtual DbSet<SanPhamMoi> SanPhamMois { get; set; }

//    public virtual DbSet<TimTen> TimTens { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////#warning //To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=ADMIN\\KIEUNGOC;User ID=sa;Password=Ngoc1999;Database=BanHang;TrustServerCertificate=True;Trusted_Connection=False;");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.Entity<GiaoDich>(entity =>
//        {
//            entity.HasKey(e => e.Idgd).HasName("PK__GiaoDich__B770F600D651824D");

//            entity.ToTable("GiaoDich");

//            entity.Property(e => e.Giacuoi).HasColumnType("decimal(20, 0)");
//            entity.Property(e => e.Ngayban).HasColumnType("date");
//            entity.Property(e => e.TongGiamGia).HasColumnType("decimal(20, 0)");

//            entity.HasOne(d => d.IdkhNavigation).WithMany(p => p.GiaoDiches)
//                .HasForeignKey(d => d.Idkh)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK__GiaoDich__Idkh__5070F446");

//            entity.HasOne(d => d.IdspNavigation).WithMany(p => p.GiaoDiches)
//                .HasForeignKey(d => d.Idsp)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_Idsp");
//        });

//        modelBuilder.Entity<GiaoDichMoi>(entity =>
//        {
//            entity.HasKey(e => e.Idgd).HasName("PK__GiaoDich__B770F6000EE4F805");

//            entity.ToTable("GiaoDichMoi");

//            entity.Property(e => e.Giacuoi).HasColumnType("decimal(20, 0)");
//            entity.Property(e => e.Ngayban).HasColumnType("datetime");
//            entity.Property(e => e.TongGiamGia).HasColumnType("decimal(20, 0)");

//            entity.HasOne(d => d.IdkhNavigation).WithMany(p => p.GiaoDichMois)
//                .HasForeignKey(d => d.Idkh)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK__GiaoDichMo__Idkh__06CD04F7");

//            entity.HasOne(d => d.IdspNavigation).WithMany(p => p.GiaoDichMois)
//                .HasForeignKey(d => d.Idsp)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK__GiaoDichMo__Idsp__07C12930");
//        });

//        modelBuilder.Entity<KhachHang>(entity =>
//        {
//            entity.HasKey(e => e.Idkh).HasName("PK__KhachHan__B770D59946A4F356");

//            entity.ToTable("KhachHang");

//            entity.Property(e => e.Diachikh).HasMaxLength(100);
//            entity.Property(e => e.Sdtkh)
//                .HasMaxLength(15)
//                .IsUnicode(false);
//            entity.Property(e => e.Snhatkh).HasColumnType("date");
//            entity.Property(e => e.Tenkh).HasMaxLength(100);
//        });

//        modelBuilder.Entity<KhachHangMoi>(entity =>
//        {
//            entity.HasKey(e => e.Idkh).HasName("PK__KhachHan__B770D599AFAB8758");

//            entity.ToTable("KhachHangMoi");

//            entity.Property(e => e.Diachikh).HasMaxLength(200);
//            entity.Property(e => e.Sdtkh)
//                .HasMaxLength(20)
//                .IsUnicode(false);
//            entity.Property(e => e.Snhatkh).HasColumnType("date");
//            entity.Property(e => e.Tenkh).HasMaxLength(200);
//        });

//        modelBuilder.Entity<KhoHang>(entity =>
//        {
//            entity.HasKey(e => e.Idnhap).HasName("PK__KhoHang__E636A539B1FC2FED");

//            entity.ToTable("KhoHang");

//            entity.Property(e => e.Idnhap).HasColumnName("IDnhap");
//            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 0)");
//            entity.Property(e => e.NgayNhap).HasColumnType("date");

//            entity.HasOne(d => d.IdspNavigation).WithMany(p => p.KhoHangs)
//                .HasForeignKey(d => d.Idsp)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK_CustomerOrder");
//        });

//        modelBuilder.Entity<KhoHangMoi>(entity =>
//        {
//            entity.HasKey(e => e.Idnhap).HasName("PK__KhoHangM__E636A5391CFAF866");

//            entity.ToTable("KhoHangMoi");

//            entity.Property(e => e.Idnhap).HasColumnName("IDnhap");
//            entity.Property(e => e.DonGia).HasColumnType("decimal(20, 0)");
//            entity.Property(e => e.NgayNhap).HasColumnType("date");

//            entity.HasOne(d => d.IdspNavigation).WithMany(p => p.KhoHangMois)
//                .HasForeignKey(d => d.Idsp)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("FK__KhoHangMoi__Idsp__02FC7413");
//        });

//        modelBuilder.Entity<SanPham>(entity =>
//        {
//            entity.HasKey(e => e.IdSp).HasName("PK__SanPham__B77012A71461BDC8");

//            entity.ToTable("SanPham");

//            entity.Property(e => e.Dongia).HasColumnType("decimal(18, 0)");
//            entity.Property(e => e.Ngayhh).HasColumnType("date");
//            entity.Property(e => e.Ngaysx).HasColumnType("date");
//            entity.Property(e => e.TenSp).HasMaxLength(100);
//            entity.Property(e => e.Xuatxu).HasMaxLength(100);
//        });

//        modelBuilder.Entity<SanPhamMoi>(entity =>
//        {
//            entity.HasKey(e => e.IdSp).HasName("PK__SanPhamM__B77012A761C69E53");

//            entity.ToTable("SanPhamMoi");

//            entity.Property(e => e.Dongia).HasColumnType("decimal(20, 0)");
//            entity.Property(e => e.Ngayhh).HasColumnType("date");
//            entity.Property(e => e.Ngaysx).HasColumnType("date");
//            entity.Property(e => e.TenSp).HasMaxLength(200);
//            entity.Property(e => e.Xuatxu).HasMaxLength(200);
//        });

//        modelBuilder.Entity<TimTen>(entity =>
//        {
//            entity
//                .HasNoKey()
//                .ToTable("TimTen");

//            entity.Property(e => e.TenSp).HasMaxLength(100);
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//}
