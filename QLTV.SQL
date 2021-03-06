USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 7/2/2018 11:12:45 AM ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTV] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTV', N'ON'
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[tblBaoCaoMuonSachTheTheLoai]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBaoCaoMuonSachTheTheLoai](
	[mabaocaotinhhinhmuonsachtheotheloai] [int] NOT NULL,
	[thangbaocao] [date] NULL,
	[tongsoluotmuon] [int] NULL,
 CONSTRAINT [PK_tblBaoCaoMuonSachTheTheLoai] PRIMARY KEY CLUSTERED 
(
	[mabaocaotinhhinhmuonsachtheotheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai](
	[mabaocaochitiettinhhinhmuonsachtheotheloai] [int] NOT NULL,
	[soluotmuon] [int] NULL,
	[tile] [float] NULL,
	[mabaocaotinhhinhmuonsachtheotheloai] [int] NULL,
	[matheloaisach] [int] NULL,
 CONSTRAINT [PK_tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai] PRIMARY KEY CLUSTERED 
(
	[mabaocaochitiettinhhinhmuonsachtheotheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChiTietPhieuMuonSach]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietPhieuMuonSach](
	[machitietphieumuonsach] [nvarchar](50) NOT NULL,
	[masach] [nvarchar](50) NULL,
	[maphieumuonsach] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblChiTietPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[machitietphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDocGia]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDocGia](
	[madocgia] [nvarchar](50) NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[maloaidocgia] [int] NULL,
	[ngaysinh] [datetime2](7) NULL,
	[diachi] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[ngaylapthe] [datetime2](7) NULL,
	[ngayhethan] [datetime2](7) NULL,
 CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 
(
	[madocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaiDocGia]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaiDocGia](
	[maloaidocgia] [int] NOT NULL,
	[tenloaidocgia] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuMuonSach]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuMuonSach](
	[maphieumuonsach] [nvarchar](50) NOT NULL,
	[ngaymuonsach] [datetime2](7) NULL,
	[madocgia] [nvarchar](50) NULL,
	[ngaytrasach] [datetime2](7) NULL,
 CONSTRAINT [PK_tblPhieuMuonSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuTraSach]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuTraSach](
	[maphieumuonsach] [nvarchar](50) NOT NULL,
	[ngaytrasach] [datetime2](7) NULL,
 CONSTRAINT [PK_tblPhieuTraSach] PRIMARY KEY CLUSTERED 
(
	[maphieumuonsach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuyDinh]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuyDinh](
	[id] [int] NOT NULL,
	[tuoitoithieu] [int] NOT NULL,
	[tuoitoida] [int] NOT NULL,
	[thoihansudung] [int] NOT NULL,
	[khoangcachxuatban] [int] NOT NULL,
	[songaymuontoida] [int] NOT NULL,
	[sosachmuontoida] [int] NOT NULL,
 CONSTRAINT [PK_tblQuyDinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[masach] [nvarchar](50) NOT NULL,
	[tensach] [nvarchar](50) NULL,
	[matheloaisach] [int] NULL,
	[matacgia] [int] NULL,
	[namxuatban] [int] NULL,
	[nhaxuatban] [nvarchar](50) NULL,
	[ngaynhap] [datetime2](7) NULL,
	[trigia] [int] NULL,
	[tinhtrangsach] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTacGia]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTacGia](
	[matacgia] [int] NOT NULL,
	[tentacgia] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTacGia2] PRIMARY KEY CLUSTERED 
(
	[matacgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTheLoaiSach]    Script Date: 7/2/2018 11:12:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTheLoaiSach](
	[matheloaisach] [int] NOT NULL,
	[tentheloaisach] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblTheLoaiSach] PRIMARY KEY CLUSTERED 
(
	[matheloaisach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChiTietPhieuMuonSach] ([machitietphieumuonsach], [masach], [maphieumuonsach]) VALUES (N'180003', N'1003', N'180003')
INSERT [dbo].[tblChiTietPhieuMuonSach] ([machitietphieumuonsach], [masach], [maphieumuonsach]) VALUES (N'180004', N'1004', N'180003')
INSERT [dbo].[tblChiTietPhieuMuonSach] ([machitietphieumuonsach], [masach], [maphieumuonsach]) VALUES (N'180005', N'1008', N'180003')
INSERT [dbo].[tblChiTietPhieuMuonSach] ([machitietphieumuonsach], [masach], [maphieumuonsach]) VALUES (N'180006', N'1009', N'180003')
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000000', N'Đỗ Thành Nhân', 1, CAST(N'1999-06-25T00:00:00.0000000' AS DateTime2), N'Dĩ An, Bình Dương', N'nhan123@gmail.com', CAST(N'2009-06-25T00:00:00.0000000' AS DateTime2), CAST(N'2009-12-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000001', N'Đỗ Thành Lộc', 1, CAST(N'1998-06-25T21:45:23.0000000' AS DateTime2), N'B11/17', N'loc@gmail.com', CAST(N'2018-06-25T00:00:00.0000000' AS DateTime2), CAST(N'2018-12-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000002', N'Lê Khắc Hậu Linh', 1, CAST(N'1998-06-25T22:08:19.0000000' AS DateTime2), N'B11/17', N'haulinhlk@gmail.com', CAST(N'2009-06-25T00:00:00.0000000' AS DateTime2), CAST(N'2018-12-25T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000003', N'Nguyễn Văn Năm', 2, CAST(N'1992-07-02T10:24:56.0000000' AS DateTime2), N'HCM', N'vannam@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000004', N'Lê Đình Huy', 3, CAST(N'1994-07-02T10:26:03.0000000' AS DateTime2), N'Hà Nội', N'dinhhuy@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000005', N'Nguyễn Văn Tèo', 5, CAST(N'1997-07-02T10:26:37.0000000' AS DateTime2), N'Bình Dương', N'cuteo@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000006', N'Đỗ Văn Nam', 1, CAST(N'1998-07-02T10:27:10.0000000' AS DateTime2), N'An Giang', N'vannam@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000007', N'Đỗ Văn Toàn', 7, CAST(N'1998-07-02T10:27:10.0000000' AS DateTime2), N'Ninh Bình', N'vantoan@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000008', N'Lương Gia Huy', 8, CAST(N'1992-07-02T10:27:10.0000000' AS DateTime2), N'Vũng Tàu', N'giahuy@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000009', N'Doãn Chí Bình', 11, CAST(N'1992-07-02T10:27:10.0000000' AS DateTime2), N'Toàn Chân Giáo', N'chibinh@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblDocGia] ([madocgia], [hoten], [maloaidocgia], [ngaysinh], [diachi], [email], [ngaylapthe], [ngayhethan]) VALUES (N'18000010', N'Lê Bảo Bình', 2, CAST(N'1990-07-05T10:27:10.0000000' AS DateTime2), N'An Giang', N'baobinh@gmail.com', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), CAST(N'2019-01-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (1, N'Học sinh')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (2, N'Giáo viên')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (3, N'Giám đốc')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (4, N'Coder ')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (5, N'culi')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (6, N'Leader')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (7, N'Project Manager')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (8, N'Product')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (9, N'IT helper')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (10, N'Player')
INSERT [dbo].[tblLoaiDocGia] ([maloaidocgia], [tenloaidocgia]) VALUES (11, N'Ngoại giao ')
INSERT [dbo].[tblPhieuMuonSach] ([maphieumuonsach], [ngaymuonsach], [madocgia], [ngaytrasach]) VALUES (N'180001', CAST(N'2018-06-25T00:00:00.0000000' AS DateTime2), N'18000001', CAST(N'2018-06-29T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuMuonSach] ([maphieumuonsach], [ngaymuonsach], [madocgia], [ngaytrasach]) VALUES (N'180002', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), N'18000002', CAST(N'2018-07-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuMuonSach] ([maphieumuonsach], [ngaymuonsach], [madocgia], [ngaytrasach]) VALUES (N'180003', CAST(N'2018-07-02T00:00:00.0000000' AS DateTime2), N'18000001', CAST(N'2018-07-06T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[tblPhieuTraSach] ([maphieumuonsach], [ngaytrasach]) VALUES (N'180001', CAST(N'2018-07-02T10:12:04.1830000' AS DateTime2))
INSERT [dbo].[tblPhieuTraSach] ([maphieumuonsach], [ngaytrasach]) VALUES (N'180002', CAST(N'2018-07-02T10:09:33.8330000' AS DateTime2))
INSERT [dbo].[tblPhieuTraSach] ([maphieumuonsach], [ngaytrasach]) VALUES (N'180003', CAST(N'2018-06-30T10:36:04.0000000' AS DateTime2))
INSERT [dbo].[tblQuyDinh] ([id], [tuoitoithieu], [tuoitoida], [thoihansudung], [khoangcachxuatban], [songaymuontoida], [sosachmuontoida]) VALUES (1, 18, 35, 6, 8, 4, 5)
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1000', N'Trà Hoa Nữ', 1, 2, 2002, N'iran', CAST(N'2018-06-25T10:06:00.7730000' AS DateTime2), 300000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1001', N'tình yêu xxxx', 1, 3, 2002, N'Pháp', CAST(N'2018-06-27T20:36:16.1730000' AS DateTime2), 1230000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1002', N'tình yêu abc', 1, 1, 2016, N'Thiên Triều', CAST(N'2018-06-27T23:20:57.5830000' AS DateTime2), 123, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1003', N'tình yêu', 3, 15, 2017, N'Kim Đồng', CAST(N'2018-06-30T17:19:00.4430000' AS DateTime2), 123000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1004', N'Chí Phèo', 3, 3, 2014, N'a', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 60000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1005', N'Giông Tố', 3, 10, 2015, N'Kim Đồng', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 120000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1006', N'Harry Potter', 3, 5, 2013, N'Nhà Xuất Bản Trẻ', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 80000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1007', N'Nhập Môn Lập Trình', 5, 0, 2013, N'ĐHQG', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 50000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1008', N'Xin lỗi em chỉ là con đĩ', 3, 17, 2013, N'Văn Học', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 60000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1009', N'Nhập môn công nghệ', 8, 10, 2013, N'Công Nghiêpj', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 15000, N'Chưa được mượn')
INSERT [dbo].[tblSach] ([masach], [tensach], [matheloaisach], [matacgia], [namxuatban], [nhaxuatban], [ngaynhap], [trigia], [tinhtrangsach]) VALUES (N'1010', N'Nhập môn game', 5, 0, 2015, N'ĐHQG', CAST(N'2018-07-02T10:16:31.8430000' AS DateTime2), 20000, N'Chưa được mượn')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (0, N'Không có')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (1, N'Xuân Diệu')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (2, N'Hồ Xuân Hương')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (3, N'Văn Cao')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (4, N'Nguyễn Nhật Ánh ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (5, N'Alexandre Dumas')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (6, N'Beatles')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (7, N'Gary Chapman')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (8, N'Masaru Emoto')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (9, N'Trang Hạ')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (10, N'Nguyễn Phong Việt')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (11, N'Anh Khang')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (12, N'Sơn Paris')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (13, N'Nguyễn Ngọc Thạch')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (14, N'Đỗ Nhật Nam')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (15, N'Hamlet Trương')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (16, N'Phạm Huy Hoàng')
INSERT [dbo].[tblTacGia] ([matacgia], [tentacgia]) VALUES (17, N'Thích Nhất Hạnh')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (0, N'Không có')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (1, N'Ngôn tình ')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (2, N'Khoa học ')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (3, N'Văn học')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (4, N'Kinh tế')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (5, N'Tin học')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (6, N'Tự Nhiên')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (7, N'Nông Nghiệp')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (8, N'Công Nghiệp')
INSERT [dbo].[tblTheLoaiSach] ([matheloaisach], [tentheloaisach]) VALUES (9, N'Thủ Công')
ALTER TABLE [dbo].[tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai_tblBaoCaoMuonSachTheTheLoai] FOREIGN KEY([mabaocaotinhhinhmuonsachtheotheloai])
REFERENCES [dbo].[tblBaoCaoMuonSachTheTheLoai] ([mabaocaotinhhinhmuonsachtheotheloai])
GO
ALTER TABLE [dbo].[tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai] CHECK CONSTRAINT [FK_tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai_tblBaoCaoMuonSachTheTheLoai]
GO
ALTER TABLE [dbo].[tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai_tblTheLoaiSach] FOREIGN KEY([matheloaisach])
REFERENCES [dbo].[tblTheLoaiSach] ([matheloaisach])
GO
ALTER TABLE [dbo].[tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai] CHECK CONSTRAINT [FK_tblChiTietBaoCaoTinhHinhMuonSachTheoTheLoai_tblTheLoaiSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuonSach_tblPhieuMuonSach] FOREIGN KEY([maphieumuonsach])
REFERENCES [dbo].[tblPhieuMuonSach] ([maphieumuonsach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuonSach] CHECK CONSTRAINT [FK_tblChiTietPhieuMuonSach_tblPhieuMuonSach]
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuonSach]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietPhieuMuonSach_tblSach] FOREIGN KEY([masach])
REFERENCES [dbo].[tblSach] ([masach])
GO
ALTER TABLE [dbo].[tblChiTietPhieuMuonSach] CHECK CONSTRAINT [FK_tblChiTietPhieuMuonSach_tblSach]
GO
ALTER TABLE [dbo].[tblDocGia]  WITH CHECK ADD  CONSTRAINT [FK_tblDocGia_tblLoaiDocGia] FOREIGN KEY([maloaidocgia])
REFERENCES [dbo].[tblLoaiDocGia] ([maloaidocgia])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblDocGia] CHECK CONSTRAINT [FK_tblDocGia_tblLoaiDocGia]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblTacGia] FOREIGN KEY([matacgia])
REFERENCES [dbo].[tblTacGia] ([matacgia])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblTacGia]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblTheLoaiSach] FOREIGN KEY([matheloaisach])
REFERENCES [dbo].[tblTheLoaiSach] ([matheloaisach])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblTheLoaiSach]
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
