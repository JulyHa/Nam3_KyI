CREATE DATABASE [QLGiaoTrinh]
USE [QLGiaoTrinh]
GO
/****** Object:  Table [dbo].[ThuThu]    Script Date: 13/11/2021 6:33:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuThu](
	[MaThuThu] [nchar](10) NOT NULL,
	[TenThuThu] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[DienThoaiCD] [nchar](15) NOT NULL,
	[DienThoaiDD] [nchar](15) NULL,
	[MaQue] [nchar](10) NOT NULL,
 CONSTRAINT [PK_ThuThu] PRIMARY KEY CLUSTERED 
(
	[MaThuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Que]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Que](
	[MaQue] [nchar](10) NOT NULL,
	[TenQue] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Que] PRIMARY KEY CLUSTERED 
(
	[MaQue] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DSThuThu]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DSThuThu] as
select MaThuThu,TenThuThu,DiaChi,DienThoaiCD,DienThoaiDD,TenQue
from ThuThu join Que on ThuThu.MaQue=Que.MaQue
GO
/****** Object:  Table [dbo].[HoSoTra]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoTra](
	[MaHSTra] [nchar](10) NOT NULL,
	[MaHSM] [nchar](10) NOT NULL,
	[NgayTra] [date] NOT NULL,
	[TongTienPhat] [money] NOT NULL,
	[NgayNopPhat] [date] NULL,
	[MaThuThu] [nchar](10) NOT NULL,
 CONSTRAINT [PK_HoSoTra] PRIMARY KEY CLUSTERED 
(
	[MaHSTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHSTra]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHSTra](
	[MaHSTra] [nchar](10) NOT NULL,
	[MaGT] [nchar](10) NOT NULL,
	[MaViPham] [nchar](10) NULL,
	[MaPhat] [nchar](10) NULL,
 CONSTRAINT [PK_ChiTietHSTra] PRIMARY KEY CLUSTERED 
(
	[MaHSTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[DSThuThu_Nhan_HSTra]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DSThuThu_Nhan_HSTra] as
select ThuThu.MaThuThu, TenThuThu, HoSoTra.MaHSTra,NgayTra
from ThuThu join HoSoTra on ThuThu.MaThuThu=HoSoTra.MaThuThu join ChiTietHSTra on ChiTietHSTra.MaHSTra=HoSoTra.MaHSTra
	
GO
/****** Object:  Table [dbo].[ChiTietHSMuon]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHSMuon](
	[MaHSM] [nchar](10) NOT NULL,
	[MaGT] [nchar](10) NOT NULL,
	[ChuaTra] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_ChiTietHSMuon] PRIMARY KEY CLUSTERED 
(
	[MaHSM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenNganh]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenNganh](
	[MaChuyenNganh] [nchar](10) NOT NULL,
	[TenChuyenNganh] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ChuyenNganh] PRIMARY KEY CLUSTERED 
(
	[MaChuyenNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DMGiaoTrinh]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DMGiaoTrinh](
	[MaGT] [nchar](10) NOT NULL,
	[TenGT] [nvarchar](250) NOT NULL,
	[MaTG] [nchar](10) NOT NULL,
	[NamXB] [int] NOT NULL,
	[LanTB] [int] NOT NULL,
	[MaChuyenNganh] [nchar](10) NOT NULL,
	[SoTrang] [int] NULL,
	[TomTatNoiDung] [nvarchar](250) NULL,
	[SoLuongGT] [int] NOT NULL,
 CONSTRAINT [PK_DMGiaoTrinh] PRIMARY KEY CLUSTERED 
(
	[MaGT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoSoMuon]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoMuon](
	[MaHSM] [nchar](10) NOT NULL,
	[MaThe] [nchar](20) NOT NULL,
	[MaThuThu] [nchar](10) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayPhaiTra] [date] NOT NULL,
	[TrinhTrangMuon] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_HoSoMuon] PRIMARY KEY CLUSTERED 
(
	[MaHSM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nchar](10) NOT NULL,
	[TenKhoa] [nvarchar](50) NOT NULL,
	[DienThoai] [nvarchar](15) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nchar](10) NOT NULL,
	[TenLop] [nvarchar](50) NOT NULL,
	[MaKhoa] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phat]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phat](
	[MaPhat] [nchar](10) NOT NULL,
	[TienPhat] [money] NOT NULL,
 CONSTRAINT [PK_Phat] PRIMARY KEY CLUSTERED 
(
	[MaPhat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [nchar](10) NOT NULL,
	[TenTG] [nvarchar](50) NOT NULL,
	[MaKhoa] [nchar](10) NOT NULL,
	[NamSinh] [nchar](4) NULL,
	[MaTrinhDo] [nchar](10) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheMuon]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheMuon](
	[MaThe] [nchar](20) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[MaLop] [nchar](10) NOT NULL,
	[MaKhoa] [nchar](10) NOT NULL,
	[KhoaThe] [nvarchar](10) NOT NULL,
	[SoLuongMuon] [int] NOT NULL,
 CONSTRAINT [PK_TheMuon] PRIMARY KEY CLUSTERED 
(
	[MaThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[MaTrinhDo] [nchar](10) NOT NULL,
	[TenTrinhDo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[MaTrinhDo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViPham]    Script Date: 13/11/2021 6:33:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViPham](
	[MaViPham] [nchar](10) NOT NULL,
	[TenViPham] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ViPham] PRIMARY KEY CLUSTERED 
(
	[MaViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM01     ', N'GT07      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM02     ', N'GT14      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM03     ', N'GT03      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM04     ', N'GT01      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM05     ', N'GT02      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM06     ', N'GT04      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM07     ', N'GT03      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM08     ', N'GT12      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM09     ', N'GT08      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM10     ', N'GT04      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM11     ', N'GT09      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM12     ', N'GT07      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM13     ', N'GT05      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM14     ', N'GT13      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM15     ', N'GT06      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM16     ', N'GT01      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM17     ', N'GT06      ', N'Chưa')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM18     ', N'GT12      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM19     ', N'GT02      ', N'Rồi')
INSERT [dbo].[ChiTietHSMuon] ([MaHSM], [MaGT], [ChuaTra]) VALUES (N'HSM20     ', N'GT03      ', N'Chưa')
GO
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST01     ', N'GT01      ', NULL, NULL)
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST02     ', N'GT04      ', NULL, NULL)
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST03     ', N'GT03      ', N'VP01      ', N'P03       ')
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST04     ', N'GT07      ', N'VP02      ', N'P01       ')
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST05     ', N'GT13      ', N'VP01,VP03 ', N'P02, P03  ')
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST06     ', N'GT05      ', NULL, NULL)
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST07     ', N'GT09      ', N'VP01      ', N'P02       ')
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST09     ', N'GT12      ', NULL, NULL)
INSERT [dbo].[ChiTietHSTra] ([MaHSTra], [MaGT], [MaViPham], [MaPhat]) VALUES (N'HST10     ', N'GT01      ', N'VP01      ', N'P03       ')
GO
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN01      ', N'Khoa học máy tính')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN02      ', N'Kết cấu xây dựng')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN03      ', N'Kỹ thuật điện')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN04      ', N'Toán Giải tích')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN05      ', N'Kinh tế vận tải và du lịch')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN06      ', N'Đại số và XSTK')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN07      ', N'Vật lý')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN08      ', N'Vận tải và Kinh tế đường sắt')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN09      ', N'Kế toán - Kiểm toán')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN10      ', N'Trắc địa')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN11      ', N'Vật liệu xây dựng')
INSERT [dbo].[ChuyenNganh] ([MaChuyenNganh], [TenChuyenNganh]) VALUES (N'CN12      ', N'Hình họa-Vẽ kĩ thuật')
GO
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT01      ', N'Tin học đại cương', N'TG01      ', 2017, 1, N'CN01      ', 105, N'Đại cương về tin học; Ngôn ngữ lập trình C', 60)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT02      ', N'Sức bền vật liệu', N'TG04      ', 2006, 1, N'CN02      ', 245, N'Gồm 9 chương', 870)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT03      ', N'Đại số tuyến tính', N'TG06      ', 2017, 1, N'CN06      ', 350, N'Ma trận và định thức; Hệ phương trình tuyến tính; Không gian tuyến tính; Ánh xạ tuyến tính; Không gian euclid', 515)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT04      ', N'Giải tích', N'TG03      ', 2012, 2, N'CN04      ', 325, N'Giải tích 1', 510)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT05      ', N'Giải tích số', N'TG05      ', 2007, 1, N'CN01      ', 150, NULL, 160)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT06      ', N'Vật lý', N'TG07      ', 2015, 1, N'CN07      ', 275, N'Động học; Động lực học; Cơ năng; Nhiệt động lực học; Trạng thái lỏng và biến đổi pha; Trường tĩnh điện; Từ trường và trường điện từ; Quang học; Vật lý kỹ thuật
', 160)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT07      ', N'Điều tra kinh tế', N'TG08      ', 2019, 1, N'CN05      ', 160, N'Tổng quan về điều tra kinh tế. Phương pháp luận của điều tra kinh tế. Điều tra kinh tế trong quản lý và quy hoạch. Phương pháp điều tra và xử lý - phân tích dữ liệu điều tra', 111)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT08      ', N'Tài chính doanh nghiệp', N'TG09      ', 2020, 1, N'CN08      ', 216, N'ổng quan về tài chính doanh nghiệp; Chi phí doanh thu và lợi nhuận; Vốn kinh doanh của doanh nghiệp...
', 110)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT09      ', N'Kế toán doanh nghiệp vận tải', N'TG09      ', 2017, 1, N'CN09      ', 215, N'Tổ chức công tác kế toán trong doanh nghiệp vận tải; Kế toán vốn bằng tiền, đầu tư ngắn hạn, các khoản phỉa thu...', 90)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT10      ', N'Xác suất thống kê', N'TG05      ', 2017, 2, N'CN06      ', 219, N'Cơ sở của lý thuyết xác suất; Thống kê mô tả và phân phối mẫu; Lý thuyết ước lượng; Kiểm định giả thuyết thống kê, Hồi quy và tương quan
', 410)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT11      ', N'Trắc địa đại cương', N'TG11      ', 2016, 1, N'CN10      ', 156, N'Những khái niệm cơ bản trong trắc địa; Sai số đo, Đo các đại lượng cơ bản trong trắc địa; Các thiết bị đo đạc hiện đại; Lưới khống chế trắc địa; Phương pháp thành lập và sử dụng bản đồ địa hình', 360)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT12      ', N'Vật liệu xây dựng', N'TG12      ', 2011, 2, N'CN11      ', 160, NULL, 500)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT13      ', N'Vẽ kỹ thuật cơ khí', N'TG13      ', 2018, 1, N'CN12      ', 220, N'Vật liệu và dụng cụ vẽ; Những tiêu chuẩn về trình bày bản vẽ kỹ thuật; Vẽ hình học; Các phép chiếu; Hình chiếu vuông góc; Hình cắt - mặt cắt - hình trích;..
', 210)
INSERT [dbo].[DMGiaoTrinh] ([MaGT], [TenGT], [MaTG], [NamXB], [LanTB], [MaChuyenNganh], [SoTrang], [TomTatNoiDung], [SoLuongGT]) VALUES (N'GT14      ', N'Kỹ thuật điện', N'TG14      ', 2000, 2, N'CN03      ', 190, NULL, 310)
GO
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM01     ', N'T03                 ', N'TT02      ', CAST(N'2021-03-04' AS Date), CAST(N'2021-06-04' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM02     ', N'T07                 ', N'TT05      ', CAST(N'2021-09-06' AS Date), CAST(N'2021-12-08' AS Date), N'Đang mượn')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM03     ', N'T01                 ', N'TT03      ', CAST(N'2021-03-01' AS Date), CAST(N'2021-06-01' AS Date), N'Chưa trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM04     ', N'T09                 ', N'TT01      ', CAST(N'2021-01-08' AS Date), CAST(N'2021-05-28' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM05     ', N'T06                 ', N'TT02      ', CAST(N'2021-01-22' AS Date), CAST(N'2021-04-23' AS Date), N'Chưa trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM06     ', N'T02                 ', N'TT04      ', CAST(N'2021-01-29' AS Date), CAST(N'2021-04-26' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM07     ', N'T10                 ', N'TT02      ', CAST(N'2021-02-03' AS Date), CAST(N'2021-05-28' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM08     ', N'T04                 ', N'TT06      ', CAST(N'2021-10-01' AS Date), CAST(N'2022-01-20' AS Date), N'Đang mượn')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM09     ', N'T11                 ', N'TT03      ', CAST(N'2021-10-15' AS Date), CAST(N'2022-01-28' AS Date), N'Đang mượn')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM10     ', N'T05                 ', N'TT04      ', CAST(N'2021-09-24' AS Date), CAST(N'2022-01-24' AS Date), N'Đang mượn')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM11     ', N'T08                 ', N'TT01      ', CAST(N'2021-09-08' AS Date), CAST(N'2021-11-08' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM12     ', N'T12                 ', N'TT05      ', CAST(N'2021-04-07' AS Date), CAST(N'2021-06-07' AS Date), N'Chưa trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM13     ', N'T09                 ', N'TT03      ', CAST(N'2021-04-01' AS Date), CAST(N'2021-08-27' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM14     ', N'T10                 ', N'TT02      ', CAST(N'2021-04-05' AS Date), CAST(N'2021-06-25' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM15     ', N'T03                 ', N'TT06      ', CAST(N'2021-04-26' AS Date), CAST(N'2021-06-30' AS Date), N'Chưa trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM16     ', N'T08                 ', N'TT06      ', CAST(N'2021-04-26' AS Date), CAST(N'2021-06-30' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM17     ', N'T02                 ', N'TT01      ', CAST(N'2021-03-09' AS Date), CAST(N'2021-06-09' AS Date), N'Chưa trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM18     ', N'T06                 ', N'TT05      ', CAST(N'2021-04-26' AS Date), CAST(N'2021-06-30' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM19     ', N'T01                 ', N'TT04      ', CAST(N'2021-03-16' AS Date), CAST(N'2021-06-25' AS Date), N'Đã trả')
INSERT [dbo].[HoSoMuon] ([MaHSM], [MaThe], [MaThuThu], [NgayMuon], [NgayPhaiTra], [TrinhTrangMuon]) VALUES (N'HSM20     ', N'T08                 ', N'TT03      ', CAST(N'2021-10-15' AS Date), CAST(N'2022-01-14' AS Date), N'Đang mượn')
GO
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST01     ', N'HSM04     ', CAST(N'2021-03-19' AS Date), 0.0000, NULL, N'TT03      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST02     ', N'HSM06     ', CAST(N'2021-04-25' AS Date), 0.0000, NULL, N'TT06      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST03     ', N'HSM07     ', CAST(N'2021-05-07' AS Date), 50000.0000, CAST(N'2021-05-07' AS Date), N'TT02      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST04     ', N'HSM01     ', CAST(N'2021-06-15' AS Date), 20000.0000, CAST(N'2021-06-15' AS Date), N'TT01      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST05     ', N'HSM14     ', CAST(N'2021-06-15' AS Date), 80000.0000, CAST(N'2021-06-15' AS Date), N'TT01      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST06     ', N'HSM13     ', CAST(N'2021-08-06' AS Date), 0.0000, NULL, N'TT04      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST07     ', N'HSM11     ', CAST(N'2021-10-15' AS Date), 30000.0000, CAST(N'2021-10-15' AS Date), N'TT05      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST09     ', N'HSM18     ', CAST(N'2021-05-28' AS Date), 0.0000, NULL, N'TT06      ')
INSERT [dbo].[HoSoTra] ([MaHSTra], [MaHSM], [NgayTra], [TongTienPhat], [NgayNopPhat], [MaThuThu]) VALUES (N'HST10     ', N'HSM16     ', CAST(N'2021-07-09' AS Date), 50000.0000, CAST(N'2021-07-09' AS Date), N'TT04      ')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K01       ', N'Công nghệ thông tin', N'0988113679')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K02       ', N'Vận tải kinh tế', N'0989977674')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K03       ', N'Điện-Điện tử', N'02835120742')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K04       ', N'Kỹ thuật xây dựng', N'0983653846')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K05       ', N'Quản lý xây dựng', N'0918273645')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K06       ', N'Cơ khí', N'0918688685')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K07       ', N'Khoa học cơ bản ', N'0973639279')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa], [DienThoai]) VALUES (N'K09       ', N'Công trình', N'0354973812')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L01       ', N'Công nghệ thông tin 4', N'K01       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L02       ', N'Khai thác vận tải', N'K02       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L03       ', N'Cơ khí 1', N'K06       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L04       ', N'Cơ khí 2', N'K06       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L05       ', N'Kỹ thuật xây dựng 1', N'K04       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L06       ', N'Kinh tế xây dựng', N'K05       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L07       ', N'Kỹ thuật điện 2', N'K03       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L08       ', N'Công nghệ thông tin 2', N'K01       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L09       ', N'Kỹ thuật xây dựng 5', N'K04       ')
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'L10       ', N'Logistics và Quản lý chuỗi cung ứng 1', N'K02       ')
GO
INSERT [dbo].[Phat] ([MaPhat], [TienPhat]) VALUES (N'P01       ', 20000.0000)
INSERT [dbo].[Phat] ([MaPhat], [TienPhat]) VALUES (N'P02       ', 30000.0000)
INSERT [dbo].[Phat] ([MaPhat], [TienPhat]) VALUES (N'P03       ', 50000.0000)
GO
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'Q01       ', N'Hà Nội')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'Q02       ', N'Hải Dương')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'Q03       ', N'Bắc Ninh')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'Q04       ', N'Nam Định')
INSERT [dbo].[Que] ([MaQue], [TenQue]) VALUES (N'Q05       ', N'Thái Bình')
GO
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG01      ', N'Phạm Văn Ất', N'K01       ', N'1965', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG03      ', N'Nguyễn Thế Vinh', N'K07       ', N'1980', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG04      ', N'Vũ Đình Lai', N'K05       ', N'1967', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG05      ', N'Nguyễn Văn Long', N'K01       ', N'1963', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG06      ', N'Nguyễn Huy Hoàng', N'K07       ', N'1975', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG07      ', N'Lê Bá Sơn', N'K07       ', N'1949', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG08      ', N'Nguyễn Thanh Chương', N'K02       ', N'1970', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG09      ', N'Nguyễn Thị Hồng Hạnh', N'K02       ', N'1972', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG11      ', N'Trần Đắc Sử', N'K09       ', N'1956', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG12      ', N'Phạm Duy Hữu', N'K04       ', N'1948', N'TD02      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG13      ', N'Bùi Vĩnh Phúc', N'K07       ', N'1962', N'TD01      ')
INSERT [dbo].[TacGia] ([MaTG], [TenTG], [MaKhoa], [NamSinh], [MaTrinhDo]) VALUES (N'TG14      ', N'Lê Mạnh Việt', N'K03       ', N'1954', N'TD02      ')
GO
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T01                 ', N'Nguyễn Thị Hải', N'Nữ', N'L06       ', N'K05       ', N'Không', 1)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T02                 ', N'Trần Văn Chính', N'Nam', N'L03       ', N'K06       ', N'Không', 3)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T03                 ', N'Lê Thu Bạch Yến', N'Nữ', N'L02       ', N'K02       ', N'Không', 2)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T04                 ', N'Trần Anh Tuấn', N'Nam', N'L05       ', N'K04       ', N'Không', 2)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T05                 ', N'Hoàng Khánh Ngọc', N'Nữ', N'L10       ', N'K02       ', N'Không', 1)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T06                 ', N'Trần Thanh Mai', N'Nữ', N'L09       ', N'K04       ', N'Không', 2)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T07                 ', N'Trần Thị Thu Thủy', N'Nữ', N'L07       ', N'K03       ', N'Không', 1)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T08                 ', N'Trần Thị Hiền', N'Nữ', N'L08       ', N'K01       ', N'Không', 1)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T09                 ', N'Lê Văn Hùng', N'Nam', N'L01       ', N'K01       ', N'Không ', 2)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T10                 ', N'Lê Quang Hưng', N'Nam', N'L04       ', N'K06       ', N'Không', 3)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T11                 ', N'Nguyễn Mai Hương', N'Nữ', N'L02       ', N'K02       ', N'Không', 1)
INSERT [dbo].[TheMuon] ([MaThe], [HoTen], [GioiTinh], [MaLop], [MaKhoa], [KhoaThe], [SoLuongMuon]) VALUES (N'T12                 ', N'Hoàng Thanh Hằng', N'Nữ', N'L10       ', N'K02       ', N'Không ', 1)
GO
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [DiaChi], [DienThoaiCD], [DienThoaiDD], [MaQue]) VALUES (N'TT01      ', N'Nguyễn Thị Thanh Tâm', N'Số 9 Hồ Tùng Mậu', N'0979657676     ', N'0979657676     ', N'Q03       ')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [DiaChi], [DienThoaiCD], [DienThoaiDD], [MaQue]) VALUES (N'TT02      ', N'Nguyễn Minh', N'Số 21 Nguyễn Thái Học', N'0968145689     ', N'0968145689     ', N'Q02       ')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [DiaChi], [DienThoaiCD], [DienThoaiDD], [MaQue]) VALUES (N'TT03      ', N'Đỗ Thảo Phương', N'Số 7 Triều Khúc', N'0966666666     ', N'0966666666     ', N'Q01       ')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [DiaChi], [DienThoaiCD], [DienThoaiDD], [MaQue]) VALUES (N'TT04      ', N'Đỗ Huy Long', N'Số 72 Trần Cung', N'0983646585     ', N'0983646585     ', N'Q04       ')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [DiaChi], [DienThoaiCD], [DienThoaiDD], [MaQue]) VALUES (N'TT05      ', N'Bùi Ngọc', N'Số 105 Nguyễn Chí Thanh', N'0918167892     ', N'0918167892     ', N'Q05       ')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [DiaChi], [DienThoaiCD], [DienThoaiDD], [MaQue]) VALUES (N'TT06      ', N'Nguyễn Hải', N'Số 25 Hồ Tùng Mậu', N'0962091666     ', N'0962091666     ', N'Q01       ')
GO
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TD01      ', N'Thạc sỹ')
INSERT [dbo].[TrinhDo] ([MaTrinhDo], [TenTrinhDo]) VALUES (N'TD02      ', N'Tiến sĩ')
GO
INSERT [dbo].[ViPham] ([MaViPham], [TenViPham]) VALUES (N'VP01      ', N'Làm mất giáo trình')
INSERT [dbo].[ViPham] ([MaViPham], [TenViPham]) VALUES (N'VP02      ', N'Làm hỏng giáo trình')
INSERT [dbo].[ViPham] ([MaViPham], [TenViPham]) VALUES (N'VP03      ', N'Trả quá hạn')
GO
ALTER TABLE [dbo].[DMGiaoTrinh]  WITH CHECK ADD  CONSTRAINT [FK_DMGiaoTrinh_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[DMGiaoTrinh] CHECK CONSTRAINT [FK_DMGiaoTrinh_TacGia]
GO
ALTER TABLE [dbo].[HoSoTra]  WITH CHECK ADD  CONSTRAINT [FK_HoSoTra_HoSoMuon] FOREIGN KEY([MaHSM])
REFERENCES [dbo].[HoSoMuon] ([MaHSM])
GO
ALTER TABLE [dbo].[HoSoTra] CHECK CONSTRAINT [FK_HoSoTra_HoSoMuon]
GO
