// <auto-generated />
using Car_Maintenance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarMaintenance.Migrations
{
    [DbContext(typeof(CarMaintenanceContext))]
    [Migration("20230120032146_intialDB")]
    partial class intialDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Car_Maintenance.Models.Baoduong", b =>
                {
                    b.Property<string>("Mabd")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MABD");

                    b.Property<string>("Ngaygionhan")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NGAYGIONHAN");

                    b.Property<string>("Ngaygiotra")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NGAYGIOTRA");

                    b.Property<string>("Noidung")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOIDUNG");

                    b.Property<string>("Sokm")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("SOKM");

                    b.Property<string>("Soxe")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("SOXE");

                    b.HasKey("Mabd");

                    b.HasIndex("Soxe");

                    b.ToTable("BAODUONG", (string)null);
                });

            modelBuilder.Entity("Car_Maintenance.Models.Congviec", b =>
                {
                    b.Property<string>("Macv")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MACV");

                    b.Property<string>("Dongia")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("DONGIA");

                    b.Property<string>("Tencv")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("TENCV");

                    b.HasKey("Macv");

                    b.ToTable("CONGVIEC", (string)null);
                });

            modelBuilder.Entity("Car_Maintenance.Models.Khachhang", b =>
                {
                    b.Property<string>("Makh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MAKH");

                    b.Property<string>("Diachi")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("DIACHI");

                    b.Property<string>("Dienthoai")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("DIENTHOAI");

                    b.Property<string>("Hotenkh")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasColumnName("HOTENKH");

                    b.HasKey("Makh");

                    b.ToTable("KHACHHANG", (string)null);
                });

            modelBuilder.Entity("Car_Maintenance.Models.Xe", b =>
                {
                    b.Property<string>("Soxe")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)")
                        .HasColumnName("SOXE");

                    b.Property<string>("Hangxe")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("HANGXE");

                    b.Property<string>("Makh")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("MAKH");

                    b.Property<string>("Namsx")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)")
                        .HasColumnName("NAMSX");

                    b.HasKey("Soxe");

                    b.HasIndex("Makh");

                    b.ToTable("XE", (string)null);
                });

            modelBuilder.Entity("CtBd", b =>
                {
                    b.Property<string>("Mabd")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Macv")
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Mabd", "Macv");

                    b.HasIndex("Macv");

                    b.ToTable("CT_BD", (string)null);
                });

            modelBuilder.Entity("Car_Maintenance.Models.Baoduong", b =>
                {
                    b.HasOne("Car_Maintenance.Models.Xe", "SoxeNavigation")
                        .WithMany("Baoduongs")
                        .HasForeignKey("Soxe")
                        .HasConstraintName("FK_BAODUONG_XE");

                    b.Navigation("SoxeNavigation");
                });

            modelBuilder.Entity("Car_Maintenance.Models.Xe", b =>
                {
                    b.HasOne("Car_Maintenance.Models.Khachhang", "MakhNavigation")
                        .WithMany("Xes")
                        .HasForeignKey("Makh")
                        .HasConstraintName("FK_XE_KHACHHANG");

                    b.Navigation("MakhNavigation");
                });

            modelBuilder.Entity("CtBd", b =>
                {
                    b.HasOne("Car_Maintenance.Models.Baoduong", null)
                        .WithMany()
                        .HasForeignKey("Mabd")
                        .IsRequired()
                        .HasConstraintName("FK_CT_BD_BAODUONG");

                    b.HasOne("Car_Maintenance.Models.Congviec", null)
                        .WithMany()
                        .HasForeignKey("Macv")
                        .IsRequired()
                        .HasConstraintName("FK_CT_BD_CONGVIEC");
                });

            modelBuilder.Entity("Car_Maintenance.Models.Khachhang", b =>
                {
                    b.Navigation("Xes");
                });

            modelBuilder.Entity("Car_Maintenance.Models.Xe", b =>
                {
                    b.Navigation("Baoduongs");
                });
#pragma warning restore 612, 618
        }
    }
}
