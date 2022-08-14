use BT7_TKCSDL
---------------------------BÀI 7 -----------------------------------------------------------------------------
--1. Tạo thủ tục chèn là các thông tin hóa đơn và chi tiết hóa đơn (giả sử chỉ tiết hóa đơn được
--lấy từ một bảng tạm), hãy đảm bảo việc cập nhật là đồng thời thành công hoặc không thành công (transaction)
create table #temp(
	MaHD nvarchar(5),
	MaSP tinyint,
	SoLuong tinyint,
	GiaBan money)
CREATE PROC NhapHD @MaHD nvarchar(5), @MaKH nvarchar(10), @MaNV int, @NgayLap datetime, @NgayGiao datetime
as
BEGIN
	 BEGIN TRAN;
		BEGIN TRY
			insert into tblHoaDon(MaHD, MaKH, MaNV, NgayLapHD, NgayGiaoHang) values (@MaHD, @MaKH, @MaNV, @NgayLap, @NgayGiao)
			INSERT INTO tblchitiethoadon(MaHD, MaSP, SoLuong, GiaBan) select MaHD, MaSP, SoLuong, GiaBan from #temp where MaHD=@MaHD
			COMMIT TRAN;
		END TRY
	BEGIN CATCH
		PRINT 'Error: ' + ERROR_MESSAGE();
		ROLLBACK TRAN;
	END CATCH;
	delete from #temp where MaHD=@MaHD
END;

select * from tblChiTietHoaDon
select * from tblKhachHang
select * from #temp
INSERT INTO #temp(MaHD, MaSP, SoLuong, GiaBan) values ('10144',1,20,10), ('10144',2,10,10), ('10144',3,30,10), ('10144',4,20,20)
delete from tblhoadon where MaHD='10144' or mahd='10145'
exec NhapHD '10144','AGROMAS', 1, '2021-02-03', '2021-02-03'

select * from tblhoadon where MaHD='10144'
select * from tblChiTietHoaDon where MaHD='10144'

--2. Tạo thủ tục có đầu vào là số hóa đơn, đầu ra là số tiền cần thanh toán
create procedure ThuTuc_Cau2 @mhd nvarchar(255), @tien money out
As
	begin
		select @tien=sum(SoLuong*GiaBan) from tblChiTietHoaDon where MaHD = @mhd
	end
select * from tblChiTietHoaDon
Declare @Tien money
exec ThuTuc_Cau2 '10144', @Tien out
print @Tien

--3. Tạo view QUA TANG gồm có các field sau: 
--MaHD, MaKH, NgayLapHD, TenSp, Soluong, Giaban, ThanhTien, Giamgia, Quatang. 
--Trong đó: ThànhTiền là Số lượng nhân giá bán. 
--Giảmgiá là 10% của ThànhTiền nếu thành tiền của sản phẩm không dưới 500 và Soluong sản phẩm bán phải từ 35 trở lên. 
--Quà tặng được tính như sau: nếu thành tiền ít hơn 1000 thì không được vé nào, từ 1000 đến <2000 được 
--1 vé ca nhạc, từ 2000 đến <3000 được 2 vé ca nhạc, v.v… (ví dụ: nếu thànhtiền = 4000 thì Quà tặng là 4 vé ca nhạc). Sắp xếp theo MaHD theo thứ tự tăng dần. 
create view view_Cau3 as
select Top(1000) tblHoaDon.MaHD, MaKH, NgayLapHD, TenSp, Soluong, Giaban,(SoLuong*GiaBan)as ThanhTien,
	iif((SoLuong*GiaBan > 500 and SoLuong >= 35) , SoLuong*GiaBan*0.1, 0)as Giamgia,
	cast((SoLuong * GiaBan / 1000) as int) as Quatang
from tblHoaDon inner join tblChiTietHoaDon on tblHoaDon.MaHD = tblChiTietHoaDon.MaHD
	inner join tblSanPham on tblChiTietHoaDon.MaSP = tblSanPham.MaSP
order by MaHD asc

select * from view_Cau3

--4. Thêm trường TongSLBan (tổng số lượng bán) và bảng sản phẩm. Tạo trigger cập nhật dữ 
--liệu tổng số sản phẩm đã bán cho trường này mỗi khi thêm, sửa, xóa một chi tiết hóa đơn.
alter table tblSanPham add TongSLBan int
CREATE trigger SoLuongBan on tblChiTietHoaDon
after insert,update,delete as
begin
	UPDATE tblSanpham set TongSLBan=isnull(TongSLBan,0)+(select SoLuong FROM inserted where MaSP=tblSanpham.MaSP)
	FROM inserted where tblSanpham.MaSP=inserted.MaSP

	 UPDATE tblSanpham set TongSLBan=isnull(TongSLBan,0)-(select SoLuong FROM deleted where MaSP=tblSanpham.MaSP)
	FROM deleted where tblSanpham.MaSP=deleted.MaSP
END

select * from tblChiTietHoaDon where masp=5
--delete from tblChiTietHoaDon where masp=5 and MaHD='10150'
INSERT INTO tblChiTietHoaDon values ('10144',5,15,10)
select * from tblChiTietHoaDon where masp=5
--5. Lập view tính doanh thu theo tháng của năm 2021
create view View_DT as
	select
	ISNULL(sum(case Month(NgayLapHD) when 1 then (SoLuong * GiaBan) end), 0) as Thang1,
	ISNULL(sum(case Month(NgayLapHD) when 2 then (SoLuong * GiaBan) end), 0) as Thang2,
	ISNULL(sum(case Month(NgayLapHD) when 3 then (SoLuong * GiaBan) end), 0) as Thang3,
	ISNULL(sum(case Month(NgayLapHD) when 4 then (SoLuong * GiaBan) end), 0) as Thang4,
	ISNULL(sum(case Month(NgayLapHD) when 5 then (SoLuong * GiaBan) end), 0) as Thang5,
	ISNULL(sum(case Month(NgayLapHD) when 6 then (SoLuong * GiaBan) end), 0) as Thang6,
	ISNULL(sum(case Month(NgayLapHD) when 7 then (SoLuong * GiaBan) end), 0) as Thang7,
	ISNULL(sum(case Month(NgayLapHD) when 8 then (SoLuong * GiaBan) end), 0) as Thang8,
	ISNULL(sum(case Month(NgayLapHD) when 9 then (SoLuong * GiaBan) end), 0) as Thang9,
	ISNULL(sum(case Month(NgayLapHD) when 10 then (SoLuong * GiaBan) end), 0) as Thang10,
	ISNULL(sum(case Month(NgayLapHD) when 11 then (SoLuong * GiaBan) end), 0) as Thang11,
	ISNULL(sum(case Month(NgayLapHD) when 12 then (SoLuong * GiaBan) end), 0) as Thang12
	from tblHoaDon inner join tblChiTietHoaDon on tblHoaDon.MaHD = tblChiTietHoaDon.MaHD
	where YEAR(NgayLapHD) = 2021

select * from View_DT

--6. Tạo thủ tục với đầu vào là ngày, đầu ra là số lượng hóa đơn, doanh thu của ngày đó
create procedure TT_DoanhThu @date date, @sl int out, @dt money out as
begin
	select @sl = count(DISTINCT  tblHoaDon.MaHD), @dt = sum(SoLuong*GiaBan)
	from tblHoaDon inner join tblChiTietHoaDon on tblHoaDon.MaHD = tblChiTietHoaDon.MaHD 
	where NgayLapHD = @date
	group by tblHoaDon.MaHD
	
end
select * from tblHoaDon inner join tblChiTietHoaDon on tblHoaDon.MaHD = tblChiTietHoaDon.MaHD 
 where NgayLapHD = '1997-01-06'

Declare @sl int, @dt money
exec TT_DoanhThu '1997-01-06', @sl out, @dt out
print @sl
print @dt

--7. Tạo hàm có đầu vào là mã hóa đơn, đầu ra là thông tin toàn bộ hóa đơn như chi tiết hóa đơn, thành tiền
CREATE FUNCTION tthd(@mahd nvarchar(5)) returns TABLE
as return(
	select tblHoaDon.MaHD, MaSP, SoLuong ,(SoLuong*GiaBan) as ThanhTien
	from tblHoaDon inner join tblChiTietHoaDon on tblHoaDon.MaHD=tblChiTietHoaDon.MaHD
	where tblHoaDon.MaHD = @mahd
	) 
select * from tthd('10144')

--8. Tạo hàm có đầu vào là tỉnh, đầu ra là số nhân viên của tỉnh đó
create function slnv(@tinh nvarchar(60)) returns int
as begin 
	DECLARE @sl int
	select @sl = count(MaNV) from tblNhanVien where DiaChi  like N'%'+@tinh+'%'
	return @sl
end
select * from tblNhanVien
print dbo.slnv(N'Q5')
--9. Tạo thủ tục xóa các hóa đơn mà không có chi tiết hóa đơn
create procedure TT_Cau9 as
begin
	delete from tblHoaDon where MaHD not in (select distinct MaHD from tblChiTietHoaDon)
end
select * from tblHoaDon where MaHD not in (select distinct MaHD from tblChiTietHoaDon)
exec TT_Cau9

--10. Thêm trường TriGiaHD (trị giá hóa đơn) vào bảng Hóa đơn. Tạo trigger cập nhật dữ liệu cho trường này mỗi khi thêm, sửa, xóa một chi tiết hóa đơn
alter table tblHoaDon add TriGiaHD money
alter trigger tg_tghd on tblChiTietHoaDon after insert, update, delete as
begin
	declare @masp nvarchar(15), @mahd_is nvarchar(5), @mahd_dl nvarchar(5), @tt money
	select @mahd_is = MaHD, @masp = MaSP from inserted
	select @mahd_dl =MaHD, @masp = MaSP from deleted
	if (@mahd_is is not null)
		begin
			select @tt = (select sum(SoLuong* GiaBan) as TT from tblChiTietHoaDon where MaHD = @mahd_is group by MaHD)
			update tblHoaDon set TriGiaHD = @tt where MaHD = @mahd_is
		end
	if(@mahd_is is null)and exists(select MaHD from tblHoaDon where MaHD = @mahd_dl)
	begin
		select @tt = (select sum(SoLuong* GiaBan) as TT from tblChiTietHoaDon where MaHD = @mahd_dl group by MaHD)
		update tblHoaDon set TriGiaHD = @tt where MaHD = @mahd_dl
	end
end
select * from tblChiTietHoaDon
select * from tblHoaDon where MaHD = '10144'
update tblChiTietHoaDon set SoLuong = 40 where MaHD = '10144'and MaSP = '1'
--delete tblChiTietHoaDon where MaHD = '10148'and MaSP = '7'
select * from tblHoaDon where MaHD = '10144'

---------------------------BÀI 8 -----------------------------------------------------------------------------
use BT8_TKCSDL

--1. Tạo hàm đầu vào là chức vụ đầu ra là những nhân viên cùng chức vụ đó
create function fs_nv(@chucvu nvarchar(50)) returns table 
as return(
	select tNhanVien.MaNV, HO+' '+TEN as HoTen, iif(Phai = 'False', N'Nam', N'Nữ')as Phai,ChucVu, NTNS, NgayBD, MaPB, HINH, GHICHU
	from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV where @chucvu = ChucVu
)
select * from fs_nv('NV')

--2. Tạo báo cáo bảng Phụ cấp, trợ cấp cho nhân viên gồm có các trường sau: MaNV, Ho, Ten, ChucVu, ThamNien, Luong, TroCap, PhuCapTN. 
--Trong đó:
--Thâm Niên là số năm làm việc của nhân niên trong công ty, được tính dựa và ngày bắt đầu 
--làm việc (NgayBD). 
--Lương là hệ số lương (HSLuong) nhân 250000. 
--Trợ Cấp là 150000 cho các nhân viên có ngày sinh trước ngày 30/4/75. 
--Phụ Cấp TN (phụ cấp thâm niên): chỉ được tính cho các nhân viên có thâm niên không dưới 5 
--năm, và cứ mỗi năm thâm niên sau 5 năm được tính 50000 (ví dụ: ThamNien=5 có 
--PhuCapTN=50000, 6 năm – 100000, 7 năm – 150000, 8 năm – 200000 v.v…) 
select tNhanVien.MaNV,HO+' '+TEN as HoTen,NTNS,ChucVu,year(getdate())-year(NgayBD) as ThamNien,HSLuong*250000 as Luong,
case 
	when year(NTNS)<=1975 and month(NTNS)<=4 and day(NTNS)<30 then 1500000 else 0
end as TroCap,
case 
	when year(getdate())-year(NgayBD)=5 then 50000
	when year(getdate())-year(NgayBD)>5 then (year(getdate())-year(NgayBD)-5)*50000
end as PhuCapTN into PhuCap
from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV=tChiTietNhanVien.MaNV
select * from PhuCap

--3. Tạo hàm với đầu vào là năm, đầu ra là số nhân viên sinh vào năm đó
create function fs_slnv(@nam int) returns int as begin
	DECLARE @sl int
	select @sl = count(MaNV)from tNhanVien where YEAR(NTNS) = @nam
	return @sl
end
select * from tNhanVien
print dbo.fs_slnv(1966)  

--4. Tạo hàm với đầu vào là số thâm niên đầu ra là danh sách nhân viên có thâm niên đó
create function fs_tlnv(@tl int) returns table as return(
	select MaNV, HO+' '+TEN as HoTen, iif(Phai = 'False', N'Nam', N'Nữ')as Phai, NTNS, DATEDIFF(Year, NgayBD, GetDate()) as ThamLien, MaPB, HINH, GHICHU 
	from tNhanVien where @tl =DATEDIFF(Year, NgayBD, GetDate())
)
select * from fs_tlnv(31)
--5. Tạo hàm đưa ra thông tin về nhân viên được tăng lương của ngày hôm nay (giả sử 3 năm lên lương 1 lần)
create function fs_nvtl() returns table as return
	select * from tNhanVien where DATEDIFF(Year, NgayBD, GETDATE())%3 = 0 and MONTH(GETDATE())=MONTH(NgayBD) and Day(GETDATE())=DAY(NgayBD)

select * from fs_nvtl()
--6. Tạo thủ tục nhập đồng thời nhân viên và chi tiết nhân viên (dùng transaction).
create procedure ps_nv_ctnv @manv nvarchar(10), @ho nvarchar(30), @ten nvarchar(20), @phai bit, @ntns date, @ngaybd date,@mapb nvarchar(5), @hinh image,
 @ghichu nvarchar(MAX), @chucvu nvarchar(5), @hsluong int, @md nvarchar(6)
as
BEGIN
	 BEGIN TRAN;
		BEGIN TRY
			insert into tNhanVien values (@manv, @ho, @ten, @phai, @ntns,@ngaybd,@mapb, @hinh, @ghichu)
			INSERT INTO tChiTietNhanVien values(@manv, @chucvu, @hsluong, @md, DATEDIFF(YEAR,@ngaybd,GETDATE()))
			COMMIT TRAN;
		END TRY
	BEGIN CATCH
		PRINT 'Error: ' + ERROR_MESSAGE();
		ROLLBACK TRAN;
	END CATCH;
END;
select * from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV where tNhanVien.MaNV = '061'
exec ps_nv_ctnv '061', N'Nguyễn Thị', N'Ngũ', 1, '2001-07-31', '2020-02-10','VP', null,'Ngũ xinh gái ahihi','NV',10, 'B1'
select * from tNhanVien inner join tChiTietNhanVien on tNhanVien.MaNV = tChiTietNhanVien.MaNV where tNhanVien.MaNV = '061'

--7. Thêm trường ThamNien vào bảng chi tiết nhân viên. Tạo thủ tục tính thâm niên cho nhân 
--viên và cập nhật vào trường ThamNien. (ThamNien=năm hiện tại – năm vào).
alter table tChiTietNhanVien add ThamNien int
create procedure pc_ThamNien as begin
	update tChiTietNhanVien set ThamNien = datediff(YEAR,NgayBD, GETDATE()) from tChiTietNhanVien inner join tNhanVien on tChiTietNhanVien.MaNV = tNhanVien.MaNV
end
exec pc_ThamNien
select * from tChiTietNhanVien
--8. Tạo thủ tục tính nhân viên mỗi phòng ban, số nhân viên nam, số nhân viên nữ với mã phòng ban là tham số đầu vào
create procedure pc_conut @mapb nvarchar(10), @slnv int out, @sln int out, @slnu int out
as begin
	select @slnv = count(MaNV) from tNhanVien where MaPB = @mapb
	select @sln = count(MaNV) from tNhanVien where PHAI = 0
	select @slnu = count(MaNV) from tNhanVien where PHAI  = 1
end
declare @slnv int, @sln int, @slnu int
exec pc_conut 'VP', @slnv out, @sln out, @slnu out
print @slnv
print @sln
print @slnu
