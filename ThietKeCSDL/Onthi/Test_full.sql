
/*cau2*/
create procedure Cau2_thi @maclb char(20), @sobt int output
as
begin
	select @sobt = count(GhiBanID) from TRANDAU_GHIBAN  where VaoLuoiNha is null and CauLacBoID = N''
end

print @sobt

/*cau3*/
create function Cau3_Thi(@maclb varchar(70))
returns table as 
return( 
	select CAUTHUID, count(GhiBanID) as SoBanThang from TRANDAU_GHIBAN
	where VaoLuoiNha is null and CauLacBoID = @maclb
	group by CauThuID
)
select * from Cau3_Thi(101)

/*cau4*/
alter table CauThu add SoBanGhi int

create trigger cau4 on CauThu
for insert, update
as
begin
	declare @IDCauThu nvarchar(20), @SoBanGhi int
	select @IDCauThu = inserted.CauThuID, @SoBanGhi = count(TranDau_GhiBan.VaoLuoiNha) 
	from inserted join TranDau_GhiBan on inserted.CauThuID = TranDau_GhiBan.CauThuID
	group by inserted.CauThuID
	update CauThu set SoBanGhi = @SoBanGhi where CauThuID = @IDCauThu

end
--
/*cau5*/
create view cau5
as
	select CAULACBO.CauLacBoID, CAULACBO.TenCLB, CAUTHU.HoVaTen, SANVANDONG.TenSan, TranDau.NgayThiDau,
	TRANDAU_GHIBAN.ThoiDiemGhiBan, TRANDAU_GHIBAN.VaoLuoiNha
	from CauThu join CAULACBO on CAUTHU.CauLacBoID = CAULACBO.CauLacBoID
	join SANVANDONG on SANVANDONG.SanVanDongID = CAULACBO.SanVanDongID
	join TRANDAU on TRANDAU.SanVanDongID = SANVANDONG.SanVanDongID
	join TRANDAU_GHIBAN on TRANDAU_GHIBAN.CauThuID = CAUTHU.CauThuID
	join TRANDAU_CAUTHU on TRANDAU_CAUTHU.CauThuID = CAUTHU.CauThuID
	where CAULACBO.TenCLB = N'Manchester United'
select* from cau5

/*cau6*/
--tao login
exec sp_addlogin LeNgocSon, 123
---tao user
exec sp_adduser LeNgocSon, userSon
--gan quyen select 
grant select on cau5 to userSon
select *from cau5

/*cau7*/
select top 2 CAUTHU.HoVaTen, COUNT(GhiBanID) as 'SoBanThang' 
from CAUTHU join CAULACBO on CAUTHU.CauLacBoID = CAULACBO.CauLacBoID
join TRANDAU_GHIBAN on TRANDAU_GHIBAN.CauThuID = CAUTHU.CauThuID
where CAULACBO.TenCLB = N'Manchester United'
and VaoLuoiNha is null
group by CAUTHU.HoVaTen