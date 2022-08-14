use QLBongDa_TenSV

-- Cau 4
alter table CauThU add SoBanGhi int
create trigger cau4 on TranDau_GhiBan for insert, update, delete as
begin
	declare @sl_in int, @sl_del int, @maCT_in varchar(20), @maCT_del varchar(20), @ghiban varchar(20)
	select @ghiban = GhiBanID ,@sl_in = iif(VaoLuoiNha is null, 1, 0), @maCT_in = CauThuID from inserted
	select @sl_del = iif(VaoLuoiNha is null, 1, 0), @maCT_del = CauThuID from deleted
	if @maCT_in is not null and @maCT_del is null
	begin
		update CAUTHU set SoBanGhi = iif(SoBanGhi is null, 0, SoBanGhi) + @sl_in where CauThuID = @maCT_in
	end
	if @maCT_del is not null and exists (select * from TRANDAU_GHIBAN where GhiBanID = @ghiban)
	begin
		update CAUTHU set SoBanGhi = iif(SoBanGhi is null, 0, SoBanGhi) + @sl_in - @sl_del where CauThuID = @maCT_in
	end
	if @maCT_del is not null and @maCT_in is null
	begin
		update CAUTHU set SoBanGhi = iif(SoBanGhi is null, 0, SoBanGhi) - @sl_del where CauThuID = @maCT_del
	end

end
insert into TranDau_GhiBan values( '1111','71', '112', '27','1100', NULL)
update TRANDAU_GHIBAN set VaoLuoiNha = 1 where GhiBanID = '1111'
delete from TranDau_GhiBan where GhiBanID = '1111'
select * from CAUTHU where CauThuID = '1100'


-- Cau 7
select DISTINCT CauThu.CauLacBoID as clb into #cbl
from CAUTHU inner join TRANDAU_GHIBAN on CAUTHU.CauThuID = TRANDAU_GHIBAN.CauThuID
inner join TRANDAU on TRANDAU.TranDauID = TRANDAU_GHIBAN.TranDauID
select CauLacBoID into #xoa from CAULACBO where CauLacBoID != all(select clb from #cbl)
delete from CAULACBO where CauLacBoID = any(select CauLacBoID from #xoa)

-- Cau 5
--NgayThiDau CLBNha CLBKhach TenSan Vong KetQua TrangThai
create view cau5 as 
select NgayThiDau, (select TenCLB from CAULACBO where CauLacBoID = CLBNha) as Nha, (select TenCLB from CAULACBO where CauLacBoID = CLBKhach) as Khach, TenSan, Vong, KetQua, TrangThai
 from TRANDAU inner join SANVANDONG on TRANDAU.SanVanDongID = SANVANDONG.SanVanDongID
 where Year(NgayThiDau) = 2013 and (CLBNha = any (select CauLacBoID from CAULACBO where TenCLB = 'Manchester United') 
								or CLBKhach = any (select CauLacBoID from CAULACBO where TenCLB = 'Manchester United'))