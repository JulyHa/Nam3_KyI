--Cau2: Tạo thủ tục có đầu vào là mã câu lạc bộ, đầu ra là số bàn thắng của câu lạc bộ
create procedure cau2 @mclb nvarchar(20), @sl int out as 
begin 
	select count(GhiBanID)
	from TRANDAU_GHIBAN where VaoLuoiNha is null
	group by CauLacBoID having CauLacBoID = @mclb
end
Declare @sl int
exec Cau2 '111', @sl out
print @sl

-- cau 3 Tạo hàm có đầu vào là mã câu lạc bộ, đầu ra là danh sách các cầu thủ của câu lạc bộ
create function cau3(@maclb nvarchar(20)) returns table as return
(
	select CauThuID as N'Cầu thủ ID', HoVaTen as N'Họ và tên', ViTri as N'Vị trí', QuocTich as N'Quốc tịch', SoAo as N'Số áo'
	from CAUTHU where CauLacBoID = @maclb
)
select * from cau3('101')

-- cau 4 Thêm các trường Số trận đấu vào câu lạc bộ. Tạo Trigger cập nhật tự động cho trường này
alter table CauLacBo add STD int 
alter trigger cau4 on TranDau for insert, update, delete as begin 
	declare @nha_is nvarchar(20), @nha_de nvarchar(20), @khach_is nvarchar(20),@khach_de nvarchar(20),@matd nvarchar(20)
	select @nha_is = CLBNha, @khach_is = CLBKhach, @matd = TranDauID from inserted
	select @nha_de = CLBNha, @khach_de = CLBKhach from deleted
	if @nha_is is not null and @nha_de is null 
	begin 
		update CAULACBO set STD = isnull(STD, 0) + 1
		where CauLacBoID = @nha_is or CauLacBoID = @khach_is
	end
	if @nha_is is not null and exists (select CLBNha from TRANDAU where @matd = TranDauID)
	begin 
		if(@nha_is != @nha_de) 
			begin
				update CAULACBO set STD = isnull(STD, 0) + 1 where @nha_is = CauLacBoID
				update CAULACBO set STD = isnull(STD, 0) - 1 where @nha_de = CauLacBoID
			end
		if(@khach_is != @khach_de) 
		begin
			update CAULACBO set STD = isnull(STD, 0) + 1 where @khach_is = CauLacBoID
			update CAULACBO set STD = isnull(STD, 0) - 1 where @khach_de = CauLacBoID
		end
	end
	if @nha_de is not null and @nha_is is null 
	begin 
		update CAULACBO set STD = isnull(STD, 0) - 1
		where CauLacBoID = @nha_de or CauLacBoID = @khach_de
	end
end 
select * from CAULACBO where CauLacBoID = '111'
delete TRANDAU_GHIBAN where TranDauID = '100'
delete TRANDAU_CAUTHU where TranDauID = '100'
delete TRANDAU where TranDauID = '100'

-- Cau 5: Tạo View gồm các thông tin sau: Mã Câu lạc bộ, Tên CLB, Tên cầu thủ, Tên Sân, 
--Ngày Thi đấu, Thời điểm ghi bàn, bàn ghi lưới nhà với tên câu lạc bộ là Manchester United
create view cau5 as
select CauLacBo.CauLacBoID,TenCLB, HoVaTen, TenSan, NgayThiDau, ThoiDiemGhiBan, VaoLuoiNha
from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID
inner join TRANDAU_GHIBAN on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
inner join TRANDAU on TRANDAU_GHIBAN.TranDauID = TRANDAU.TranDauID
inner join SANVANDONG on TRANDAU.SanVanDongID = SANVANDONG.SanVanDongID
where TenCLB = 'Manchester United' 

-- cau 6:  Tạo login có tên là tên của anh/chị và gán quyền select trên bảng CAUTHU
exec sp_addlogin NguyenThiNgu, 123
---tao user
exec sp_adduser NguyenThiNgu, userNgu
--gan quyen select 
grant select on CAUTHU to userNgu
-- xoa user
exec sp_dropuser userNgu
exec sp_droplogin NguyenThiNgu
-- test
select * from CAUTHU

--cau 7: Do người dùng nhập nhầm nên Bảng Câu lạc bộ có hai câu lạc bộ Manchester United 
--với hai mã khác nhau. Một mã câu lạc bộ được sử dụng ở tất cả các bảng còn lại, một mã câu lạc bộ
--không được sử dụng ở bảng nào. Hãy tạo thủ tục xóa bản ghi không được sử dụng

create procedure cau7 as 
begin 
	select distinct CAULACBO.CauLacBoID, TenCLB into #t1
	from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID
	where TenCLB = 'Manchester United'
	delete CAULACBO where TenCLB = 'Manchester United' and CauLacBoID != all(select CauLacBoID from #t1)
end
exec Cau7

------------------------de 2----
-- cau 2: Tạo thủ tục có đầu vào là mã câu lạc bộ, đầu ra là số bàn thắng của câu lạc bộ
create procedure cau2_2 @maclb nvarchar(20), @sl int out as
begin 
	select @sl = count(TranDauID) 
	from TRANDAU_GHIBAN where VaoLuoiNha is null
	group by CAULACBOID having CauLacBoID = @maclb
end

declare @sl int
exec cau2_2 '101', @sl out
print @sl

--cau 3: Tạo hàm đưa ra danh sách các cầu thủ đã ghi bàn gồm hai trường mã cầu thủ và số
--bàn thắng cho câu lạc bộ với mã câu lạc bộ được người dùng đưa vào
create function cau2_3(@maclb nvarchar(20)) returns table as return
(
	select CauThuID, count(GhiBanID) as N'Số bàn thắng'
	from TRANDAU_GHIBAN
	where CauLacBoID = @maclb and VaoLuoiNha is null
	group by CauThuID
)
select * from cau2_3('101')

--cau4: Thêm các trường Số bàn ghi vào bảng cầu thủ. Tạo Trigger cập nhật tự động cho các 
--trường này với những bàn ghi vào lưới đội bạn
alter table CauThU add SoBanGhi int
create trigger cau4 on TranDau_GhiBan for insert, update, delete as
begin
	declare @sl_in int, @sl_del int, @maCT_in varchar(20), @maCT_del varchar(20), @ghiban varchar(20)
	select @ghiban = GhiBanID ,@sl_in = iif(VaoLuoiNha is null, 1, 0), @maCT_in = CauThuID from inserted
	select @sl_del = iif(VaoLuoiNha is null, 1, 0), @maCT_del = CauThuID from deleted
	if @maCT_in is not null and @maCT_del is null
	begin
		update CAUTHU set SBT = iif(SBT is null, 0, SBT) + @sl_in where CauThuID = @maCT_in
	end
	if @maCT_del is not null and exists (select * from TRANDAU_GHIBAN where GhiBanID = @ghiban)
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

--cau5: Tạo View gồm các thông tin sau: Mã Câu lạc bộ, Tên CLB, Tên cầu thủ, Tên Sân, 
--Ngày Thi đấu, Thời điểm ghi bàn, bàn ghi lưới nhà với tên câu lạc bộ là Manchester United
create view Cau5 as
select CAULACBO.CauLacBoID, TenCLB, HoVaTen, TenSan, NgayThiDau, ThoiDiemGhiBan, VaoLuoiNha
from CAULACBO inner join CAUTHU on CAULACBO.CauLacBoID = CAUTHU.CauLacBoID
inner join TRANDAU_GHIBAN on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
inner join TRANDAU on TRANDAU.TranDauID = TRANDAU_GHIBAN.TranDauID
inner join SANVANDONG on SANVANDONG.SanVanDongID = TRANDAU.SANVANDONGID
where TenCLB = N'Manchester United'

--Cau6: Tạo login có tên là tên của anh/chị và gán quyền select trên View ở câu 5.
exec sp_addlogin NguyenThiNgu, 123
---tao user
exec sp_adduser NguyenThiNgu, userNgu
--gan quyen select 
grant select on Cau5 to userNgu
-- xoa user
exec sp_dropuser userNgu
-- test
select * from Cau5

--Câu 7: (1 điểm) Đưa tên những cầu thủ ghi nhiều bàn thắng nhất và nhì của câu lạc bộ Manchester 
--United mà không có bàn ghi vào lưới nhà
select GhiBanID , CauThuID into #t3 
from TRANDAU_GHIBAN inner join CAULACBO on TRANDAU_GHIBAN.CauLacBoID = CAULACBO.CauLacBoID
where VaoLuoiNha is not null and TenCLB = 'Manchester United'

select top 10000 CauThuID, count(GhiBanID) as SoBanGhi into #t7
from TRANDAU_GHIBAN inner join CAULACBO on CAULACBO.CauLacBoID = TRANDAU_GHIBAN.CauLacBoID
where CauThuID != all(select CauThuID from #t3) and TenCLB = 'Manchester United'
group by CauThuID 
order by SoBanGhi desc

select top 1 CauThuID, SoBanGhi into #t10 from #t7
select top 1 CAUTHUID, SoBanGhi into #t11 from #t7 where CauThuID != all(select CauThuID from #t10)

select * from #t7 
where SoBanGhi = (select SoBanGhi from #t10) or SoBanGhi = (select SoBanGhi from #t11)


-- Cau 5
--NgayThiDau CLBNha CLBKhach TenSan Vong KetQua TrangThai
create view cau5 as 
select NgayThiDau, (select TenCLB from CAULACBO where CauLacBoID = CLBNha) as Nha, (select TenCLB from CAULACBO where CauLacBoID = CLBKhach) 
as Khach, TenSan, Vong, KetQua, TrangThai
 from TRANDAU inner join SANVANDONG on TRANDAU.SanVanDongID = SANVANDONG.SanVanDongID
 where Year(NgayThiDau) = 2013 and (CLBNha = any (select CauLacBoID from CAULACBO where TenCLB = 'Manchester United') 
								or CLBKhach = any (select CauLacBoID from CAULACBO where TenCLB = 'Manchester United'))