using System;
using System.Collections.Generic;
using Car_Maintenance.Models;
using Microsoft.EntityFrameworkCore;

namespace Car_Maintenance.Data;

public partial class CarMaintenanceContext : DbContext
{
    public CarMaintenanceContext(DbContextOptions<CarMaintenanceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Baoduong> Baoduongs { get; set; }

    public virtual DbSet<Congviec> Congviecs { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<CT_BD> CT_BDs { get; set; }

    public virtual DbSet<Xe> Xes { get; set; }

    //Không cần để ý phần sau
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=NHANNA\\SQLEXPRESS01;Database=Car Maintenance;Trusted_Connection=True;TrustServerCertificate=True");

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Baoduong>(entity =>
        {
            entity.HasKey(e => e.Mabd);

            entity.ToTable("BAODUONG");

            entity.Property(e => e.Mabd)
                .HasMaxLength(10)
                .HasColumnName("MABD");
            entity.Property(e => e.Ngaygionhan)
                .HasMaxLength(10)
                .HasColumnName("NGAYGIONHAN");
            entity.Property(e => e.Ngaygiotra)
                .HasMaxLength(10)
                .HasColumnName("NGAYGIOTRA");
            entity.Property(e => e.Noidung)
                .HasMaxLength(100)
                .HasColumnName("NOIDUNG");
            entity.Property(e => e.Sokm)
                .HasMaxLength(20)
                .HasColumnName("SOKM");
            entity.Property(e => e.Soxe)
                .HasMaxLength(12)
                .HasColumnName("SOXE");

            entity.HasOne(d => d.SoxeNavigation).WithMany(p => p.Baoduongs)
                .HasForeignKey(d => d.Soxe)
                .HasConstraintName("FK_BAODUONG_XE");

        });
        modelBuilder.Entity<CT_BD>(entity =>
        {
            entity.HasOne(d => d.Baoduong).WithMany(p => p.CT_BDs)
                 .OnDelete(DeleteBehavior.ClientSetNull)
                 .HasConstraintName("FK_CT_BD_BAODUONG");

            entity.HasOne(d => d.Congviec).WithMany(p => p.CT_BDs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CT_BD_CONGVIEC");
        });


        modelBuilder.Entity<Congviec>(entity =>
        {
            entity.HasKey(e => e.Macv);

            entity.ToTable("CONGVIEC");

            entity.Property(e => e.Macv)
                .HasMaxLength(10)
                .HasColumnName("MACV");
            entity.Property(e => e.Dongia)
                .HasMaxLength(20)
                .HasColumnName("DONGIA");
            entity.Property(e => e.Tencv)
                .HasMaxLength(30)
                .HasColumnName("TENCV");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh);

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .HasColumnName("MAKH");
            entity.Property(e => e.Diachi)
                .HasMaxLength(40)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(12)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Hotenkh)
                .HasMaxLength(35)
                .HasColumnName("HOTENKH");
        });

        modelBuilder.Entity<Xe>(entity =>
        {
            entity.HasKey(e => e.Soxe);

            entity.ToTable("XE");

            entity.Property(e => e.Soxe)
                .HasMaxLength(12)
                .HasColumnName("SOXE");
            entity.Property(e => e.Hangxe)
                .HasMaxLength(20)
                .HasColumnName("HANGXE");
            entity.Property(e => e.Makh)
                .HasMaxLength(10)
                .HasColumnName("MAKH");
            entity.Property(e => e.Namsx)
                .HasMaxLength(5)
                .HasColumnName("NAMSX");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Xes)
                .HasForeignKey(d => d.Makh)
                .HasConstraintName("FK_XE_KHACHHANG");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
