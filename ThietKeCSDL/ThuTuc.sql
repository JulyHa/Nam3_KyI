--1.Cho biết tổng số tiền của một hóa đơn nào đó theo mã hóa đơn
create procedure Tong @MaHD nvarchar(50), @Tien money out
As
	begin
		select @Tien = SUM(SL * GiaBan) from CT_HOADON inner join HANGHOA on CT_HOADON.MaHH = HANGHOA.MaHH 
		where MaHD = @MaHD
	end

Declare @Tien money
exec Tong '0001', @Tien out
print @Tien
--2.Cho biết tổng số hóa đơn đã lập được trong một tháng của một năm nào đó
create procedure Dem @Thang int, @Nam int, @CNT int out
As
	begin
		set @CNT = 0
		select @CNT = Count(MaHD) from HOADON
		where @Thang = MONTH(NgayLap) and @Nam = Year(NgayLap)
	end

Declare @dem int
exec Dem 4, 2015, @dem out
print @dem
select * from HOADON
--3.Cho biết tổng số hóa đơn đã lập và tổng doanh thu đã bán hàng của một nhân viên trong một năm nào đó dựa vào mã nhân viên
--4.Cho biết tổng số lượng đã nhập và tổng số tiền đã nhập của một mặt hàng nào đó trong một năm nào đó dựa vào mã hàng hóa nào đó
--5.Tính tổng số tiền thu được của từng hóa đơn
--6.Tính tổng số lượng và tổng số tiền đã bán được của từng hàng hóa
--7.Tính tổng số lượng và tổng số tiền đã nhập của từng hàng hóa
--8.Tính tổng số hóa đơn đã lập trong từng tháng của năm 2015