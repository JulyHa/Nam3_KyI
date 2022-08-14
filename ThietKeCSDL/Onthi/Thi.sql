--Câu 2: (2 điểm) Tạo thủ tục có đầu vào là mã câu lạc bộ, đầu ra là số bàn thắng của câu lạc bộ
alter procedure cau2 @maclb nvarchar(20), @sl int out as
begin
	select  @sl = count(GhiBanID)
	from TranDau_GhiBan where VaoLuoiNha is null 
	group by CauLacBoID having CauLacBoID = @maclb
end

declare @sl int
exec cau2 '111', @sl out
print @sl


--Câu 3: (1.5 điểm) Tạo hàm có đầu vào là tên câu lạc bộ, đầu ra là danh sách các cầu thủ của câu lạc bộ
--Cầu thủ ID Họ và tên Vị trí Quốc tịch Số áo
create function cau3(@ten nvarchar(100)) returns table as return (
	select CauThuID, HoVaTen, ViTri, QuocTich, SoAo
	from CAUTHU inner join CAULACBO on CAUTHU.CauLacBoID = CauLacBo.CauLacBoID
	where TenCLB = @ten
)
select * from cau3('Manchester United')

--Cau 4 Thêm các trường Số bàn ghi vào bảng cầu thủ. Tạo Trigger cập nhật tự động cho các 
--trường này với những bàn ghi vào lưới đội bạn.
alter table CauThu add SBG int
alter trigger cau4 on TranDau_GhiBan for insert, update, delete as begin
	declare @cathuid_is nvarchar(20), @cathuid_dl nvarchar(20), @ghiban nvarchar(20), @sl_is int, @sl_dl int
	select @cathuid_is = CauThuID, @sl_is = iif(VaoLuoiNha is null , 1, 0), @ghiban = GhiBanID from inserted
	select @cathuid_dl = CAUTHUID, @sl_dl = iif(VaoLuoiNha is null , 1, 0) from deleted
	if @cathuid_is is not null and @cathuid_dl is null
		update CAUTHU set SBG = iif(SBG is null , 0, SBG) + @sl_is where CauThuID = @cathuid_is

	if @cathuid_dl is not null and exists (select * from TRANDAU_GHIBAN where GhiBanID = @ghiban)
		update CAUTHU set SBG = iif(SBG is null , 0, SBG) + @sl_is - @sl_dl where CauThuID = @cathuid_is

	if @cathuid_dl is not null and @cathuid_is is null
		update CAUTHU set SBG = iif(SBG is null , 0, SBG) - @sl_dl where CauThuID = @cathuid_dl
end
select * from CAUTHU where CauThuID = '1100'
insert into TRANDAU_GHIBAN  values('1111', '72', '112', '27', '1100', null)
select * from CAUTHU where CauThuID = '1100'

update TRANDAU_GHIBAN set VaoLuoiNha = 1 where GhiBanID = '1111'
delete from TRANDAU_GHIBAN where GhiBanID = '1111'
--Câu 5: (1.5 điểm) Tạo View gồm các thông tin sau: Ngày thi đấu, Tên câu lạc bộ sân nhà, câu lạc bộ sân 
--khách, tên sân vận động trong đó tên câu lạc bộ (hoặc sân nhà, hoặc sân khách) là Manchester United 
--trong năm 2013
create view cau5 as
select NgayThiDau, (select TenCLB from CAULACBO where CauLacBoID = CLBNha) as TenCLBNha, (select TenCLB from CAULACBO where CauLacBoID = CLBKhach) 
		as TenCLBKhach, TenSan
from TRANDAU inner join SANVANDONG on TRANDAU.SanVanDongID = SANVANDONG.SanVanDongID
where YEAR(NgayThiDau) = 2013 and (CLBNha = any(select CauLacBoID from CAULACBO where TenCLB = 'Manchester United ')
								or CLBKhach = any(select CauLacBoID from CAULACBO where TenCLB = 'Manchester United '))

select * from cau5

--Câu 6: (1 điểm) Tạo login có tên là tên của anh/chị và gán quyền select trên bảng Câu lạc bộ.
exec sp_addlogin NguyenThiNgu, 123
---tao user
exec sp_adduser NguyenThiNgu, userNgu
--gan quyen select 
grant select on CauLacBo to userNgu


--Câu 7: (1 điểm) Do người dùng nhập nhầm nên Bảng Câu lạc bộ có hai câu lạc bộ Manchester United 
--với hai mã khác nhau. Một mã câu lạc bộ được sử dụng ở tất cả các bảng còn lại, một mã câu lạc bộ
--không được sử dụng ở bảng nào. Hãy tạo thủ tục xóa bản ghi không được sử dụng
create procedure cau7 as 
begin
	select distinct CAULACBO.CauLacBoID, TenCLB into #tam
	from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID
	where TenCLB = 'Manchester United '
	delete CAULACBO where TenCLB = 'Manchester United ' and CauLacBoID != all(select CauLacBoID from #tam)
end
exec cau7

create proc Cau7 
as begin
	delete from CAULACBO where CauLacBoID not in (select CauLacBoID from CAUTHU)
	delete from CAULACBO where CauLacBoID not in (select CauLacBoID from TRANDAU_GHIBAN)
end

exec Cau7