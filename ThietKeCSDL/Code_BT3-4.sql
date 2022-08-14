use BT3_TKCSDL
------------------------------Bài 3-------------------------------------
--1. Tạo cơ sở dữ liệu trên, với các khóa chính như sau:
--ChiTietVanTai là MaVT, TrongTai là MaTrongTai, LoTrinh là MaLoTrinh 

--2. Tạo view gồm các trường SoXe, MaLoTrinh, SoLuongVT, NgayDi, NgayDen, ThoiGianVT, CuocPhi, Thuong. Trong đó: 
--• ThoiGianVT: là 1 nếu vận chuyển trong ngày, là (NgayDen-NgayDi) trong trường hợp ngược lại. 
--• CuocPhi: là SoLuongVT x DonGia x 105% nếu SoLuongVT nhiều hơn TrongTaiQD, là SoLuongVT x DonGia trong trường hợp ngược lại. 
--• Thuong: là 5% của CuocPhi nếu ThoiGianVT vuot ThoiGianQD, là 0 trong trường hợp ngược lại. 
Create view View_Cau2 as
Select SoXe,ChiTietVanTai.MaLoTrinh, SoLuongVT,TrongTaiQD, NgayDi, NgayDen, (case when NgayDen=NgayDi then 1 else DATEDIFF(day, NgayDi,NgayDen) end)as ThoiGianVT,
		ThoiGianQD ,(case when SoLuongVT>TrongTaiQD then SoLuongVT*DonGia *1.05 else SoLuongVT*DonGia end )as CuocThi,
		( case when (case when NgayDen=NgayDi then 1 else DATEDIFF(day, NgayDi,NgayDen) end) > ThoiGianQD 
			then (case when SoLuongVT>TrongTaiQD then (SoLuongVT*DonGia*1.05*0.05) else (SoLuongVT*DonGia*0.05) end )else 0 end)as Thuong
from ChiTietVanTai inner join TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai 
	inner join LoTrinh on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh
select * from View_Cau2

--3. Tạo view để lập bảng cước phí gồm các trường SoXe, TenLoTrinh, SoLuongVT, NgayDi, NgayDen, CuocPhi. 
create view view_Cau3 as
select SoXe, TenLoTrinh, SoLuongVT, NgayDi, NgayDen, (case when SoLuongVT>TrongTaiQD then SoLuongVT*DonGia *1.05 else SoLuongVT*DonGia end )as CuocPhi 
from ChiTietVanTai inner join LoTrinh on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh inner join TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai 
select * from view_Cau3

--4. Tạo view danh sách các xe có có SoLuongVT vượt trọng tải qui định, gồm các trường SoXe, TenLoTrinh, SoLuongVT, TronTaiQD, NgayDi, NgayDen. 
create view view_Cau4 as
select SoXe,  TenLoTrinh, SoLuongVT, TrongTaiQD, NgayDi, NgayDen
from ChiTietVanTai inner join LoTrinh on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh
	inner join TrongTai on ChiTietVanTai.MaTrongTai = TrongTai.MaTrongTai
where SoLuongVT > TrongTaiQD
select * from view_Cau4

--5. Tạo hàm có đầu vào là lộ trình, đầu ra là số xe, mã trọng tải, số lượng vận tải, ngày đi, ngày đến (SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen.)
create function Cau5 (@lotrinh nvarchar(255)) returns table
as return (
	select MaLoTrinh, SoXe, MaTrongTai, SoLuongVT, NgayDi, NgayDen from ChiTietVanTai where MaLoTrinh = @lotrinh
)
select * from Cau5('PK')

--6. Thiết lập hàm có đầu vào là số xe, đầu ra là thông tin về lộ trình
create function Cau6 (@soxe int) returns table
as return (
	select SoXe, LoTrinh.MaLoTrinh, TenLoTrinh, DonGia, NgayDi, NgayDen,SoLuongVT, ThoiGianQD
	from ChiTietVanTai inner join LoTrinh on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh where SoXe = @soxe
)
select * from Cau6('333')


--7. Thêm trường Thành tiền vào bảng chi tiết vận tải và tạo trigger điền dữ liệu cho trường này biết:
--Thành tiền = là SoLuongVT x DonGia x 105% nếu SoLuongVT nhiều hơn TrongTaiQD, là =  SoLuongVT x DonGia trong trường hợp ngược lại
ALTER TABLE ChiTietVanTai ADD ThanhTien money;

create trigger Trigger_TT on ChiTietVanTai
FOR INSERT, UPDATE AS
BEGIN
	declare @ma_trong_tai nvarchar(255), @ma_lo_trinh nvarchar(255), @so_luong_van_tai int, @don_gia int, @trong_tai_quy_dinh int, @mavt int
	select @mavt=mavt, @ma_trong_tai = MaTrongTai, @ma_lo_trinh = MaLoTrinh, @so_luong_van_tai = SoLuongVT from inserted
	select @don_gia = DonGia from dbo.LoTrinh where dbo.LoTrinh.MaLoTrinh = @ma_lo_trinh
	select @trong_tai_quy_dinh = TrongTaiQD from dbo.TrongTai where dbo.TrongTai.MaTrongTai = @ma_trong_tai
	update dbo.ChiTietVanTai set ThanhTien = iif(@so_luong_van_tai > @trong_tai_quy_dinh, @so_luong_van_tai * @don_gia * 1.05, @so_luong_van_tai * @don_gia) where mavt=@mavt
END
select * from ChiTietVanTai where SoXe = '123'
update ChiTietVanTai set SoLuongVT = 7 where SoXe = '123'
select * from ChiTietVanTai where SoXe = '123'

--8. Tạo thủ tục có đầu vào là mã lộ trình, năm vận tải, đầu ra là số tiền theo mã lộ trình đó
create procedure ThuTuc_Cau8 @malt nvarchar(255), @namVT int , @tien money out
As
	begin
		select @tien=0
		select @tien += iif(SoLuongVT > TrongTaiQD, SoLuongVT * DonGia * 1.05, SoLuongVT * DonGia)  
		from LoTrinh inner join ChiTietVanTai on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh
		inner join TrongTai on TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai
		where LoTrinh.MaLoTrinh = @malt and YEAR(NgayDi) = @namVT
	end
select * from ChiTietVanTai
Declare @Tien money
exec ThuTuc_Cau8 'PK', '2014', @Tien out
print @Tien
--9. Tạo thủ tục có đầu vào là số xe, năm vận tải, đầu ra là số tiền theo mã lộ trình đó
create procedure ThuTuc_Cau9 @maxe nvarchar(255), @namVT int , @tien money out
As
	begin
		select @tien=0
		select @tien += iif(SoLuongVT > TrongTaiQD, SoLuongVT * DonGia * 1.05, SoLuongVT * DonGia)  
		from LoTrinh inner join ChiTietVanTai on ChiTietVanTai.MaLoTrinh = LoTrinh.MaLoTrinh
		inner join TrongTai on TrongTai.MaTrongTai = ChiTietVanTai.MaTrongTai
		where SoXe = @maxe and YEAR(NgayDi) = @namVT
	end
select * from ChiTietVanTai where SoXe='333'
Declare @Tien money
exec ThuTuc_Cau9 '333', '2014', @Tien out
print @Tien


use BT4_TKCSDL
----------------------------------------Bài 4------------------------------------
--1. Tạo view KET QUA chứa kết quả thi của từng học sinh bao gồm các thông tin: SoBD, 
--HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem, XepLoai, DTDuThi
--Biết rằng: TongDiem = Toan + Van + AnhVan + DiemUT 
--XepLoai học sinh như sau: 
--* Giỏi nếu TongDiem>=24 và tất cả các môn >=7 
--* Khá nếu TongDiem>=21 và tất cả các môn >=6 
--* Trung Bình nếu TongDiem>=15 và tất cả các môn >=4 
--* Trượt nếu ngược lại 
create view KetQua as
select DiemThi.SoBD, Ho+' '+Ten as HoTen, iif(Phai=1, 'Nu', 'Nam') as Phai, DATEDIFF(YEAR, NTNS, GETDATE()) as Tuoi, Toan, Van, AnhVan,(Toan+Van+AnhVan+DiemUT) as TongDiem,
case when (Toan+Van+AnhVan+DiemUT) >=24 and Toan >=7 and (Van >= 7 and AnhVan>=7) then 'Gioi'
	when (Toan+Van+AnhVan+DiemUT) >= 21 and (Toan >=6 and Van >= 6 and AnhVan>= 6) then 'Kha'
	when (Toan+Van+AnhVan+DiemUT) >=15 and (Toan >=4 and Van >= 4 and AnhVan>= 4) then 'TrungBinh'
	else 'Truot'
end
as XepLoai, DanhSach.DTDuThi
from DanhSach inner join DiemThi on DanhSach.SoBD = DiemThi.SoBD
inner join ChiTietDT on DanhSach.DTDuThi = ChiTietDT.DTDuThi
select * from KetQua

--2. Tạo view GIOI TOAN – VAN – ANH VAN bao gồm các học sinh có ít nhất 1 môn 10 và 
--có TongDiem>=25 bao gồm các thông tin: SoBD, HoTen, Toan, Van, AnhVan, TongDiem, DienGiaiDT 
create view GIOI_TVA as
select DiemThi.SoBD, Ho+' '+Ten as HoTen, Toan, Van, AnhVan,(Toan+Van+AnhVan+DiemUT) as TongDiem, DienGiaiDT
from DanhSach inner join DiemThi on DanhSach.SoBD = DiemThi.SoBD
	inner join ChiTietDT on DanhSach.DTDuThi = ChiTietDT.DTDuThi
where (Toan = 10 or Van = 10 or AnhVan = 10) and (Toan+Van+AnhVan+DiemUT >= 25)
select * from GIOI_TVA

--3. Tạo view DANH SACH DAU (ĐẬU) gồm các học sinh có XepLoai là Giỏi, Khá hoặc 
--Trung Bình với các field: SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem, XepLoai, DTDuThi
create view DS_DAU as
select DiemThi.SoBD, Ho+' '+Ten as HoTen, iif(Phai=1, 'Nu', 'Nam') as Phai, DATEDIFF(YEAR, NTNS, GETDATE()) as Tuoi, Toan, Van, AnhVan,(Toan+Van+AnhVan+DiemUT) as TongDiem,
case when (Toan+Van+AnhVan+DiemUT) >=24 and Toan >=7 and (Van >= 7 and AnhVan>=7) then 'Gioi'
	when (Toan+Van+AnhVan+DiemUT) >= 21 and (Toan >=6 and Van >= 6 and AnhVan>= 6) then 'Kha'
	when (Toan+Van+AnhVan+DiemUT) >=15 and (Toan >=4 and Van >= 4 and AnhVan>= 4) then 'TrungBinh'
end as XepLoai, DanhSach.DTDuThi
from DanhSach inner join DiemThi on DanhSach.SoBD = DiemThi.SoBD
	inner join ChiTietDT on DanhSach.DTDuThi = ChiTietDT.DTDuThi
where (Toan+Van+AnhVan+DiemUT) >=15 and (Toan >=4 and Van >= 4 and AnhVan>= 4)
select * from DS_DAU

--4. Tạo view HOC SINH DAT THU KHOA KY THI bao gồm các học sinh “ĐẬU” có 
--TongDiem lớn nhất với các field: SoBD, HoTen, Phai, Tuoi, Toan, Van, AnhVan, TongDiem, DienGiaiDT
create view HS_TK as
select DiemThi.SoBD, Ho+' '+Ten as HoTen, iif(Phai=1, 'Nu', 'Nam') as Phai, DATEDIFF(YEAR, NTNS, GETDATE()) as Tuoi,
	 Toan, Van, AnhVan,(Toan+Van+AnhVan+DiemUT) as TongDiem, DienGiaiDT
from DanhSach inner join DiemThi on DanhSach.SoBD = DiemThi.SoBD
	inner join ChiTietDT on DanhSach.DTDuThi = ChiTietDT.DTDuThi
where (Toan+Van+AnhVan+DiemUT) = (select max(Toan+Van+AnhVan+DiemUT) as Tong from DanhSach inner join DiemThi on DanhSach.SoBD = DiemThi.SoBD
																		inner join ChiTietDT on DanhSach.DTDuThi = ChiTietDT.DTDuThi)
select * from HS_TK


--5. Tạo thủ tục có đầu vào là số báo danh, đầu ra là các điểm thi, điểm ưu tiên và tổng điểm
create procedure ThuTuc_Cau5 @sbd int, @toan real output, @van real output, @anhvan real output,
				@diemut float output, @tongdiem float output
As
	begin
		select @toan=Toan,@van=Van, @anhvan=AnhVan, @diemut=DiemUT, @tongdiem=(Toan+Van+AnhVan+DiemUT)
		from DanhSach inner join DiemThi on DanhSach.SoBD = DiemThi.SoBD
				inner join ChiTietDT on DanhSach.DTDuThi = DanhSach.DTDuThi
		where @sbd =DanhSach.SoBD
	end

Declare @toan real, @van real, @anh real, @dut real, @td real 
exec ThuTuc_Cau5 7, @toan output, @van output, @anh output, @dut output, @td output
print @toan
print @van
print @anh
print @dut
print @td 

--6. Tạo trigger kiểm tra xem việc nhập mã đối tượng dự thi trong bảng danh sách có đúng với bảng đối tượng dự thi không


--7. Thêm trường điểm ưu tiên và tổng điểm vào bảng Điểm thi. Tạo trigger cập nhật tự động 
--trường ưu tiên và tổng điểm mỗi khi nhập hay chỉnh sửa
alter table DiemThi add DiemUT float, TongDiem float 

create trigger Tigger_Cau7 on DiemThi
for INSERT, UPDATE AS
BEGIN
	declare @sbd int, @dtdt tinyint, @dt float, @dut float
	select @sbd = SoBD from inserted
	select @dtdt = DTDuThi from DanhSach where @sbd = SoBD
	select @dut = DiemUT from ChiTietDT where @dtdt = DTDuThi
	select @dt = (Toan+Van+AnhVan+@dtdt) from DiemThi where @sbd = SoBD
	update DiemThi set DiemUT = @dut, TongDiem = @dt where @sbd = SoBD
END
select * from DiemThi where SoBD = 7
update DiemThi set Toan = 10 where SoBD = 7
select * from DiemThi where SoBD = 7
--8. Tạo trigger xóa tự động bản ghi tương ứng ở bảng điểm khi xóa bản ghi ở danh sách
create trigger Tigger_Cau8 on DanhSach
for delete as
BEGIN
	declare @sbd int
	select @sbd = SoBD from deleted
	delete from DiemThi where @sbd = SoBD
END
select * from DiemThi where SoBD = 9
Delete DanhSach where SoBD = 9
select * from DiemThi where SoBD = 9