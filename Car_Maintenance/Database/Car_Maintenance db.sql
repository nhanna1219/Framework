USE [master]
GO
/****** Object:  Database [Car Maintenance]    Script Date: 2/2/2023 10:34:42 AM ******/
CREATE DATABASE [Car Maintenance]
GO
ALTER DATABASE [Car Maintenance] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Car Maintenance].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Car Maintenance] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Car Maintenance] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Car Maintenance] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Car Maintenance] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Car Maintenance] SET ARITHABORT OFF 
GO
ALTER DATABASE [Car Maintenance] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Car Maintenance] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Car Maintenance] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Car Maintenance] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Car Maintenance] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Car Maintenance] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Car Maintenance] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Car Maintenance] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Car Maintenance] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Car Maintenance] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Car Maintenance] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Car Maintenance] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Car Maintenance] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Car Maintenance] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Car Maintenance] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Car Maintenance] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Car Maintenance] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Car Maintenance] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Car Maintenance] SET  MULTI_USER 
GO
ALTER DATABASE [Car Maintenance] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Car Maintenance] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Car Maintenance] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Car Maintenance] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Car Maintenance] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Car Maintenance] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Car Maintenance] SET QUERY_STORE = ON
GO
ALTER DATABASE [Car Maintenance] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Car Maintenance]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/2/2023 10:34:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAODUONG]    Script Date: 2/2/2023 10:34:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAODUONG](
	[MABD] [nvarchar](10) NOT NULL,
	[NGAYGIONHAN] [nvarchar](10) NULL,
	[NGAYGIOTRA] [nvarchar](10) NULL,
	[SOKM] [nvarchar](20) NULL,
	[NOIDUNG] [nvarchar](100) NULL,
	[SOXE] [nvarchar](12) NULL,
 CONSTRAINT [PK_BAODUONG] PRIMARY KEY CLUSTERED 
(
	[MABD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONGVIEC]    Script Date: 2/2/2023 10:34:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONGVIEC](
	[MACV] [nvarchar](10) NOT NULL,
	[TENCV] [nvarchar](30) NULL,
	[DONGIA] [int] NULL,
 CONSTRAINT [PK_CONGVIEC] PRIMARY KEY CLUSTERED 
(
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_BD]    Script Date: 2/2/2023 10:34:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_BD](
	[MABD] [nvarchar](10) NOT NULL,
	[MACV] [nvarchar](10) NOT NULL,
 CONSTRAINT [PK_CT_BD] PRIMARY KEY CLUSTERED 
(
	[MABD] ASC,
	[MACV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 2/2/2023 10:34:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [nvarchar](10) NOT NULL,
	[HOTENKH] [nvarchar](35) NULL,
	[DIACHI] [nvarchar](40) NULL,
	[DIENTHOAI] [nvarchar](12) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XE]    Script Date: 2/2/2023 10:34:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XE](
	[SOXE] [nvarchar](12) NOT NULL,
	[HANGXE] [nvarchar](20) NULL,
	[NAMSX] [nvarchar](5) NULL,
	[MAKH] [nvarchar](10) NULL,
 CONSTRAINT [PK_XE] PRIMARY KEY CLUSTERED 
(
	[SOXE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'1', N'12/12/2022', N'12/1/2023', N'3023', N'Bảo dưỡng toàn bộ xe', N'11')
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'2', N'1/1/2023', N'15/1/2023', N'1053', N'Sửa và làm sạch bô xe', N'12')
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'3', N'3/1/2023', N'4/1/2023', N'3245', N'Rửa xe', N'13')
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'4', N'10/1/2023', N'20/1/2023', N'2352', N'Bảo dưỡng bọc ghế ', N'11')
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'5', N'16/1/2023', N'', N'2322', N'Kiểm tra an toàn của xe', N'11')
INSERT [dbo].[BAODUONG] ([MABD], [NGAYGIONHAN], [NGAYGIOTRA], [SOKM], [NOIDUNG], [SOXE]) VALUES (N'6', N'23/1/2023', N'', N'3231', N'Kiểm tra nhớt xe', N'12')
GO
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'1', N'Rửa xe', 1000000)
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'2', N'Sửa xe', 50000000)
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'3', N'Bảo dưỡng xe', 21300000)
INSERT [dbo].[CONGVIEC] ([MACV], [TENCV], [DONGIA]) VALUES (N'4', N'Nâng cấp xe', 60000000)
GO
INSERT [dbo].[CT_BD] ([MABD], [MACV]) VALUES (N'1', N'2')
INSERT [dbo].[CT_BD] ([MABD], [MACV]) VALUES (N'2', N'2')
INSERT [dbo].[CT_BD] ([MABD], [MACV]) VALUES (N'2', N'3')
INSERT [dbo].[CT_BD] ([MABD], [MACV]) VALUES (N'4', N'3')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTENKH], [DIACHI], [DIENTHOAI]) VALUES (N'1', N'Nguyễn Trọng Nhân', N'UIT', N'09833345423')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTENKH], [DIACHI], [DIENTHOAI]) VALUES (N'2', N'Nguyễn Minh Khôi', N'UIT', N'09093748589')
INSERT [dbo].[KHACHHANG] ([MAKH], [HOTENKH], [DIACHI], [DIENTHOAI]) VALUES (N'3', N'Nguyễn Quốc Khánh', N'UIT', N'09073481282')
GO
INSERT [dbo].[XE] ([SOXE], [HANGXE], [NAMSX], [MAKH]) VALUES (N'11', N'Honda', N'2021', N'1')
INSERT [dbo].[XE] ([SOXE], [HANGXE], [NAMSX], [MAKH]) VALUES (N'12', N'Yamaha', N'2021', N'2')
INSERT [dbo].[XE] ([SOXE], [HANGXE], [NAMSX], [MAKH]) VALUES (N'13', N'Toyota', N'2021', N'3')
GO
ALTER TABLE [dbo].[BAODUONG]  WITH CHECK ADD  CONSTRAINT [FK_BAODUONG_XE] FOREIGN KEY([SOXE])
REFERENCES [dbo].[XE] ([SOXE])
GO
ALTER TABLE [dbo].[BAODUONG] CHECK CONSTRAINT [FK_BAODUONG_XE]
GO
ALTER TABLE [dbo].[CT_BD]  WITH CHECK ADD  CONSTRAINT [FK_CT_BD_BAODUONG] FOREIGN KEY([MABD])
REFERENCES [dbo].[BAODUONG] ([MABD])
GO
ALTER TABLE [dbo].[CT_BD] CHECK CONSTRAINT [FK_CT_BD_BAODUONG]
GO
ALTER TABLE [dbo].[CT_BD]  WITH CHECK ADD  CONSTRAINT [FK_CT_BD_CONGVIEC] FOREIGN KEY([MACV])
REFERENCES [dbo].[CONGVIEC] ([MACV])
GO
ALTER TABLE [dbo].[CT_BD] CHECK CONSTRAINT [FK_CT_BD_CONGVIEC]
GO
ALTER TABLE [dbo].[XE]  WITH CHECK ADD  CONSTRAINT [FK_XE_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[XE] CHECK CONSTRAINT [FK_XE_KHACHHANG]
GO
USE [master]
GO
ALTER DATABASE [Car Maintenance] SET  READ_WRITE 
GO
