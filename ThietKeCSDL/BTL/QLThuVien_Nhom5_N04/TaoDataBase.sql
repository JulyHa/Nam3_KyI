USE [BTL_QLThuVien]
GO
/****** Object:  UserDefinedFunction [dbo].[DG_TongPhat]    Script Date: 2021-11-08 6:32:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[DG_TongPhat](@madg nvarchar(10)) returns money as
begin
	declare @tong int
	select @tong = sum(TienPhat) from Phat inner join TT_Tra on Phat.MaPhat=TT_Tra.MaPhat inner join TT_Muon on TT_Muon.MaMuon=TT_Tra.MaMuon
	where TT_Muon.MaDocGia = @madg
	return @tong
end
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 2021-11-08 6:32:20 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [nvarchar](15) NOT NULL,
	[TenChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_TT_Muon]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_TT_Muon](
	[MaMuon] [nvarchar](15) NOT NULL,
	[MaTaiLieu] [nvarchar](15) NOT NULL,
	[SoLuong] [int] NULL,
	[TinhTrangTaiLieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_TT_Muon] PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC,
	[MaTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_TT_Tra]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_TT_Tra](
	[MaTra] [nvarchar](15) NOT NULL,
	[MaTaiLieu] [nvarchar](15) NOT NULL,
	[SoLuong] [int] NULL,
	[TinhTrangTaiLieu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_TT_Tra] PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC,
	[MaTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDocGia] [nvarchar](15) NOT NULL,
	[TenDocGia] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[NoiSinh] [nvarchar](15) NULL,
	[MaLoai] [nvarchar](15) NULL,
	[MaKhoa] [nvarchar](15) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_DocGia] PRIMARY KEY CLUSTERED 
(
	[MaDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](15) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoaiDocGia]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiDocGia](
	[MaLoai] [nvarchar](15) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[MaNXB] [nvarchar](15) NOT NULL,
	[TenNXB] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [nvarchar](15) NULL,
 CONSTRAINT [PK_NhaXuatBan] PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Phat]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phat](
	[MaPhat] [nvarchar](15) NOT NULL,
	[NgayNop] [date] NULL,
	[TienPhat] [money] NULL,
	[LyDo] [nvarchar](100) NULL,
 CONSTRAINT [PK_Phat] PRIMARY KEY CLUSTERED 
(
	[MaPhat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTacGia] [nvarchar](15) NOT NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[NamSinh] [char](4) NULL,
	[MaChucVu] [nvarchar](15) NULL,
	[MaKhoa] [nvarchar](15) NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TaiLieu]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiLieu](
	[MaTaiLieu] [nvarchar](15) NOT NULL,
	[TenTaiLieu] [nvarchar](200) NULL,
	[MaTheLoai] [nvarchar](15) NULL,
	[MaTacGia] [nvarchar](15) NULL,
	[MaNXB] [nvarchar](15) NULL,
	[NamXB] [nchar](4) NULL,
	[SoLanTB] [int] NULL,
	[SoTrang] [int] NULL,
	[TomTatND] [nvarchar](500) NULL,
	[NgonNgu] [nvarchar](15) NULL,
	[SoLuong] [int] NULL,
	[GiaTien] [money] NULL,
 CONSTRAINT [PK_TaiLieu] PRIMARY KEY CLUSTERED 
(
	[MaTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [nvarchar](15) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThuThu]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuThu](
	[MaThuThu] [nvarchar](15) NOT NULL,
	[TenThuThu] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[NoiSinh] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[SDT] [nvarchar](15) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_ThuThu] PRIMARY KEY CLUSTERED 
(
	[MaThuThu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TT_Muon]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TT_Muon](
	[MaMuon] [nvarchar](15) NOT NULL,
	[MaDocGia] [nvarchar](15) NULL,
	[MaThuThu] [nvarchar](15) NULL,
	[NgayMuon] [date] NULL,
	[HanCha] [date] NULL,
 CONSTRAINT [MaMuon] PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TT_Tra]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TT_Tra](
	[MaTra] [nvarchar](15) NOT NULL,
	[MaMuon] [nvarchar](15) NOT NULL,
	[MaThuThu] [nvarchar](15) NOT NULL,
	[NgayTra] [date] NULL,
	[MaPhat] [nvarchar](15) NULL,
 CONSTRAINT [PK_TT_Tra] PRIMARY KEY CLUSTERED 
(
	[MaTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[DS_Muon]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[DS_Muon](@mamuon nvarchar(10)) returns table as return(
	select DocGia.MaDocGia, TenDocGia, MaTaiLieu, SoLuong
	from TT_Muon inner join CT_TT_Muon on TT_Muon.MaMuon = CT_TT_Muon.MaMuon inner join DocGia on TT_Muon.MaDocGia=DocGia.MaDocGia
	where TT_Muon.MaMuon = @mamuon
)
GO
/****** Object:  UserDefinedFunction [dbo].[DS_TLMuonThang]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[DS_TLMuonThang](@month int) returns table as return(
	select DocGia.MaDocGia, TenDocGia, count(MaTaiLieu) as SLMuon, NgayMuon 
	from TT_Muon inner join DocGia on TT_Muon.MaDocGia=DocGia.MaDocGia inner join CT_TT_Muon on CT_TT_Muon.MaMuon = TT_Muon.MaMuon
	where month(NgayMuon) = @month
	group by DocGia.MaDocGia, TenDocGia, NgayMuon
)
GO
/****** Object:  UserDefinedFunction [dbo].[HT_ThuThu]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[HT_ThuThu](@ten nvarchar(30)) returns table as return(
	select MaThuThu, TenThuThu, NgaySinh, NoiSinh, GioiTinh, SDT from ThuThu where TenThuThu like N'%'+@ten+'%'
)
GO
/****** Object:  UserDefinedFunction [dbo].[TimTl]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TimTl](@matl nvarchar(15)) returns table as return(
	select * from TaiLieu where MaTaiLieu = @matl
)
GO
/****** Object:  UserDefinedFunction [dbo].[TongPhat]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TongPhat](@ten nvarchar(30)) returns table as return(
	select DocGia.MaDocGia, TenDocGia, sum(TienPhat)as TienPhat
	from Phat inner join TT_Tra on Phat.MaPhat=TT_Tra.MaPhat inner join TT_Muon on TT_Muon.MaMuon=TT_Tra.MaMuon
	inner join DocGia on DocGia.MaDocGia = TT_Muon.MaDocGia
	where TenDocGia like N'%'+@ten+'%'
	group by DocGia.MaDocGia, TenDocGia
)

GO
/****** Object:  UserDefinedFunction [dbo].[TraSachTruoc]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[TraSachTruoc](@day date) returns table as return(
	select DocGia.MaDocGia, TenDocGia, HanCha from TT_Muon inner join DocGia on TT_Muon.MaDocGia = DocGia.MaDocGia where HanCha < @day
)
GO
/****** Object:  View [dbo].[DS_DocGiaBiPhat]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[DS_DocGiaBiPhat] as
select DocGia.MaDocGia , TenDocGia, NgaySinh, GioiTinh, NoiSinh, TenLoai, TenKhoa, MaPhat
from DocGia inner join LoaiDocGia on LoaiDocGia.MaLoai = DocGia.MaLoai inner join Khoa on Khoa.MaKhoa = DocGia.MaKhoa 
	inner join TT_Muon on DocGia.MaDocGia = TT_Muon.MaDocGia inner join TT_Tra on TT_Muon.MaMuon = TT_Tra.MaMuon 
where MaPhat is not null
GO
/****** Object:  View [dbo].[DS_DocGiaChuaNopPhat]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DS_DocGiaChuaNopPhat] as
select DocGia.MaDocGia , TenDocGia, NgaySinh, GioiTinh, NoiSinh, TenLoai, TenKhoa
from DocGia inner join LoaiDocGia on LoaiDocGia.MaLoai = DocGia.MaLoai inner join Khoa on Khoa.MaKhoa = DocGia.MaKhoa 
	inner join TT_Muon on DocGia.MaDocGia = TT_Muon.MaDocGia inner join TT_Tra on TT_Muon.MaMuon = TT_Tra.MaMuon
where MaPhat not in(select MaPhat from Phat)
GO
/****** Object:  View [dbo].[DS_ThuThu]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DS_ThuThu] as
	select * from ThuThu
GO
/****** Object:  View [dbo].[DS_TLMuonNhieuNhat]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DS_TLMuonNhieuNhat] as
select TaiLieu.MaTaiLieu,TenTaiLieu , sum(CT_TT_Muon.SoLuong) as SoLuongMuon from TaiLieu inner join CT_TT_Muon on TaiLieu.MaTaiLieu = CT_TT_Muon.MaTaiLieu
group by TaiLieu.MaTaiLieu, TenTaiLieu having sum(CT_TT_Muon.SoLuong) = (select Top(1) sum(SoLuong) from CT_TT_Muon group by MaTaiLieu)
GO
/****** Object:  View [dbo].[DS_TLNuocNgoai]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[DS_TLNuocNgoai] as
select MaTaiLieu, TenTaiLieu, TenTheLoai, NgonNgu, SoLuong, GiaTien 
from TaiLieu inner join TheLoai on TheLoai.MaTheLoai = TaiLieu.MaTheLoai where NgonNgu = N'Nước ngoài'
GO
/****** Object:  View [dbo].[SLTGCuaMoiKhoa]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[SLTGCuaMoiKhoa] as
select Khoa.MaKhoa, TenKhoa, count(MaTacGia)as SLTacGia
from TacGia inner join Khoa on TacGia.MaKhoa = Khoa.MaKhoa
group by Khoa.MaKhoa, TenKhoa
GO
/****** Object:  View [dbo].[TiengViet_NuocNgoai]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TiengViet_NuocNgoai] as
select NgonNgu, count(MaTaiLieu) as SLTaiLieu from TaiLieu 
group by NgonNgu
GO
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV01', N'Thạc sỹ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV02', N'Tiến sĩ')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV03', N'PGS.TS')
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu]) VALUES (N'CV04', N'GS.TS')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M02', N'TL05', 3, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M03', N'TL11', 1, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M04', N'TL05', 1, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M04', N'TL18', 1, N'Cũ')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M05', N'TL20', 1, N'Cũ')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M07', N'TL01', 2, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M08', N'TL04', 2, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M09', N'TL03', 1, N'Cũ')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M11', N'TL07', 5, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M12', N'TL01', 3, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M12', N'TL05', 2, N'Mới')
INSERT [dbo].[CT_TT_Muon] ([MaMuon], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'M12', N'TL06', 1, N'Mới')
INSERT [dbo].[CT_TT_Tra] ([MaTra], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'T01', N'TL18', 1, N'Cũ')
INSERT [dbo].[CT_TT_Tra] ([MaTra], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'T02', N'TL05', 2, N'Mới')
INSERT [dbo].[CT_TT_Tra] ([MaTra], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'T03', N'TL20', 1, N'Cũ')
INSERT [dbo].[CT_TT_Tra] ([MaTra], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'T05', N'TL09', 1, N'Cũ')
INSERT [dbo].[CT_TT_Tra] ([MaTra], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'T06', N'TL01', 1, N'Mới')
INSERT [dbo].[CT_TT_Tra] ([MaTra], [MaTaiLieu], [SoLuong], [TinhTrangTaiLieu]) VALUES (N'T11', N'TL05', 2, N'Cũ')
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG01', N'Nguyễn Thị Hải', CAST(N'2001-06-05' AS Date), N'Nữ', N'Hà Nội', N'L01', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG02', N'Trần Văn Chính', CAST(N'2000-02-07' AS Date), N'Nam', N'Hà Nam', N'L01', N'L04', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG03', N'Lê Thu Bạch Yến', CAST(N'1991-06-04' AS Date), N'Nữ', N'Hòa Bình', N'L02', N'K09', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG04', N'Trần Anh Tuấn', CAST(N'2000-10-03' AS Date), N'Nam', N'Thái Bình', N'L01', N'K06', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG05', N'Hoàng Khánh Ngọc', CAST(N'2001-09-03' AS Date), N'Nữ', N'Hưng Yên', N'L01', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG06', N'Trần Thanh Mai', CAST(N'1999-02-10' AS Date), N'Nữ', N'Vĩnh Phúc', N'L01', N'K01', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG07', N'Trần Thị Thu Thủy', CAST(N'2002-04-27' AS Date), N'Nữ', N'Nam Định', N'L01', N'K05', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG08', N'Trần Thị Hiền', CAST(N'2001-05-23' AS Date), N'Nữ', N'Hà Nội', N'L01', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG09', N'Lê Văn Hùng', CAST(N'1999-12-12' AS Date), N'Nam', N'Bắc Giang', N'L01', N'K03', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG10', N'Lê Quang Hưng', CAST(N'2000-11-02' AS Date), N'Nam', N'Bắc Ninh', N'L01', N'K06', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG11', N'Nguyễn Mai Hương', CAST(N'2002-06-03' AS Date), N'Nữ', N'Hải Dương', N'L01', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG12', N'Hoàng Thanh Hằng', CAST(N'2001-11-24' AS Date), N'Nữ', N'Hải Phòng', N'L01', N'K05', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG13', N'Vũ Hữu Mạnh', CAST(N'2002-06-01' AS Date), N'Nam', N'Yên Bái', N'L01', N'K01', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG14', N'Vương Đức Phương', CAST(N'1999-09-18' AS Date), N'Nam', N'Lào Cai', N'L01', N'K01', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG15', N'Nguyễn Quốc Đoàn', CAST(N'1998-08-02' AS Date), N'Nam', N'Quảng Ninh', N'L01', N'K08', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG16', N'Nguyễn Văn Giang', CAST(N'1990-03-03' AS Date), N'Nam', N'Hà Nội', N'L02', N'K07', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG17', N'Lê Văn Linh', CAST(N'2002-09-28' AS Date), N'Nam', N'Phú Thọ', N'L01', N'K03', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG18', N'Lê Đức Hiếu', CAST(N'1999-06-03' AS Date), N'Nam', N'Thanh Hóa', N'L01', N'K06', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG19', N'Ngô Quốc Tuấn', CAST(N'2001-08-20' AS Date), N'Nam', N'Nghệ An', N'L01', N'K04', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG20', N'Phan Việt Anh', CAST(N'2000-06-02' AS Date), N'Nam', N'Hà Tĩnh', N'L01', N'K08', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG21', N'Nguyễn Đức Luân', CAST(N'1990-12-03' AS Date), N'Nam', N'Hà Nội', N'L02', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG22', N'Nguyễn Thị Hồng', CAST(N'2001-04-02' AS Date), N'Nữ', N'Bắc Ninh', N'L01', N'K01', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG23', N'Nguyễn Thị Thanh Mai', CAST(N'1991-01-02' AS Date), N'Nữ', N'Vĩnh Phúc', N'L02', N'K09', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG24', N'Vũ Thị Thu Huyền', CAST(N'2000-06-09' AS Date), N'Nữ', N'Hưng Yên', N'L01', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG25', N'Vương Sỹ Khải', CAST(N'1999-07-22' AS Date), N'Nam', N'Hòa Bình', N'L01', N'K04', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG26', N'Nguyễn Thế Linh', CAST(N'2001-05-05' AS Date), N'Nam', N'Bắc Giang', N'L01', N'K06', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG27', N'Nguyễn Thị Oanh', CAST(N'1989-10-08' AS Date), N'Nữ', N'Quảng Ninh', N'L02', N'K01', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG28', N'Mai Thị Trang', CAST(N'2000-06-02' AS Date), N'Nữ', N'Hải Dương', N'L01', N'K02', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG29', N'Vũ Hải Hiệp', CAST(N'2002-12-07' AS Date), N'Nam', N'Hưng Yên', N'L01', N'K08', NULL)
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG30', N'Trần Xuân Khánh', CAST(N'2001-09-09' AS Date), N'Nam', N'Thái Bình', N'L01', N'K03', N'Đã ra trường')
INSERT [dbo].[DocGia] ([MaDocGia], [TenDocGia], [NgaySinh], [GioiTinh], [NoiSinh], [MaLoai], [MaKhoa], [GhiChu]) VALUES (N'DG61', N'Nguyễn Thị Ngũ', CAST(N'2001-07-31' AS Date), N'Nữ', N'Ba Vì - Hà Nội', N'L02', N'K01', NULL)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K01', N'Công nghệ thông tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K02', N'Vận tải kinh tế')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K03', N'Điện-Điện tử')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K04', N'Kỹ thuật xây dựng')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K05', N'Quản lý xây dựng')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K06', N'Cơ khí')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K07', N'Khoa học cơ bản ')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K08', N'Công trình')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'K09', N'Lý luận chính trị')
INSERT [dbo].[LoaiDocGia] ([MaLoai], [TenLoai]) VALUES (N'L01', N'Sinh viên')
INSERT [dbo].[LoaiDocGia] ([MaLoai], [TenLoai]) VALUES (N'L02', N'Giảng viên')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB01', N'Đại học GTVT', N'Số 3 Cầu Giấy', N'02438966798 ')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB02', N'NXB Giáo Dục', N'81 Trần Hưng Đạo', N'0968686868')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB03', N'NXB Fahasa', N'Hà Đông', N'0918273645')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB04', N'NXB Hồng Đức', N'65 Tràng Thi', N'0918688685')
INSERT [dbo].[NhaXuatBan] ([MaNXB], [TenNXB], [DiaChi], [SDT]) VALUES (N'NXB05', N'NXB Trẻ', N'Hà Nội', N'0978656790')
INSERT [dbo].[Phat] ([MaPhat], [NgayNop], [TienPhat], [LyDo]) VALUES (N'P01', CAST(N'2020-06-15' AS Date), 20000.0000, N'Trả quá hạn')
INSERT [dbo].[Phat] ([MaPhat], [NgayNop], [TienPhat], [LyDo]) VALUES (N'P02', CAST(N'2021-04-28' AS Date), 50000.0000, N'Trả quá hạn và làm hỏng tài liệu')
INSERT [dbo].[Phat] ([MaPhat], [NgayNop], [TienPhat], [LyDo]) VALUES (N'P03', CAST(N'2021-04-18' AS Date), 30000.0000, N'Làm mất tài liệu')
INSERT [dbo].[Phat] ([MaPhat], [NgayNop], [TienPhat], [LyDo]) VALUES (N'P04', CAST(N'2020-12-28' AS Date), 60000.0000, N'Làm mất tài liệu và trả quá hạn')
INSERT [dbo].[Phat] ([MaPhat], [NgayNop], [TienPhat], [LyDo]) VALUES (N'P05', CAST(N'2021-05-16' AS Date), 20000.0000, N'Gia hạn mượn')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG01      ', N'Phạm Văn Ất', N'1965', N'CV03', N'K01')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG02', N'Nguyễn Thế Vinh', N'1980', N'CV02', N'K07')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG03', N'Vũ Đình Lai', N'1967', N'CV04', N'K05')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG04', N'Nguyễn Văn Long', N'1963', N'CV03', N'K01')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG05', N'Nguyễn Huy Hoàng', N'1975', N'CV02', N'K07')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG06', N'Lê Bá Sơn', N'1949', N'CV03', N'K07')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG07', N'Nguyễn Thanh Chương', N'1970', N'CV03', N'K02')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG08', N'Nguyễn Thị Hồng Hạnh', N'1972', N'CV03', N'K02')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG09', N'Trần Đắc Sử', N'1956', N'CV03', N'K08')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG10', N'Phạm Duy Hữu', N'1948', N'CV04', N'K04')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG11', N'Bùi Vĩnh Phúc', N'1962', N'CV01', N'K07')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG12', N'Lê Mạnh Việt', N'1954', N'CV03', N'K03')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG13', N'Vũ Văn Khương', N'1949', N'CV03', N'K07')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG14', N'Nguyễn Thị Thanh Hải', N'1980', N'CV02', N'K09')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG15', N'Hồ Sỹ Hà', N'1970', NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG16', N'Bộ công thương', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG17', N'Samuelson, Paul A', N'1915', NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG18', N'Tăng Phan Anh', N'1995', NULL, N'K08')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG19', N'Vũ Ngọc Lâm', N'1997', NULL, N'K01')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG20', N'Trần Văn Tiện', N'1998', NULL, N'K08')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG21', N'Lê Thiệu Dũng', N'1982', NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG22', N' Học viện chính trị quốc gia HCM', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG23', N'Trung tâm thông tin bưu điện', NULL, NULL, NULL)
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG24', N'Lê Huy Minh', N'1996', NULL, N'K05')
INSERT [dbo].[TacGia] ([MaTacGia], [TenTacGia], [NamSinh], [MaChucVu], [MaKhoa]) VALUES (N'TG25', N'Trần Văn Long', N'1979', N'CV03', N'K07')
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL01', N'Tin học đại cương', N'TL03', N'TG01      ', N'NXB01', N'2017', 1, 105, N'Đại cương về tin học; Ngôn ngữ lập trình C', N'Tiếng Việt', 60, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL02', N'Sức bền vật liệu', N'TL03', N'TG03', N'NXB01', N'2006', 1, 245, N'Gồm 9 chương', N'Nước ngoài', 871, 50000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL03', N'Đại số tuyến tính', N'TL03', N'TG05', N'NXB01', N'2017', 1, 350, N'Ma trận và định thức; Hệ phương trình tuyến tính; Không gian tuyến tính; Ánh xạ tuyến tính; Không gian euclid', N'Tiếng Việt', 515, 72000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL04', N'Giải tích', N'TL03', N'TG02', N'NXB01', N'2012', 2, 325, N'Giải tích 1', N'Tiếng Việt', 510, 65000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL05', N'Giải tích số', N'TL03', N'TG04', N'NXB01', N'2007', 1, 150, NULL, N'Nước ngoài', 162, 40000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL06', N'Vật lý', N'TL03', N'TG06', N'NXB01', N'2015', 1, 275, N'Động học; Động lực học; Cơ năng; Nhiệt động lực học; Trạng thái lỏng và biến đổi pha; Trường tĩnh điện; Từ trường và trường điện từ; Quang học; Vật lý kỹ thuật
', N'Tiếng Việt', 160, 55000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL07', N'Điều tra kinh tế', N'TL07', N'TG07', N'NXB01', N'2019', 1, 160, N'Tổng quan về điều tra kinh tế. Phương pháp luận của điều tra kinh tế. Điều tra kinh tế trong quản lý và quy hoạch. Phương pháp điều tra và xử lý - phân tích dữ liệu điều tra', N'Tiếng Việt', 111, 42000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL08', N'Tài chính doanh nghiệp', N'TL07', N'TG08', N'NXB01', N'2020', 1, 216, N'Tổng quan về tài chính doanh nghiệp; Chi phí doanh thu và lợi nhuận; Vốn kinh doanh của doanh nghiệp...
', N'Tiếng Việt', 110, 48000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL09', N'Kế toán doanh nghiệp vận tải', N'TL07', N'TG08', N'NXB01', N'2017', 1, 215, N'Tổ chức công tác kế toán trong doanh nghiệp vận tải; Kế toán vốn bằng tiền, đầu tư ngắn hạn, các khoản phỉa thu...', N'Tiếng Việt', 90, 48000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL10', N'Xác suất thống kê', N'TL03', N'TG25', N'NXB01', N'2017', 2, 219, N'Cơ sở của lý thuyết xác suất; Thống kê mô tả và phân phối mẫu; Lý thuyết ước lượng; Kiểm định giả thuyết thống kê, Hồi quy và tương quan
', N'Nước ngoài', 407, 49000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL11', N'Trắc địa đại cương', N'TL03', N'TG09', N'NXB01', N'2016', 1, 156, N'Những khái niệm cơ bản trong trắc địa; Sai số đo, Đo các đại lượng cơ bản trong trắc địa; Các thiết bị đo đạc hiện đại; Lưới khống chế trắc địa; Phương pháp thành lập và sử dụng bản đồ địa hình', N'Tiếng Việt', 360, 41000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL12', N'Vật liệu xây dựng', N'TL03', N'TG10', N'NXB01', N'2011', 2, 160, NULL, N'Tiếng Việt', 500, 42000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL13', N'Vẽ kỹ thuật cơ khí', N'TL03', N'TG11', N'NXB01', N'2018', 1, 220, N'Vật liệu và dụng cụ vẽ; Những tiêu chuẩn về trình bày bản vẽ kỹ thuật; Vẽ hình học; Các phép chiếu; Hình chiếu vuông góc; Hình cắt - mặt cắt - hình trích;..
', N'Tiếng Việt', 210, 50000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL14', N'Kỹ thuật điện', N'TL03', N'TG12', N'NXB01', N'2000', 2, 190, NULL, N'Tiếng Việt', 310, 45000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL15', N'Nghiên cứu giải pháp ứng dụng vật liệu mới trong bảo trì công trình giao thông ở Hà Nội ', N'TL05', N'TG20', N'NXB01', N'2020', 1, 72, N'Tình hình nứt và thấm ở một số công trình giao thông ở Hà Nội; Nghiên cứu tính năng kỹ thuật của các vật liệu xử lý vết nứt và chống thấm, đề xuất lựa chọn;', N'Tiếng Việt', 32, 41000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL16', N'Tạp chí lịch sử Đảng', N'TL04', N'TG22', NULL, N'2006', 1, 30, NULL, N'Tiếng Việt', 64, 20000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL17', N'Báo kinh tế Việt Nam', N'TL04', N'TG16', NULL, N'2009', 1, 10, NULL, N'Tiếng Việt', 65, 15000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL18', N'Nghiên cứu công nghệ bơm bê tông', N'TL05', N'TG18', N'NXB01', N'2019', 1, 118, N'Tổng quan về công nghệ bơm bê tông; Các công nghệ bơm và đặc tính của bê tông bơm; Quy trình thi công bê tông bơm tại Việt Nam; Ứng dụng bê tông bơm tại khu đô thị Nam Thăng Long', N'Tiếng Việt', 22, 48000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL19', N'Hoàn thiện công tác quản lý các dự án BOT tại Ban quản lý dự án 2', N'TL06', N'TG24', N'NXB01', N'2018', 1, 116, N'Lý luận chung về dự án đầu tư và quản lý các dự án đầu tư xây dựng theo hình thức hợp đồng BOT; Thực trạng công tác quản lý các dự án đầu tư xây dựng theo hình thức hợp đồng BOT tại Ban Quản lý dự án 2 - Bộ Giao thông vận tải;', N'Tiếng Việt', 58, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL20', N'Giải tích I. Phần 1', N'TL03', N'TG13', N'NXB01', N'2005', 1, 255, NULL, N'Tiếng Việt', 350, 50000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL21', N'Kinh tế học', N'TL07', N'TG17', N'NXB03', N'1989', 1, 365, NULL, N'Nước ngoài', 25, 65000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL22', N'Những điều kiện khách quan và những nhân tố chủ quan trong việc nâng cao chất lượng giảng dạy và học tập môn triết học Mac-Lênin ở trường đại học GTVT hiện nay', N'TL05', N'TG14', N'NXB01', N'2009', 1, 110, NULL, N'Tiếng Việt', 56, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL23', N'Thông tin khoa học kỹ thuật và kinh tế bưu điện', N'TL04', N'TG23', NULL, N'2005', 1, 29, NULL, N'Nước ngoài', 30, 50000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL24', N'Bài giảng thống kê kinh tế', N'TL07', N'TG15', N'NXB02', N'1991', 1, 190, NULL, N'Tiếng Việt', 145, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL25', N'Công nghệ mimo trong hệ thống wifi ieee 802.11 AC', N'TL02', N'TG19', N'NXB01', N'2019', 1, 81, N'Tổng quan về hệ thống wifi 802.11; Công nghệ mimo; Ứng dụng mimo trong hệ thống wifi 802.11 ac
', N'Tiếng Việt', 90, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL26', N'Hỏi đáp pháp luật về đất đai - nhà ở', N'TL08', N'TG21', N'NXB04', N'2020', 1, 279, N'Hỏi đáp các vấn đề pháp luật liên quan đến công tác quản lý đất đai và nhà ở; Hỏi - đáp các vấn đề pháp luật về cấp giấy chứng nhận quyền sử dụng đất và quyền sở hữu nhà ở; Hỏi - đáp các vấn đề pháp luật về nghĩa vụ tài chính khi sử dụng đất đai, nhà ở', N'Tiếng Việt', 100, 15000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL27', N'Nghiên cứu về sự tồn tại và phương pháp nghiệm đối với bài toán cân bằng', N'TL05', N'TG02', N'NXB01', N'2017', 1, 28, N'Bài toán cân bằng véctơ đa trị; Thuật toán tách giải bài toán cân bằng', N'Tiếng Việt', 93, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL28', N'Toán kỹ thuật nâng cao', N'TL03', N'TG05', N'NXB01', N'2013', 1, 215, N'Một số hàm số đặc biệt; Phương trình đạo hàm riêng; Quá trình ngẫu nhiên; Quá trình Poisson; Xích Markov; Lý thuyết xếp hàng', N'Nước ngoài', 50, 55000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL29', N'Bài giảng hình họa', N'TL03', N'TG11', N'NXB01', N'2015', 1, 160, N'Vật liệu và dụng cụ vẽ; Những tiêu chuẩn về trình bày bản vẽ kỹ thuật; Các phép chiếu; Hình chiếu thẳng góc; Hình chiếu trục đo; Hình cắt - Mặt cắt- Hình trích; Kết cấu thép; Bản vẽ kết cấu bê tông cốt thép', N'Nước ngoài', 10, 35000.0000)
INSERT [dbo].[TaiLieu] ([MaTaiLieu], [TenTaiLieu], [MaTheLoai], [MaTacGia], [MaNXB], [NamXB], [SoLanTB], [SoTrang], [TomTatND], [NgonNgu], [SoLuong], [GiaTien]) VALUES (N'TL30', N'Giải tích I. Phần 2 ', N'TL03', N'TG13', N'NXB01', N'2005', 1, 129, NULL, N'Tiếng Việt', 10, 20000.0000)
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL01', N'Chính trị - pháp luật')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL02', N'Khoa học công nghệ')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL03', N'Giáo trình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL04', N'Báo - tạp chí')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL05', N'Nghiên cứu khoa học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL06', N'Luận án - luận văn')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL07', N'Kinh tế - Tài chính')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL08', N'Tài liệu biếu tặng')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [NgaySinh], [NoiSinh], [GioiTinh], [SDT], [GhiChu]) VALUES (N'TT01', N'Nguyễn Thị Thanh Tâm', CAST(N'1992-06-20' AS Date), N'Bắc Ninh', N'Nữ', N'0979657676     ', N'Nghỉ việc')
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [NgaySinh], [NoiSinh], [GioiTinh], [SDT], [GhiChu]) VALUES (N'TT02', N'Nguyễn Minh', CAST(N'1989-08-04' AS Date), N'Hải Dương', N'Nam', N'0968145689     ', NULL)
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [NgaySinh], [NoiSinh], [GioiTinh], [SDT], [GhiChu]) VALUES (N'TT03', N'Đỗ Thảo Phương', CAST(N'1985-11-06' AS Date), N'Hà Nội', N'Nữ', N'0966666666     ', NULL)
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [NgaySinh], [NoiSinh], [GioiTinh], [SDT], [GhiChu]) VALUES (N'TT04', N'Đỗ Huy Long', CAST(N'1991-09-15' AS Date), N'Nam Định', N'Nam', N'0983646585     ', NULL)
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [NgaySinh], [NoiSinh], [GioiTinh], [SDT], [GhiChu]) VALUES (N'TT05', N'Phan Thị Hoa', CAST(N'1989-07-26' AS Date), N'Thái Bình', N'Nữ', N'0918167892     ', NULL)
INSERT [dbo].[ThuThu] ([MaThuThu], [TenThuThu], [NgaySinh], [NoiSinh], [GioiTinh], [SDT], [GhiChu]) VALUES (N'TT06', N'Cao Văn Dũng', CAST(N'1990-12-02' AS Date), N'Hà Nội', N'Nam', N'0962091666     ', NULL)
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M02', N'DG04', N'TT01', CAST(N'2020-08-20' AS Date), CAST(N'2020-10-30' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M03', N'DG26', N'TT03', CAST(N'2020-09-08' AS Date), CAST(N'2020-12-18' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M04', N'DG18', N'TT06', CAST(N'2020-02-04' AS Date), CAST(N'2020-06-07' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M05', N'DG01', N'TT04', CAST(N'2020-03-09' AS Date), CAST(N'2020-06-30' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M06', N'DG07', N'TT05', CAST(N'2020-10-09' AS Date), CAST(N'2020-12-26' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M07', N'DG03', N'TT03', CAST(N'2021-01-05' AS Date), CAST(N'2021-04-26' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M08', N'DG11', N'TT02', CAST(N'2021-01-15' AS Date), CAST(N'2021-04-20' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M11', N'DG28', N'TT06', CAST(N'2021-01-12' AS Date), CAST(N'2021-04-24' AS Date))
INSERT [dbo].[TT_Muon] ([MaMuon], [MaDocGia], [MaThuThu], [NgayMuon], [HanCha]) VALUES (N'M12', N'DG61', N'TT02', CAST(N'2021-03-02' AS Date), CAST(N'2021-05-28' AS Date))
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T01', N'M04', N'TT02', CAST(N'2020-06-05' AS Date), N'P04')
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T02', N'M02', N'TT05', CAST(N'2020-10-24' AS Date), NULL)
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T03', N'M05', N'TT01', CAST(N'2020-05-30' AS Date), NULL)
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T05', N'M06', N'TT03', CAST(N'2020-12-01' AS Date), NULL)
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T06', N'M07', N'TT04', CAST(N'2021-04-28' AS Date), N'P02')
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T07', N'M09', N'TT01', CAST(N'2021-04-18' AS Date), N'P03')
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T08', N'M03', N'TT06', CAST(N'2020-12-26' AS Date), NULL)
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T10', N'M08', N'TT05', CAST(N'2021-04-10' AS Date), NULL)
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T11', N'M12', N'TT04', CAST(N'2021-04-08' AS Date), NULL)
INSERT [dbo].[TT_Tra] ([MaTra], [MaMuon], [MaThuThu], [NgayTra], [MaPhat]) VALUES (N'T12', N'M11', N'TT03', CAST(N'2021-05-16' AS Date), N'P05')
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TT_Tra]    Script Date: 2021-11-08 6:32:21 CH ******/
ALTER TABLE [dbo].[TT_Tra] ADD  CONSTRAINT [IX_TT_Tra] UNIQUE NONCLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TT_Tra]  WITH CHECK ADD  CONSTRAINT [FK_TT_Tra_Phat] FOREIGN KEY([MaPhat])
REFERENCES [dbo].[Phat] ([MaPhat])
GO
ALTER TABLE [dbo].[TT_Tra] CHECK CONSTRAINT [FK_TT_Tra_Phat]
GO
ALTER TABLE [dbo].[TT_Tra]  WITH CHECK ADD  CONSTRAINT [FK_TT_Tra_ThuThu] FOREIGN KEY([MaThuThu])
REFERENCES [dbo].[ThuThu] ([MaThuThu])
GO
ALTER TABLE [dbo].[TT_Tra] CHECK CONSTRAINT [FK_TT_Tra_ThuThu]
GO
/****** Object:  StoredProcedure [dbo].[DGMuonNgay]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DGMuonNgay] @day date, @sl int out as 
begin 
	select count(MaMuon)as SL from TT_Muon where @day = NgayMuon
end
GO
/****** Object:  StoredProcedure [dbo].[SuaDG]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SuaDG] @madg nvarchar(10),@ten nvarchar(30), @day date, @gt nvarchar(5), @ns nvarchar(30), @ml nvarchar(15), @mk nvarchar(15), @gc nvarchar(max) as
begin 
	update DocGia set  TenDocGia=@ten, NgaySinh=@day, GioiTinh=@gt, NoiSinh=@ns, MaLoai=@ml,
	MaKhoa=@mk, GhiChu=@gc where MaDocGia = @madg
end
GO
/****** Object:  StoredProcedure [dbo].[ThemDG]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemDG] @madg nvarchar(10), @ten nvarchar(50), @ns date, @gt nvarchar(10), @nois nvarchar(30), @ml nvarchar(15), @mk nvarchar(15) as 
begin
	insert into DocGia values (@madg, @ten, @ns, @gt, @nois, @ml, @mk, '')
end
GO
/****** Object:  StoredProcedure [dbo].[ThemTL]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ThemTL] @matl nvarchar(15), @tentl nvarchar(50), @matloai nvarchar(10),@matg nvarchar(10), @manxb nvarchar(10),@mxb int, @sltb int, @st int,
	@tt nvarchar(max),@nn nvarchar(30), @sl int, @tien money as
begin
	INSERT [dbo].[TaiLieu] VALUES (@matl ,@tentl, @matloai, @matg, @manxb, @mxb, @sltb, @st, @tt, @nn, @sl, @tien)
end
GO
/****** Object:  StoredProcedure [dbo].[XoaDG]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[XoaDG] @madg nvarchar(30) as
begin 
	delete from DocGia where MaDocGia = @madg
end
GO
/****** Object:  StoredProcedure [dbo].[XoaTL]    Script Date: 2021-11-08 6:32:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[XoaTL] @tl nvarchar(30) as
begin 
	delete from TaiLieu where MaTaiLieu = @tl or TenTaiLieu = @tl
end
GO
