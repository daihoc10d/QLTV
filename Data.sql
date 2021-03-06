USE [master]
GO
/****** Object:  Database [QLTHUVIEN]    Script Date: 10/30/2021 12:56:35 AM ******/
CREATE DATABASE [QLTHUVIEN]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTHUVIEN', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTHUVIEN.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLTHUVIEN_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLTHUVIEN_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLTHUVIEN] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTHUVIEN].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTHUVIEN] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTHUVIEN] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTHUVIEN] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTHUVIEN] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTHUVIEN] SET  MULTI_USER 
GO
ALTER DATABASE [QLTHUVIEN] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTHUVIEN] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTHUVIEN] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTHUVIEN] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLTHUVIEN] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLTHUVIEN] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTHUVIEN', N'ON'
GO
ALTER DATABASE [QLTHUVIEN] SET QUERY_STORE = OFF
GO
USE [QLTHUVIEN]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TenAccount] [varchar](20) NOT NULL,
	[MKAccount] [varchar](10) NULL,
	[MaNV] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTPhieuMuon]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTPhieuMuon](
	[MaPM] [varchar](10) NOT NULL,
	[MaTaiLieu] [varchar](10) NOT NULL,
	[NgayMuon] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[TinhTrang] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [varchar](10) NOT NULL,
	[TenDG] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[Lop] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](10) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [varchar](10) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[MaPM] [varchar](10) NOT NULL,
	[MaDG] [varchar](10) NOT NULL,
	[MaNV] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [varchar](10) NOT NULL,
	[TenTG] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiLieu]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiLieu](
	[MaTaiLieu] [varchar](10) NOT NULL,
	[TenTaiLieu] [nvarchar](50) NULL,
	[NamXB] [int] NULL,
	[MaTG] [varchar](10) NOT NULL,
	[MaTheLoai] [varchar](10) NOT NULL,
	[MaNXB] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 10/30/2021 12:56:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](10) NOT NULL,
	[TenTheLoai] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TenAccount], [MKAccount], [MaNV]) VALUES (N'admin', N'050701', N'NV01')
INSERT [dbo].[Account] ([TenAccount], [MKAccount], [MaNV]) VALUES (N'admin2', N'123456', N'NV02')
INSERT [dbo].[Account] ([TenAccount], [MKAccount], [MaNV]) VALUES (N'admin3', N'123456', N'NV03')
INSERT [dbo].[Account] ([TenAccount], [MKAccount], [MaNV]) VALUES (N'admin4', N'123456', N'NV04')
INSERT [dbo].[Account] ([TenAccount], [MKAccount], [MaNV]) VALUES (N'admin5', N'111111', N'NV05')
GO
INSERT [dbo].[CTPhieuMuon] ([MaPM], [MaTaiLieu], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM1', N'TL3', CAST(N'2021-04-04T00:00:00.000' AS DateTime), CAST(N'2021-04-26T00:00:00.000' AS DateTime), N'RÁCH NHẸ')
INSERT [dbo].[CTPhieuMuon] ([MaPM], [MaTaiLieu], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM2', N'TL4', CAST(N'2021-09-02T00:00:00.000' AS DateTime), CAST(N'2021-09-04T00:00:00.000' AS DateTime), N'CŨ')
INSERT [dbo].[CTPhieuMuon] ([MaPM], [MaTaiLieu], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM4', N'TL1', CAST(N'2021-09-02T00:00:00.000' AS DateTime), CAST(N'2021-09-10T00:00:00.000' AS DateTime), N'MỚI')
INSERT [dbo].[CTPhieuMuon] ([MaPM], [MaTaiLieu], [NgayMuon], [NgayTra], [TinhTrang]) VALUES (N'PM5', N'TL2', CAST(N'2021-02-15T00:00:00.000' AS DateTime), CAST(N'2021-04-04T00:00:00.000' AS DateTime), N'TỐT')
GO
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [Lop]) VALUES (N' DG6', N'Lý Mặc Sầu', CAST(N'2021-10-24T00:00:00.000' AS DateTime), N'Nữ', N'')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [Lop]) VALUES (N'DG1', N'Phạm Ngọc Hải', CAST(N'2001-05-05T00:00:00.000' AS DateTime), N'Nam', N'C1')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [Lop]) VALUES (N'DG2', N'Phạm Hải Ngọc', CAST(N'2003-06-07T00:00:00.000' AS DateTime), N'Nam', N'B5')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [Lop]) VALUES (N'DG3', N'Phạm Minh Hoang', CAST(N'2001-01-02T00:00:00.000' AS DateTime), N'Nam', N'A2')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [Lop]) VALUES (N'DG4', N'Nguyễn Thanh Hải', CAST(N'2012-11-12T00:00:00.000' AS DateTime), N'Nữ', N'D3')
INSERT [dbo].[DocGia] ([MaDG], [TenDG], [NgaySinh], [GioiTinh], [Lop]) VALUES (N'DG5', N'Nguyễn Thị Lý', CAST(N'2010-01-10T00:00:00.000' AS DateTime), N'Nữ', N'E1')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV01', N'Phùng Đại Học	', CAST(N'2021-12-13T00:00:00.000' AS DateTime), N'Nam', N'Q1', N'0123456789')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV02', N'Trịnh Dư Đạt', CAST(N'2021-11-03T00:00:00.000' AS DateTime), N'Nam', N'Q10', N'4444444')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV03', N'Nguyễn Văn Thiệt', CAST(N'2021-05-06T00:00:00.000' AS DateTime), N'Nam', N'Q11', N'7777777')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV04', N'Nguyễn Văn Qúy', CAST(N'2021-05-06T00:00:00.000' AS DateTime), N'Nam', N'Q11', N'7777777')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV05', N'Phùng Mạc Đề	', CAST(N'2021-12-13T00:00:00.000' AS DateTime), N'Nữ', N'Q8', N'0123456789')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV06', N'Trịnh Công Sơn', CAST(N'2021-11-03T00:00:00.000' AS DateTime), N'Nam', N'Q9', N'4444444')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [GioiTinh], [DiaChi], [SDT]) VALUES (N'NV07', N'Nguyễn Thị Hoa', CAST(N'2021-05-06T00:00:00.000' AS DateTime), N'Nữ', N'Q19', N'7777777')
GO
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'KD', N'Kim Đồng', N'Q3', N'111')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'ND', N'Nhân Dân', N'Q6', N'222')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'SG', N'Sài Gòn', N'Q1', N'444')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'TT', N'Tuổi Trẻ', N'Q1', N'333')
GO
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [MaNV]) VALUES (N'PM1', N'DG1', N'NV01')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [MaNV]) VALUES (N'PM2', N'DG2', N'NV02')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [MaNV]) VALUES (N'PM4', N'DG4', N'NV04')
INSERT [dbo].[PhieuMuon] ([MaPM], [MaDG], [MaNV]) VALUES (N'PM5', N'DG5', N'NV03')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'DS', N'Danh Sinh')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'GS', N'Giáo Sư')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'KB', N'Không biết')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'NC', N'Nam Cao')
INSERT [dbo].[TacGia] ([MaTG], [TenTG]) VALUES (N'TH', N'Tô Hoài')
GO
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [NamXB], [MaTG], [MaTheLoai], [MaNXB]) VALUES (N'TL1', N'Lập trình hướng đối tượng', 2010, N'KB', N'LT', N'ND')
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [NamXB], [MaTG], [MaTheLoai], [MaNXB]) VALUES (N'TL2', N'Nhập môn lập trình', 2011, N'GS', N'TL', N'TT')
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [NamXB], [MaTG], [MaTheLoai], [MaNXB]) VALUES (N'TL3', N'Kỹ Thuật Lập Trình', 2001, N'KB', N'GT', N'SG')
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [NamXB], [MaTG], [MaTheLoai], [MaNXB]) VALUES (N'TL4', N'Thiết Kế Phần Mềm', 2019, N'GS', N'LT', N'KD')
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [NamXB], [MaTG], [MaTheLoai], [MaNXB]) VALUES (N'TL5', N'Truyện Đô rê mon', 2002, N'KB', N'GT', N'KD')
GO
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'DS', N'Đời sống')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'GT', N'Giải trí')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'HH', N'Hài hước')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'LT', N'Lập trình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL', N'Tài liệu')
GO
ALTER TABLE [dbo].[TheLoai] ADD  DEFAULT (N'Tên thể loại') FOR [TenTheLoai]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD FOREIGN KEY([MaTaiLieu])
REFERENCES [dbo].[TaiLieu] ([MaTaiLieu])
GO
ALTER TABLE [dbo].[CTPhieuMuon]  WITH CHECK ADD FOREIGN KEY([MaPM])
REFERENCES [dbo].[PhieuMuon] ([MaPM])
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD FOREIGN KEY([MaDG])
REFERENCES [dbo].[DocGia] ([MaDG])
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[TaiLieu]  WITH CHECK ADD FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
GO
ALTER TABLE [dbo].[TaiLieu]  WITH CHECK ADD FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[TaiLieu]  WITH CHECK ADD FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
USE [master]
GO
ALTER DATABASE [QLTHUVIEN] SET  READ_WRITE 
GO
