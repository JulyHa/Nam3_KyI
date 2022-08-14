
--drop database QLThuVien
create database QLThuVien
go
use QLThuVien
go

-----
--drop table DOCGIA
create table DOCGIA
(
	MaDocGia nchar(10),
	TenDangNhap nchar(30),
	HoTen nchar(30),
	GioiTinh nchar(5),
	NamSinh datetime,
	DiaChi nchar(100),
	PRIMARY KEY (MaDocGia),
)
--drop table SACH
create table SACH
(
	MaSach nchar(10),
	TenSach nchar(50),
	TacGia nchar(30),
	TheLoai nchar(30),
	NhaXuatBan nchar(50),
	GiaSach int,
	SoLuong int,
	TinhTrang nchar(10),
	PRIMARY KEY (MaSach),
)
--drop table PHIEUMUON
create table PHIEUMUON
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayMuon datetime,
	NgayPhaiTra datetime,
	PRIMARY KEY (MaPhieu),
)
--drop table PHIEUTRA
create table PHIEUTRA
(
	MaPhieu nchar(10),
	MaDocGia nchar(10),
	MaSach nchar(10),
	NgayTra datetime,
	PRIMARY KEY (MaPhieu),
)

create table ACCOUNT
(
	MaDocGia nchar(10) PRIMARY KEY,
	TenDangNhap nchar(30),
	MatKhau nchar(30),
	Quyen int,
)


alter table PHIEUMUON add
	constraint FK_PHIEUMUON_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUMUON_SACH foreign key (MaSach) references SACH (MaSach)

alter table PHIEUTRA add
	constraint FK_PHIEUTRA_DOCGIA foreign key (MaDocGia) references DOCGIA (MaDocGia),
	constraint FK_PHIEUTRA_SACH foreign key (MaSach) references SACH (MaSach)

ALTER TABLE dbo.DOCGIA ADD
	CONSTRAINT FK_DOCGIA_ACCOUNT FOREIGN KEY (MaDocGia) REFERENCES dbo.ACCOUNT(MaDocGia)



insert into ACCOUNT values ('15','Nguyễn Hữu Hoàng Hiếu', '123456', 1)
insert into ACCOUNT values ('1','phamhaingoc1', '123456', 1)
insert into ACCOUNT values ('2','phamhaingoc2', '123456', 1)
insert into ACCOUNT values ('3','phamminhhoang', '123456', 1)
insert into ACCOUNT values ('7','nguyenthanhhai', '123456', 1)
insert into ACCOUNT values ('999','admin', '', 0)
----
insert into DOCGIA values ('1','phamhaingoc1',N'Phạm Ngọc Hải','Nam',1996,N'510 Lý Thái Tổ')
insert into DOCGIA values ('2','phamhaingoc2',N'Phạm Hải NGọc','Nam',1994,N'20 Lý Thái Tổ')
insert into DOCGIA values ('3','phamminhhoang',N'Phạm Minh Hoang','Nam',1994,N'20 Lý Thái Tổ')
insert into DOCGIA values ('7','nguoithanhhai',N'Nguyễn Thanh Hải',N'Nữ',1994,N'201 Lý Thái Tổ')
insert into DOCGIA values ('15','nguyenhuuhoanghieu',N'Nguyễn Hữu Hoàng Hiếu',N'Nữ',1994,N'120 Lý Thái Tổ')

----
insert into SACH values ('1', N'Lập trình hướng đối tượng', N'Không biết', N'Lập trình', 'HCMUS', 1500, 3, N'Còn')
insert into SACH values ('2', N'Nhập môn lập trình', N'Không biết', N'Lập trình', 'HCMUS', 1500, 10, N'Còn')
insert into SACH values ('3', N'Kỹ Thuật Lập Trình', N'Không biết', N'Lập trình', 'HCMUS', 3000, 5, N'Còn')
insert into SACH values ('4', N'Thiết Kế Phần Mềm', N'Không biết', N'Lập trình', 'HCMUS', 4000, 0, N'Hết')
---
insert into PHIEUMUON values ('1','1','1','1/1/2017', '1/2/2017')
insert into PHIEUMUON values ('2','2','1','1/2/2017', '1/3/2017')
insert into PHIEUMUON values ('3','2','2','1/3/2017', '1/4/2017')

---
insert into PHIEUTRA values ('1','1','2','1/1/2016')
insert into PHIEUTRA values ('2','2','1','1/2/2016')
insert into PHIEUTRA values ('3','2','2','1/3/2016')

---


select DOCGIA.HoTen from ACCOUNT, DOCGIA where ACCOUNT.MaDocGia = DOCGIA.MaDocGia