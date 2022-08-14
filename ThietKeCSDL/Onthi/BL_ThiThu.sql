use ThiThu_TKCSDL
--Câu 2: (1 điểm) Tạo thủ tục có đầu vào là ngày hóa đơn, đầu ra là số mặt hàng bán trong ngày đó
create procedure TT_cau2 @ngay datetime, @sl int out
As
	begin
		select @sl = count(MaSP) from HoaDon inner join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD group by NgayBan having NgayBan = @ngay
	end
select * from HoaDon inner join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD where NgayBan = '2015-03-17'
Declare @sl int
exec TT_cau2 '2015-03-17', @sl out
print @sl

--Câu 3: (1 điểm) Tạo hàm có đầu vào là mã khách hàng, năm, đầu ra là danh sách các hóa đơn khách hàng mua trong năm 
--Mã KH	Mã hóa đơn	Ngày mua	Tổng tiền
--0002	0006	2015-03-18 00:00:00.000	19480000
--0002	0012	2015-03-22 00:00:00.000	31680000
--0002	0020	2015-03-24 00:00:00.000	6000000
--…			
create function Fn_cau3(@mkh nvarchar(15), @nam int) returns table 
as return(
	select top(1000) KhachHang.MaKH, HoaDon.MaHD, NgayBan, sum(SLBan * GiaSP) as TongTien
	from KhachHang inner join HoaDon on KHachHang.MaKH = HoaDon.MaKH inner join ChiTietHD on HoaDon.MaHD = ChiTietHD.MaHD
	inner join SanPham on ChiTietHD.MaSP = SanPham.MaSP
	group by KhachHang.MaKH,HoaDon.MaHD, NgayBan having KhachHang.MaKH = @mkh and  YEAR(NgayBan) = @nam
	order by KhachHang.MaKH
)
select * from Fn_cau3('0002', 2015)
--Câu 4: (1 điểm) Tạo View thống kê hàng tồn dựa trên số lượng nhập và bán trong năm 2015
--Mã hàng	Tên hàng	Số lượng nhập	Số lượng xuất	Tồn
--…	…	…		
create view hangton as
select SanPham.MaSP as N'Mã hàng', TenSP as N'Tên hàng', sln as N'Số lượng nhập', slb as N'Số lượng xuất', (sln - slb)as N'Tồn'
from SanPham inner join 
(select MaSP, sum(SLN) as sln from ChiTietHDN inner join HoaDonNhap on HoaDonNhap.MaHDN = ChiTietHDN.MaHDN where Year(NgayNhap) = 2015 group by MaSP ) Nhap on SanPham.MaSP = Nhap.MaSP 
inner join (select MaSP, sum(SlBan) as slb from ChiTietHD inner join Hoadon on ChiTietHD.MaHD = Hoadon.MaHD where Year(NgayBan) = 2015 group by MaSP) Ban on Ban.MaSP = SanPham.MaSP

select * from hangton

--Câu 5: (1 điểm) Thêm các trường Số lượng hàng mua vào Hóa đơn. Tạo Trigger cập nhật tự động cho trường này. 
--(tính tổng số lượng bán của toàn bộ hàng trong mỗi hóa đơn)
alter table HoaDon add Slhangmua int 
create trigger soluongmua on ChiTietHD
FOR INSERT, UPDATE, Delete AS
begin 
	declare @sl int, @mahd_is nvarchar(20), @mahd_dl nvarchar(20)
	select @mahd_is = MaHD from inserted 
	select @mahd_dl = MaHD from deleted
	select @sl = sum(SlBan) from ChiTietHD group by MaHD having MaHD = @mahd_is or MaHD = @mahd_dl

	update Hoadon set Slhangmua = @sl where MaHD = @mahd_is or MaHD = @mahd_dl
end

select * from Hoadon

--Câu 6: (1 điểm) Tạo hai login A và B, gán quyền Select, Insert, Update cho A trên bảng Hóa đơn và chi tiết hóa đơn, 
--cho phép A được phép gán những quyền này cho người khác
--A gán quyền cho B, hãy đăng nhập dưới tài khoản B để kiểm tra


--Câu 7: (1 điểm)  Là một câu khó hơn trong giải quyết vấn đề, các em có thể dùng các câu lệnh sql cơ bản hoặc con trỏ, bảng tạm để giải quyết
