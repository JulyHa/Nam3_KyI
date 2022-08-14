-------------------------------------------BAI 1-------------------------------------------------------------------------
-- use BT1_TKCSDL
--1. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update bản ghi để chỉ cho phép nhập giá trị trong khoảng từ 0 đến 10
CREATE TRIGGER TriggerI_U ON DIEM
FOR INSERT, UPDATE AS
BEGIN
declare @mahs nvarchar(5), @toan float, @ly float, @hoa float, @van float 
select @mahs = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted 
if (@toan not between 0 and 10) or (@ly not between 0 and 10) or (@hoa not between 0 and 10)
 or (@van not between 0 and 10) rollback tran
END


--2. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động cập nhật 
--điểm trung bình của học sinh khi thêm mới hay cập nhật bảng điểm. Điểm trung bình= ((Toán +Văn)*2+Lý+Hóa)/6
CREATE TRIGGER TriggerIU_DTB ON DIEM
FOR INSERT, UPDATE AS
BEGIN
declare @mahs nvarchar(5), @toan float, @ly float, @hoa float, @van float 
select @mahs = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted 
update Diem set DTB = ((@toan+@van)*2+@ly+@hoa)/6 where @mahs = MAHS
END

select * from DIEM where MAHS = '00001'
update Diem set Hoa = 8 where MAHS = '00001'
select * from DIEM where MAHS = '00001'



--3. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại 
--học sinh, cách thức xếp loại như sau. Nếu Điểm trung bình>=5 là lên lớp, ngược lại là lưu ban
CREATE TRIGGER TriggerIU_XL ON DIEM
FOR INSERT, UPDATE AS
BEGIN
declare @mahs nvarchar(5), @toan float, @ly float, @hoa float, @van float 
select @mahs = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN from inserted 
update Diem set DTB = ((@toan+@van)*2+@ly+@hoa)/6 where @mahs = MAHS
declare @dtb float 
select @dtb = DTB from inserted
if @dtb >= 5 update Diem set XEPLoai = N'Lên lớp' where @mahs = MAHS
else update Diem set XEPLoai = N'Lưu ban' where @mahs = MAHS
END
select * from DIEM where MAHS = '00001'
update Diem set Hoa = 8 where MAHS = '00001'
select * from DIEM where MAHS = '00001'



--4. Viết một Trigger gắn với bảng DIEM dựa trên sự kiện Insert, Update để tự động xếp loại 
--học sinh, cách thức xếp loại như sau Xét điểm thấp nhất (DTN) của các 4 môn 
--- Nếu DTB>=5 và DTN>=4 là “Lên Lớp”, ngược lại là lưu ban
CREATE TRIGGER TriggerIU_XLDTN ON DIEM
FOR INSERT, UPDATE AS
BEGIN
	declare @mahs nvarchar(5), @toan float, @ly float, @hoa float, @van float, @mind float
	select @mahs = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN, @mind = case
		 when(TOAN < LY and Toan < Hoa and Toan < Van) then Toan 
		 when(LY < TOAN and LY < Hoa and LY < Van) then Ly
		 when(HOA < TOAN and HOA < LY and HOA < VAN) then HOA
		 else VAN
		 end from inserted 
	if @mind >= 4 and ((@toan+@van)*2+@ly+@hoa)/6 >= 5 update Diem set DTB = ((@toan+@van)*2+@ly+@hoa)/6, XEPLoai = N'Lên lớp' where @mahs = MAHS
	else update Diem set DTB = ((@toan+@van)*2+@ly+@hoa)/6, XEPLoai = N'Lưu ban' where @mahs = MAHS
END 
select * from DIEM where MAHS = '00001'
update Diem set Toan = 8 where MAHS = '00001'
select * from DIEM where MAHS = '00001'

--5. Viết một trigger xóa tự động bản ghi về điểm học sinh khi xóa dữ liệu học sinh đó trong DSHS
CREATE TRIGGER TriggerIU_XLDTN ON DSHS
FOR DELETE AS
BEGIN
	declare @mahs nvarchar(5)
	select @mahs = MAHS from deleted
	delete from Diem where MAHS = @mahs
END
select * from DSHS where MAHS = '00001'
delete from DSHS where MAHS = '00001'
select * from DSHS where MAHS = '00001'




--6. Viết nội thủ tục (Stored Procedure) cập nhật phần ghi chú là “Chuyển trường từ ngày 
--5/9/2016” cho học sinh có mã nhập vào trong bảng danh sách học sinh.
--nội thu tục
create procedure CN_DSHS @mahs nvarchar(5)
as
begin
	update DSHS set GhiChu = N'Đã chuyển trường từ ngày 5/9/2016'
	where MAHS = @mahs
end
exec CN_DSHS '00014'
--trigger
CREATE TRIGGER TriggerIU_GhiChu ON DSHS
FOR DELETE AS
BEGIN
	declare @mahs nvarchar(5)
	select @mahs=mahs from deleted
	update dshs set GHICHU=N'Chuyển trường từ ngày '+ cast(getdate() as char(12)) where MAHS=@mahs
END
select * from DSHS where MaHS = '00031'
exec CN_DSHS '00031'
select * from DSHS where MaHS = '00031'



--7. Tạo View báo cáo Kết thúc năm học gồm các thông tin: Mã học sinh, Họ và tên, Ngày sinh, 
--Giới tính, Điểm Toán, Lý, Hóa, Văn, Điểm Trung bình, Xếp loại
CREATE VIEW ThongTinHS AS _
select DSHS.MAHS, TEN, NGAYSINH, case when NU = 'False' then N'Nam' else N'Nữ' end as GioiTinh,
		 TOAN, LY, HOA, VAN, DTB, DSHS.XEPLOAI
from DSHS inner join DIEM on DSHS.MAHS = DIEM.MAHS
select * from ThongTinHS


--8. Tạo trường điểm thấp nhất trong bảng Điểm, tạo thủ tục cập nhật điểm thấp nhất cho trường 
--này của tất cả các bản ghi đã có (dùng con trỏ)
CREATE TABLE DIEM  add DTN float
CREATE PROCEDURE DTN 
AS
begin
	Declare hs cursor for select mahs from DSHS
	Open hs
	Declare @hs nvarchar(5), @toan float, @ly float, @hoa float, @van float, @dtn float
	Fetch next from hs into @hs
	while(@@FETCH_STATUS = 0)
	begin
		select @toan = toan, @ly = ly, @hoa=hoa, @van = Van from diem where MAHS = @hs
			set @dtn=@toan
			if @dtn > @ly  set @dtn = @ly
			if @dtn > @hoa  set @dtn = @hoa
			if @dtn > @van set @dtn = @van
		update Diem set DTN=@dtn where MAHS=@hs
		Fetch next from hs into @hs
	end
	close hs; Deallocate hs
End
exec DTN
select * from diem


--9. Tạo trigger cập nhật điểm thấp nhất mỗi khi insert, update một bản ghi vào bảng điểm.
CREATE TABLE DIEM  add DTN float
CREATE TRIGGER TriggerIU_DTN ON DIEM
FOR insert, update as
BEGIN
	declare @mahs nvarchar(5), @toan float, @ly float, @hoa float, @van float, @mind float
	select @mahs = MAHS, @toan = TOAN, @ly = LY, @hoa = HOA, @van = VAN, @mind = case
		 when(TOAN < LY and Toan < Hoa and Toan < Van) then Toan 
		 when(LY < TOAN and LY < Hoa and LY < Van) then Ly
		 when(HOA < TOAN and HOA < LY and HOA < VAN) then HOA
		 else VAN
		 end from inserted 
	update Diem set DTN = @mind where @mahs = MAHS
	
END 
select * from DIEM where MAHS = '00019'
update Diem set Toan = 8 where MAHS = '00019'
select * from DIEM where MAHS = '00019'


--10. Tạo View danh sách HOC SINH XUAT SAC bao gồm các học sinh có DTB>=8.5 và 
--DTN>=8 với các trường: Lop, Mahs, Hoten, Namsinh (năm sinh), Nu, Toan, Ly, Hoa, Van, 
--DTN, DTB (không dùng trường thấp nhất đã làm ở câu 7)
CREATE VIEW HSXS AS
select MALOP, DSHS.MAHS, year(NgaySinh) as NamSinh, NU, 
		DiemTN,DTB
from DSHS inner join (select MAHS,TOAN, LY, HOA,(((toan+van)*2+ly+hoa)/6) as DTB,(case
		 when(TOAN < LY and Toan < Hoa and Toan < Van) then Toan 
		 when(LY < TOAN and LY < Hoa and LY < Van) then Ly
		 when(HOA < TOAN and HOA < LY and HOA < VAN) then HOA
		 else VAN
		 end) as DiemTN from DIEM)A on A.MAHS = DSHS.MAHS
where DiemTN >= 8 and DTB >= 8.5
select * from HSXS 


--11. Tạo View danh sách HOC SINH DAT THU KHOA KY THI bao gồm các học sinh xuất 
--sắc có DTB lớn nhất với các trường: Lop, Mahs, Hoten, Namsinh, Nu, Toan, Ly, Hoa, Van, DTB
CREATE VIEW HSDTKKT AS
select MALOP, DSHS.MAHS, TEN, year(NgaySinh) as NamSinh, NU, 
	TOAN, LY, HOA,(((toan+van)*2+ly+hoa)/6) as DTB
from DSHS inner join DIEM ON DSHS.MAHS = DIEM.MAHS
where (((toan+van)*2+ly+hoa)/6) = (select MAX((((toan+van)*2+ly+hoa)/6)) as MAXD from DIEM)
select * from HSDTKKT



-------------------------------------------BAI 2-------------------------------------------------------------------------
-- use BT2_TKCSDL
--1. Tạo View gồm các field sau: MaDK, LoaiKH, TenKH,NgaySinh, Phai, DiaChi, DienThoai, SoPhong, LoaiPhong,
-- NgayVao, SoNgayO. Trong đó Số Ngày ở = Ngày Ra – Ngày Vao 
CREATE VIEW view_DS as
select tDangKy.MaDK, LoaiKH, NgaySinh, Phai, DiaChi, DienThoai, SoPhong, 
	LoaiPhong, NgayVao, datediff(day,NgayVao, NgayRa) as NgayO
from tDangKy inner join tChiTietKH on tDangKy.MaDk = tChiTietKH.MaDK
select * from view_DS


--2. Viết hàm có mã nhập vào là ngày vào trong năm 1999 và thông tin đưa ra như câu 1
CREATE FUNCTION dskh(@ngay int, @thang int) returns TABLE
as return(
	select tDangKy.MaDK, LoaiKH, NgaySinh, Phai, DiaChi, DienThoai, SoPhong, 
	LoaiPhong, NgayVao, datediff(day,NgayVao, NgayRa) as NgayO
	from  tDangKy inner join tChiTietKH on tDangKy.MaDk = tChiTietKH.MaDK
	where YEAR(NgayVao)=1999 and MONTH(NgayVao)=@thang and Day(NgayVao)=@ngay
	) 
select * from dskh(1,7)

--3. Viết truy vấn tạo bảng doanh thu (tDoanhThu) gồm các trường.Table: tDoanhThu
--MaDK      - Short Text -  Mã đăng ký
--LoaiPhong - Short Text  - Loại phòng
--SoNgayO	- Number	  - Số ngày ở
--ThucThu	- Number	  - Thực thu
CREATE TABLE tDoanhThu(
	[MaDK] [nvarchar](3) Not NULL,
	[LoaiPhong] [nvarchar](1) NULL,
	[SoNgayO] [int] NULL,
	[ThucThu] [int] NULL,
	 CONSTRAINT PK_tDoanhThu PRIMARY KEY CLUSTERED ( MaDK ASC	) 
)

--4. Tạo Trigger tính tiền và điền tự động vào bảng tDoanhThu như sau:
--Các trường lấy thông tin từ các bảng và các thông tin sau:
--Trong đó: 
--(a) Số Ngày Ở= Ngày Ra – Ngày Vào 
--(b) ThucThu: Tính theo yêu cầu sau: 
--Nếu Số Ngày ở <10 Thành tiền = Đơn Giá * Số ngày ở 
--Nếu 10 <=Số Ngày ở <30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.95 (Giảm5%) 
--Nếu Số ngày ở >= 30 Thành Tiền = Đơn Giá* Số Ngày ở * 0.9 (Giảm10%)
CREATE TRIGGER TriggerIU_DT ON tDangKy
FOR INSERT, UPDATE, DELETE AS
BEGIN
declare @madk nvarchar(3), @madk2 nvarchar(3), @ngayo int, @thucthu float, @dongia int, @loai nvarchar(3)
select @madk = Madk, @loai = LoaiPhong, @ngayo = datediff(day,NgayVao, NgayRa) from inserted 
select @dongia = DonGia from tLoaiPhong where @loai = LoaiPhong
select @thucthu= (case when @ngayo<10 then @dongia*@ngayo
						when @ngayo<30 then @dongia*@ngayo*0.95
						else @dongia*@ngayo*0.9 end)
select @madk2=madk from deleted
if exists (select madk from tDoanhThu where @madk = MaDk) and (@madk2 is not null)
	update tDoanhThu set LoaiPhong= @loai,SoNgayO= @ngayo,ThucThu= @thucthu
	where madk=@madk
if (@madk is not null) and not exists(select madk from tDoanhThu where madk=@madk)
	insert into tDoanhThu(MaDk,LoaiPhong, SoNgayO, ThucThu) values (@madk,@loai, @ngayo,@thucthu)	
if exists(select madk from tDoanhThu where madk=@madk2) and (@madk is null)
	delete tDoanhThu where MaDK=@madk2	
END