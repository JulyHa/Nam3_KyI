use QLBongDa_TenSV
--Câu 1: (1 điểm) Anh (chị) hãy tạo cơ sở dữ liệu QLBongDa_TênAnh(chị)_MaSV có quan hệ như dưới 
--đây từ các câu lệnh tạo CSDL được lưu trong thư mục: CSDLQLBongDa:
--Ghi chú: Bảng TRANDAU_GHIBAN, Trường VaoLuoiNha là true nếu bàn thắng của cầu thủ ghi vào lưới 
--nhà, là null nếu ghi vào lưới đội bạn.


--Câu 2: (2 điểm) Tạo thủ tục có đầu vào là mã câu lạc bộ, đầu ra là số bàn thắng của câu lạc bộ
create procedure ThuTuc_Cau2 @maclb nvarchar(255), @sobanthang money out
As
	begin
		select count(GhiBanID)
		from CAULACBO inner join TRANDAU_GHIBAN on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
		where VaoLuoiNha is null
		group by CAULACBO.CauLacBoID having CAULACBO.CauLacBoID = @maclb
	end
Declare @sl money
exec ThuTuc_Cau2 '111', @sl out
print @sl

--Câu 3: (1.5 điểm) Tạo hàm đưa ra danh sách các cầu thủ đã ghi bàn gồm hai trường mã cầu thủ và số
--bàn thắng cho câu lạc bộ với mã câu lạc bộ được người dùng đưa vào
--mã cầu thủ   Số bàn thắng
--1158			12
--1159			18
alter function Cau3(@maclb nvarchar(20))returns table
as return (
	select CauThuID, count(GhiBanID) as SoBanThang
	from TRANDAU_GHIBAN where VaoLuoiNha is null and CauLacBoID = @maclb
	group by CauThuID 
)
select * from Cau3('101')

--Câu 4: (2 điểm) Thêm các trường Số bàn ghi vào bảng cầu thủ. Tạo Trigger cập nhật tự động cho các trường này với những bàn ghi vào lưới đội bạn
alter table CauThU add SoBanGhi int
alter trigger cau4 on TranDau_GhiBan for insert, update, delete as
begin
	declare @sl_in int, @sl_del int, @maCT_in varchar(20), @maCT_del varchar(20), @ghiban varchar(20)
	select @ghiban = GhiBanID ,@sl_in = iif(VaoLuoiNha is null, 1, 0), @maCT_in = CauThuID from inserted
	select @sl_del = iif(VaoLuoiNha is null, 1, 0), @maCT_del = CauThuID from deleted
	if @maCT_in is not null and @maCT_del is null
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) + @sl_in where CauThuID = @maCT_in
	end
	if @maCT_in is not null and exists (select * from TRANDAU_GHIBAN where GhiBanID = @ghiban)
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) + @sl_in - @sl_del where CauThuID = @maCT_in
	end
	if @maCT_del is not null and @maCT_in is null
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) - @sl_del where CauThuID = @maCT_del
	end

end
insert into TranDau_GhiBan values( '1111','71', '112', '27','1100', NULL)
update TRANDAU_GHIBAN set VaoLuoiNha = NULL where GhiBanID = '1111'
delete from TranDau_GhiBan where GhiBanID = '1111'
select * from CAUTHU where CauThuID = '1100'

--Câu 5: Tạo View gồm các thông tin sau: Mã Câu lạc bộ, Tên CLB, Tên cầu thủ, Tên Sân, 
--Ngày Thi đấu, Thời điểm ghi bàn, bàn ghi lưới nhà với tên câu lạc bộ là Manchester United
--CLBid		TenCLB				TenCauThu		TenSan				NgayThiDau				 ThoiDiemGhiBan		 VaoLuoiNha
--101		Manchester United	Paul Scholes	Old Trafford		2012-11-10 17:30:00.000		45					NULL
--101		Manchester United	Paul Scholes	Old	Trafford		2012-11-10 17:30:00.000		53					NULL
--101		Manchester United	Paul Scholes	Old Trafford		2012-11-10 17:30:00.000		61					NULL
create view Cau5 as
select CAULACBO.CauLacBoID, TenCLB, HoVaTen, TenSan, NgayThiDau, ThoiDiemGhiBan, VaoLuoiNha
from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID
inner join TRANDAU_GHIBAN on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
inner join TRANDAU on TRANDAU.TranDauID = TRANDAU_GHIBAN.TranDauID
inner join SANVANDONG on SANVANDONG.SanVanDongID = TRANDAU.SANVANDONGID
where TenCLB = N'Manchester United'

--Câu 6:(1 điểm) Tạo login có tên là tên của anh/chị và gán quyền select trên View ở câu 5.
exec sp_addlogin NguyenThiNgu, 123
---tao user
exec sp_adduser NguyenThiNgu, userNgu
--gan quyen select 
grant select on Cau5 to userNgu
select * from cau5

--Câu 7:(1 điểm) Đưa tên những cầu thủ ghi nhiều bàn thắng nhất và nhì của câu lạc bộ Manchester United mà không có bàn ghi vào lưới nhà
select top 2  CAUTHU.CauThuID, count(GhiBanID) as sl
from CAUTHU inner join TRANDAU_GHIBAN on CAUTHU.CauThuID = TRANDAU_GHIBAN.CauThuID
inner join CAULACBO on CAUTHU.CauLacBoID = CAULACBO.CauLacBoID
where CAUTHU.CauTHUID != all(select CauThuID from TRANDAU_GHIBAN where VaoLuoiNha is not null) and TenCLB = N'Manchester United'
group by CAUTHU.CauThuID
order by sl desc

----Cách 2
select top 1  CAUTHU.CauThuID, count(GhiBanID) as sl into #top1
from CAUTHU inner join TRANDAU_GHIBAN on CAUTHU.CauThuID = TRANDAU_GHIBAN.CauThuID
inner join CAULACBO on CAUTHU.CauLacBoID = CAULACBO.CauLacBoID
where CAUTHU.CauTHUID != all(select CauThuID from TRANDAU_GHIBAN where VaoLuoiNha is not null) and TenCLB = N'Manchester United'
group by CAUTHU.CauThuID
order by sl desc

select top 1  CAUTHU.CauThuID, count(GhiBanID) as sl into #top_2
from CAUTHU inner join TRANDAU_GHIBAN on CAUTHU.CauThuID = TRANDAU_GHIBAN.CauThuID
inner join CAULACBO on CAUTHU.CauLacBoID = CAULACBO.CauLacBoID
where CAUTHU.CauTHUID != all(select CauThuID from TRANDAU_GHIBAN where VaoLuoiNha is not null) and TenCLB = N'Manchester United'
group by CAUTHU.CauThuID having count(GhiBanID) != all (select sl from #top1)
order by sl desc

select * from #top1
select * from #top_2

select CAUTHU.CauThuID, count(GhiBanID) as sl
from CAUTHU inner join TRANDAU_GHIBAN on CAUTHU.CauThuID = TRANDAU_GHIBAN.CauThuID
inner join CAULACBO on CAUTHU.CauLacBoID = CAULACBO.CauLacBoID
where CAUTHU.CauTHUID != all(select CauThuID from TRANDAU_GHIBAN where VaoLuoiNha is not null) and TenCLB = N'Manchester United'
group by CAUTHU.CauThuID having count(GhiBanID) = all (select sl from #top1) or count(GhiBanID) = all (select sl from #top_2)
order by sl desc