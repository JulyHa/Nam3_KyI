alter table HoSoMuon
add MaPhieu nvarchar(10)

alter table HoSoMuon
add MaDocGia nvarchar(10)

alter table HoSoMuon
add TinhTrangThe nvarchar(10)

select * from HoSoMuon

alter table HoSoMuon
add SoLuong int

alter table HoSoMuon
add MaGT int



select * from HoSoMuon

/*
alter view PhieuMuon as
select MaPhieu, MaDocGia, MaGT, SoLuong,NgayMuon, NgayPhaiTra, HoSoMuon.TrinhTrangMuon, TinhTrangThe
from HoSoMuon join HoSoMuon on HoSoMuon.MaHSM = HoSoMuon.MaHSM

select * from PhieuMuon
*/

CREATE TABLE [dbo].[PhieuMuon](
	[MaHSM] [nchar](10) NOT NULL,
	[MaDG] [nchar](20) NOT NULL,
	[MaGT] [nchar](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[NgayPhaiTra] [date] NOT NULL,
	[TinhTrangThe] [nvarchar](20) NOT NULL,
	[TrinhTrangMuon] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_PhieuMuon] PRIMARY KEY CLUSTERED 
(
	[MaHSM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

select * from PhieuMuon
