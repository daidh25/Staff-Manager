using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace De_On_Tap_Kttx2_Lan1.Models;

public partial class QlthongTinContext : DbContext
{
    public QlthongTinContext()
    {
    }

    public QlthongTinContext(DbContextOptions<QlthongTinContext> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=Van-Hai-dz123\\SQLEXPRESS;Initial Catalog=QLThongTin;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv);

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNv)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MaNV");
            entity.Property(e => e.GioiTinh).HasMaxLength(50);
            entity.Property(e => e.HoTen).HasMaxLength(50);
            entity.Property(e => e.Hsluong).HasColumnName("HSLuong");
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.PhongBan).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
