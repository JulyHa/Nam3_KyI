use BTL_QLThuVien
---------------------------------------------View----------------------------------------------------------------------
--Cau1:	Hiện thị các thủ thư của thư viện
--+Tên: DS_ThuThu
--+Kết quả: Hiển thị tất cả thông tin nhân viên (như: mã nv, tên nv, giới tính, ngày sinh, số điện thoại ) thư viện lên 1 bảng v
create view DS_ThuThu as
select * from ThuThu
select * from DS_ThuThu

--Cau 2: Hiện thị các độc giả bị phạt
--+Tên: DS_DocGiaBiPhat
--+Kết quả: Hiện thị  thông tin tất cả những độc giả bị phạt (như MaDocGia , TenDocGia, NgaySinh, GioiTinh, NoiSinh, TenLoai, Ten Khoa )
create view DS_DocGiaBiPhat as
select DocGia.MaDocGia , TenDocGia, NgaySinh, GioiTinh, NoiSinh, TenLoai, TenKhoa, MaPhat
from DocGia inner join LoaiDocGia on LoaiDocGia.MaLoai = DocGia.MaLoai inner join Khoa on Khoa.MaKhoa = DocGia.MaKhoa 
	inner join TT_Muon on DocGia.MaDocGia = TT_Muon.MaDocGia inner join TT_Tra on TT_Muon.MaMuon = TT_Tra.MaMuon 
where MaPhat is not null
select * from DS_DocGiaBiPhat
	
--•	Hiển thị các độc giả nợ tiền phạt
--+Tên: DS_NoPhat
--+Kết quả: Hiển thị các độc giả nợ tiền phạt (như Mã ĐG, Tên ĐG)
create view DS_DocGiaChuaNopPhat as
select DocGia.MaDocGia , TenDocGia, NgaySinh, GioiTinh, NoiSinh, TenLoai, TenKhoa
from DocGia inner join LoaiDocGia on LoaiDocGia.MaLoai = DocGia.MaLoai inner join Khoa on Khoa.MaKhoa = DocGia.MaKhoa 
	inner join TT_Muon on DocGia.MaDocGia = TT_Muon.MaDocGia inner join TT_Tra on TT_Muon.MaMuon = TT_Tra.MaMuon
where MaPhat not in(select MaPhat from Phat)

select * from DS_DocGiaChuaNopPhat

--Cau 3:	Hiển thị các tài liệu được mượn nhiều nhất
--+Tên: DS_TLMuonNhieuNhat
--+Kết quả: Hiển thị những tài liệu được mượn nhiều nhất (như Mã TL, Tên TL)
create view DS_TLMuonNhieuNhat as
select TaiLieu.MaTaiLieu,TenTaiLieu , sum(CT_TT_Muon.SoLuong) as SoLuongMuon from TaiLieu inner join CT_TT_Muon on TaiLieu.MaTaiLieu = CT_TT_Muon.MaTaiLieu
group by TaiLieu.MaTaiLieu, TenTaiLieu having sum(CT_TT_Muon.SoLuong) = (select Top(1) sum(SoLuong) from CT_TT_Muon group by MaTaiLieu)

select * from DS_TLMuonNhieuNhat

--Cau 4:Hiển thị thể loại phổ biến nhất
--+ Tên: DS_TLPhoBien
--+ Kết quả: Hiển thi một bản (Ma TL, Tên Thể loại)
create view DS_TLPhoBien as
select TheLoai.MaTheLoai, TenTheLoai, count(MaTaiLieu)as SoLuongTL from TaiLieu inner join TheLoai on TaiLieu.MaTheLoai = TheLoai.MaTheLoai
group by TheLoai.MaTheLoai, TenTheLoai 
having count(MaTaiLieu) = (select Top(1) count(MaTaiLieu) from TaiLieu inner join TheLoai on TaiLieu.MaTheLoai = TheLoai.MaTheLoai group by TheLoai.MaTheLoai order by count(MaTaiLieu) desc )


--Cau 5:Thống kê số lượng phiếu mượn của các tháng năm 2020
--+Tên : SLPhieuMuonCuaMoiThang
--+ Kết quả : Hiển thị (Tháng, số lượng phiếu)
create view SLPhieuMuonMoiThang as
	select
	ISNULL(count(case Month(NgayMuon) when 1 then MaMuon end), 0) as Thang1,
	ISNULL(count(case Month(NgayMuon) when 2 then MaMuon end), 0) as Thang2,
	ISNULL(count(case Month(NgayMuon) when 3 then MaMuon end), 0) as Thang3,
	ISNULL(count(case Month(NgayMuon) when 4 then MaMuon end), 0) as Thang4,
	ISNULL(count(case Month(NgayMuon) when 5 then MaMuon end), 0) as Thang5,
	ISNULL(count(case Month(NgayMuon) when 6 then MaMuon end), 0) as Thang6,
	ISNULL(count(case Month(NgayMuon) when 7 then MaMuon end), 0) as Thang7,
	ISNULL(count(case Month(NgayMuon) when 8 then MaMuon end), 0) as Thang8,
	ISNULL(count(case Month(NgayMuon) when 9 then MaMuon end), 0) as Thang9,
	ISNULL(count(case Month(NgayMuon) when 10 then MaMuon end), 0) as Thang10,
	ISNULL(count(case Month(NgayMuon) when 11 then MaMuon end), 0) as Thang11,
	ISNULL(count(case Month(NgayMuon) when 12 then MaMuon end), 0) as Thang12
	from TT_Muon where YEAR(NgayMuon) = 2020 

--Cau 6: Hiển thị những tài liệu tiếng nước ngoài
--+Tên DS_TLNuocNgoai
--+ Kết quả : Hiển thị MaTL, TenTL, Thể Loại, NgonNgu, Soluong, giá tiền.
create view DS_TLNuocNgoai as
select MaTaiLieu, TenTaiLieu, TenTheLoai, NgonNgu, SoLuong, GiaTien 
from TaiLieu inner join TheLoai on TheLoai.MaTheLoai = TaiLieu.MaTheLoai where NgonNgu = N'Nước ngoài'

select * from DS_TLNuocNgoai
--Cau 7: Thông kê số lượng tác giả của mỗi khoa
--+Tên : SLTGCuaMoiKhoa
--+Kết quả: Hiển thị MaKhoa , TenKhoa, SLTacGia
create view SLTGCuaMoiKhoa as
select Khoa.MaKhoa, TenKhoa, count(MaTacGia)as SLTacGia
from TacGia inner join Khoa on TacGia.MaKhoa = Khoa.MaKhoa
group by Khoa.MaKhoa, TenKhoa

select * from SLTGCuaMoiKhoa
--Cau 8: Hiển thị tài liệu được cả giáo viên và sinh viên mượn
--+ Tên: TLDuocMuon
--+Kết quả: Hiển thị mã tài liệu, tên tài liệu, mã tác giả, mã thể loại, mã nxb, năm xb, số trang, ngôn ngữ, giá tiền, số lượng
create view TLDuocMuon as 
select TaiLieu.MaTaiLieu, TenTaiLieu, MaTacGia, MaTheLoai, MaNXB, NamXB, SoTrang, NgonNgu, GiaTien, TaiLieu.SoLuong from TaiLieu inner join CT_TT_Muon on TaiLieu.MaTaiLieu = CT_TT_Muon.MaTaiLieu inner join TT_Muon on TT_Muon.MaMuon = CT_TT_Muon.MaMuon
inner join DocGia on TT_Muon.MaDocGia = DocGia.MaDocGia
inner join(select TaiLieu.MaTaiLieu from TaiLieu inner join CT_TT_Muon on TaiLieu.MaTaiLieu = CT_TT_Muon.MaTaiLieu inner join TT_Muon on TT_Muon.MaMuon = CT_TT_Muon.MaMuon
	inner join DocGia on TT_Muon.MaDocGia = DocGia.MaDocGia where MaLoai = 'L01') A on A.MaTaiLieu = TaiLieu.MaTaiLieu
where MaLoai='L02' 

--Cau 9: Thông kê số tài liệu Tiếng việt và Nước Ngoài
--+Tên: TiengViet_NuocNgoai
--Kết quả: Xuất ra số tài liệu của mỗi loại
create view TiengViet_NuocNgoai as
select NgonNgu, count(MaTaiLieu) as SLTaiLieu from TaiLieu 
group by NgonNgu

select * from TiengViet_NuocNgoai
--------------------------------------------------------------------Trigger-------------------------------------------------------------
--Cau 1:Viết trigger cập nhật phần ghi chú là "Đã ra trường" mỗi khi xóa một độc giả nào đó đối với LoaiDocGia là ‘Sinh viên’ (tạo thêm cột GhiChu cho bảng DocGia)
alter table DocGia add GhiChu nvarchar(50)
alter trigger tg_DeleteDG on DocGia after delete as begin
	DECLARE @madg nvarchar(10), @ten nvarchar(50), @ns date, @gt nvarchar(10), @nois nvarchar(30), @ml nvarchar(15), @mk nvarchar(15)
	select @madg=MaDocGia, @ten=TenDocGia , @ns=NgaySinh, @gt=GioiTinh, @nois = NoiSinh, @ml=MaLoai, @mk=MaKhoa from deleted
	insert into DocGia values (@madg, @ten, @ns, @gt, @nois, @ml, @mk, '')
	update DocGia set GhiChu = N'Đã ra trường' where MaDocGia = @madg and MaLoai = N'L01'
end
select * from DocGia where MaDocGia = 'DG30'
delete from DocGia where MaDocGia = 'DG30'
select * from DocGia where MaDocGia = 'DG30'

--Cau 2: Viết một Trigger gắn với bảng TaiLieu dựa trên sự kiện Insert, Update, Delete để tự động giảm số lượng tài liệu khi cho mượn
create trigger tg_GiamTL on CT_TT_Muon after insert, update, delete as begin 
	Declare @Sl_Them int, @matl_in nvarchar(15),@matl_de nvarchar(15), @sl_cu int
	select @Sl_Them=SoLuong, @matl_in = MaTaiLieu from inserted
	select @sl_cu = SoLuong, @matl_in = MaTaiLieu from deleted
	update TaiLieu set SoLuong = SoLuong - (isnull( @sl_Them,0) - isnull(@sl_cu,0)) where MaTaiLieu = @matl_in or MaTaiLieu=@matl_de
end 
select * from TaiLieu where MaTaiLieu = N'TL05'
update CT_TT_Muon set SoLuong = 3 where MaMuon = N'M02'
--delete from CT_TT_Muon where MaMuon = N'M06'
select * from TaiLieu where MaTaiLieu = N'TL05'

--Cau 3: Viết một Trigger gắn với bảng TaiLieu dựa trên sự kiện Insert, Update, delete để tự động tăng số lượng tài liệu khi độc giả trả
create trigger tg_TangTL on CT_TT_Tra after insert, update as begin 
	Declare @Sl_Them int, @matl_in nvarchar(15),@matl_de nvarchar(15), @sl_cu int
	select @Sl_Them=SoLuong, @matl_in = MaTaiLieu from inserted
	select @sl_cu = SoLuong, @matl_in = MaTaiLieu from deleted
	update TaiLieu set SoLuong = SoLuong + (isnull( @sl_Them,0) - isnull(@sl_cu,0)) where MaTaiLieu = @matl_in or MaTaiLieu=@matl_de
end 
select * from TaiLieu where MaTaiLieu = N'TL05'
update CT_TT_Tra set SoLuong = 2 where MaTra = N'T02'
select * from TaiLieu where MaTaiLieu = N'TL05'

--Câu 4: Viết một Trigger gắn với bảng TT_Muon dựa trên sự kiện delete để tự động xóa bản ghi ở CT_TT_Muon, TT_Tra và CT_TT_Tra
create trigger tg_XoaTTMuon on TT_Muon INSTEAD OF delete as begin 
	declare @mamuon nvarchar(15), @matra nvarchar(15)
	select @mamuon = MaMuon from deleted
	select @matra = MaTra from TT_Tra where @mamuon = MaMuon
	delete from CT_TT_Muon where @mamuon = Mamuon
	delete from TT_Tra where @mamuon = MaMuon
	delete from CT_TT_Tra where MaTra = @matra
	delete from TT_Muon where MaMuon = @mamuon
end
select * from TT_Muon where MaMuon=N'M01'
select * from CT_TT_Muon inner join TT_Tra on CT_TT_Muon.MaMuon = TT_Tra.MaMuon inner join CT_TT_Tra on TT_Tra.MaTra=CT_TT_Tra.MaTra
where CT_TT_Muon.MaMuon = 'M01'
delete from TT_Muon where MaMuon = 'M01'
select * from CT_TT_Muon inner join TT_Tra on CT_TT_Muon.MaMuon = TT_Tra.MaMuon inner join CT_TT_Tra on TT_Tra.MaTra=CT_TT_Tra.MaTra
where CT_TT_Muon.MaMuon = 'M01'

--Câu5: Xóa thủ thư thì cập nhật ghi chú là 'Nghỉ việc'
alter table ThuThu add GhiChu nvarchar(50)
alter trigger XoaThuThu on ThuThu after delete as begin 
	declare @matt nvarchar(10), @tentt nvarchar(30), @day date, @ns nvarchar(30), @gt nvarchar(10),@sdt nvarchar(15)
	select @matt = MaThuThu, @tentt=TenThuThu,@day=NgaySinh, @ns=NoiSinh, @gt=GioiTinh, @sdt=SDT from deleted 
	insert ThuThu values (@matt, @tentt, @day, @ns, @gt, @sdt,N'Nghỉ việc')
end
select * from ThuThu where MaThuThu = 'TT01'
delete from ThuThu where MaThuThu = 'TT01'
select * from ThuThu where MaThuThu = 'TT01'

--Câu 6: Không cho mượn nếu độc giả đã ra trường mượn sách
--+ Tên Trigger: TrgKiemSoatDocGiaMuonSach
--+ Kết quả: Không cho độc giả đã ra trường mượn
--	- Thực hiện kiểm tra dữ liệu
--	- Thực hiện rollback nếu có kết quả trả về.
CREATE TRIGGER tg_DGMuon ON TT_Muon
FOR INSERT, UPDATE AS
BEGIN
declare @madg nvarchar(10), @ghichu nvarchar(50)
select @madg = MaDocGia from inserted 
select @ghichu = GhiChu from DocGia where MaDocGia = @madg
if @ghichu = N'Đã ra trường' rollback tran
END
select * from DocGia

---------------------------------------------------Thủ tục-----------------------------------------------------------------------
--Câu 1:	Thêm độc giả: 
--+ Tên thủ tục: thêm độc giả
--+ Kết quả: Nhập thông tin độc giả vào bảng độc giả:
--	- Nhập thông tin về độc giả
--	- Chèn vào bảng Độc giả.
create procedure ThemDG @madg nvarchar(10), @ten nvarchar(50), @ns date, @gt nvarchar(10), @nois nvarchar(30), @ml nvarchar(15), @mk nvarchar(15) as 
begin
	insert into DocGia values (@madg, @ten, @ns, @gt, @nois, @ml, @mk, '')
end
exec ThemDG 'DG61',N'Nguyễn Thị Ngũ', '2001-07-31', N'Nữ', N'Hà Nội', 'L01','K01'
select * from DocGia where MaDocGia = 'DG61'

--Câu 2:	Thêm tài liệu
--+ Tên thủ tục: ThemTaiLieu
--+ Kết quả: Nhập thông tin tài liệu vào bảng tài liệu
--	- Nhập thông tin tài liệu
--	- Chèn thông tin vào bảng Tài liệu
create procedure ThemTL @matl nvarchar(15), @tentl nvarchar(50), @matloai nvarchar(10),@matg nvarchar(10), @manxb nvarchar(10),@mxb int, @sltb int, @st int,
	@tt nvarchar(max),@nn nvarchar(30), @sl int, @tien money as
begin
	INSERT [dbo].[TaiLieu] VALUES (@matl ,@tentl, @matloai, @matg, @manxb, @mxb, @sltb, @st, @tt, @nn, @sl, @tien)
end
exec ThemTL 'TL31', N'Đại học không phải là con đường duy nhất', 'TL04', 'TG01', 'NXB02', 2001, 2, 250, Null, N'Nước ngoài',100, 55000
select * from TaiLieu where MaTaiLieu = 'TL31'

--Cau 3:	Tính số người mượn trong ngày 05-01-2021
--+ Tên thủ tục: số người mượn trong ngày
--+ Kết quả: Kiểm tra số người mượn trong ngày.
--	- Nhấp ngày cần kiểm tra.
create procedure DGMuonNgay @day date, @sl int out as 
begin 
	select count(MaMuon)as SL from TT_Muon where @day = NgayMuon
end
declare @sl int 
exec DGMuonNgay '2021-01-05', @sl out
print @sl

--Câu 4:	Xóa tài liệu
--+tên thủ tục: xóa tài liệu
--+ Kết quả: Xóa tài liệu trong bảng tài liệu
--	- Nhập mã tài liệu hoặc tên tài liệu cần xóa
create procedure XoaTL @tl nvarchar(30) as
begin 
	delete from TaiLieu where MaTaiLieu = @tl or TenTaiLieu = @tl
end

select * from TaiLieu where MaTaiLieu=N'TL31'
exec XoaTL N'TL31'
select * from TaiLieu where MaTaiLieu=N'TL31'

--Câu 5:	Xóa độc giả
--+ Tên thủ tục: Xóa độc giả
--+ Kết quả: Xóa độc giả trong bảng độc giả
--	- Nhập mã độc giả hoặc tên độc giả cần xóa
create procedure XoaDG @madg nvarchar(30) as
begin 
	delete from DocGia where MaDocGia = @madg
end

select * from DocGia where MaDocGia = N'DG61'
exec XoaDG N'DG61'
select * from DocGia where MaDocGia = N'DG61'

--Câu 6:	Sửa thông tin của độc giả
--+Tên thủ tục: Sua_TTDG
--+ Kết quả: cho phép sửa thông tin của độc giả.
create procedure SuaDG @madg nvarchar(10),@ten nvarchar(30), @day date, @gt nvarchar(5), @ns nvarchar(30), @ml nvarchar(15), @mk nvarchar(15), @gc nvarchar(max) as
begin 
	update DocGia set  TenDocGia=@ten, NgaySinh=@day, GioiTinh=@gt, NoiSinh=@ns, MaLoai=@ml,
	MaKhoa=@mk, GhiChu=@gc where MaDocGia = @madg
end
select * from DocGia where MaDocGia = N'DG61'
exec SuaDG 'DG61',N'Nguyễn Thị Ngũ', '2001-07-31', N'Nữ', N'Ba Vì - Hà Nội', 'L02','K01', null
select * from DocGia where MaDocGia = N'DG61'


------------------------------------------------------------------------Hàm-------------------------------------------------

--Cau 1:	Hiển thị các độc giả mượn sách trong tháng bất kì
--+Tên : DS_TLMuonThang
--+ Kết quả : Hiển thị (Mã dg, tên độc giả, số lượng tl mượn, ngày mượn)
create function DS_TLMuonThang(@month int) returns table as return(
	select DocGia.MaDocGia, TenDocGia, count(MaTaiLieu) as SLMuon, NgayMuon 
	from TT_Muon inner join DocGia on TT_Muon.MaDocGia=DocGia.MaDocGia inner join CT_TT_Muon on CT_TT_Muon.MaMuon = TT_Muon.MaMuon
	where month(NgayMuon) = @month
	group by DocGia.MaDocGia, TenDocGia, NgayMuon
)
select * from DS_TLMuonThang(1)

--Cau 2:	Hiển thị các thu thu có tên được truyền vào
--+ Tên hàm: Hiển thị thủ thư
--+ Kết quả: Tìm kiếm tất cả thủ thư(mã nv, tên nv, ngày sinh nơi sinh , sdt)
create function HT_ThuThu(@ten nvarchar(30)) returns table as return(
	select MaThuThu, TenThuThu, NgaySinh, NoiSinh, GioiTinh, SDT from ThuThu where TenThuThu like N'%'+@ten+'%'
)
select * from HT_ThuThu(N'Đỗ')

--Câu 3:	Tính tổng tiền phạt của độc giả
--+ Tên hàm: Tổng nợ
--+ Kết quả: Tính tổng tiền nợ của độc giả
--	- Nhập vào mã độc giả
--	- sử dụng hàm tính tổng tiền còn nợ
create function TongPhat(@ten nvarchar(30)) returns table as return(
	select DocGia.MaDocGia, TenDocGia, sum(TienPhat)as TienPhat
	from Phat inner join TT_Tra on Phat.MaPhat=TT_Tra.MaPhat inner join TT_Muon on TT_Muon.MaMuon=TT_Tra.MaMuon
	inner join DocGia on DocGia.MaDocGia = TT_Muon.MaDocGia
	where TenDocGia like N'%'+@ten+'%'
	group by DocGia.MaDocGia, TenDocGia
)
select * from TongPhat(N'Lê')

--Câu 4:	Tìm các độc giả phải trả sach trước 1 ngày
--+Tên hàm: Trả sách
--+ Kết quả: Hiển thị các độc giả phải trả trước ngày nào đó (Mã Đg, Tên đg, hạn trả(ngày phải trả)
--	- Nhập vào ngày cần trả
create function TraSachTruoc(@day date) returns table as return(
	select DocGia.MaDocGia, TenDocGia, HanCha from TT_Muon inner join DocGia on TT_Muon.MaDocGia = DocGia.MaDocGia where HanCha < @day
)
select * from TraSachTruoc('2021-01-01')

--Câu 5:	Tìm tổng tiền của độc giả
--+ Tên hàm: DG_TongPhat
--+ Kết quả: Số tiền độc giả đã bị phạt
create function DG_TongPhat(@madg nvarchar(10)) returns money as
begin
	declare @tong int
	select @tong = sum(TienPhat) from Phat inner join TT_Tra on Phat.MaPhat=TT_Tra.MaPhat inner join TT_Muon on TT_Muon.MaMuon=TT_Tra.MaMuon
	where TT_Muon.MaDocGia = @madg
	return @tong
end
print dbo.DG_TongPhat(N'DG28')

--Câu 6: Tạo hàm có đầu vào là mã tài liệu, đầu ra là thông tin của sách đó
create function TimTl(@matl nvarchar(15)) returns table as return(
	select * from TaiLieu where MaTaiLieu = @matl
)
select * from TimTL('TL01')

--•	Tạo hàm có đầu vào là mã mượn, đầu ra là thông tin mượn như mã độc giả, mã tài liệu, số lượng 
create function DS_Muon(@mamuon nvarchar(10)) returns table as return(
	select DocGia.MaDocGia, TenDocGia, MaTaiLieu, SoLuong
	from TT_Muon inner join CT_TT_Muon on TT_Muon.MaMuon = CT_TT_Muon.MaMuon inner join DocGia on TT_Muon.MaDocGia=DocGia.MaDocGia
	where TT_Muon.MaMuon = @mamuon
)
select * from DS_Muon(N'M01')

--------------------------------------------Câu lệnh điều khiển dữ liệu----------------------------------------------------------------
--•	Kịch bản 1:
--- Tạo login A, B
--- Tạo user userA, userB tương ứng với login A, B
--- Gán quyền select, update cho userA trên bảng DocGia của CSDL QLThuVien, A có quyền trao quyền này cho người khác
--- Đăng nhập A để kiểm tra
--- Từ A, Trao quyền select cho userB trên bảng DocGia của CSDL QLThuVien
--- Đăng nhập B để kiểm tra
exec sp_addlogin A, 123

exec sp_adduser A, docgia

grant select on TaiLieu to docgia with grant option

--•	Kịch bản 2:
--- Tạo login A, B
--- Tạo user userA, userB tương ứng với login A, B
--- Gán quyền select, update cho userA trên bảng ThuThu của CSDL QLThuVien, A có quyền trao quyền này cho người khác
--- Đăng nhập A để kiểm tra
--- Từ A, Trao quyền select cho userB trên bảng ThuThu của CSDL QLThuVien
--- Đăng nhập B để kiểm tra
exec sp_addlogin B, 123
exec sp_addlogin C, 123

exec sp_adduser B, thuthu
exec sp_adduser C, tacgia


grant select, update, insert, delete on ChucVu to thuthu with grant option
grant select, update, insert, delete on CT_TT_Muon to thuthu with grant option
grant select, update, insert, delete on CT_TT_Tra to thuthu with grant option
grant select, update, insert, delete on DocGia to thuthu with grant option
grant select, update, insert, delete on Khoa to thuthu with grant option
grant select, update, insert, delete on LoaiDocGia to thuthu with grant option
grant select, update, insert, delete on NhaXuatBan to thuthu with grant option
grant select, update, insert, delete on Phat to thuthu with grant option
grant select, update, insert, delete on TacGia to thuthu with grant option
grant select, update, insert, delete on TaiLieu to thuthu with grant option
grant select, update, insert, delete on TheLoai to thuthu with grant option
grant select, update, insert, delete on ThuThu to thuthu with grant option
grant select, update, insert, delete on TT_Muon to thuthu with grant option
grant select, update, insert, delete on TT_Tra to thuthu with grant option

-- sau khi dang nhap vao B
grant select, update, insert on TaiLieu to tacgia with grant option
grant select, update on TacGia to tacgia with grant option


--•	Kịch bản 3:
--- Tạo login A, B, C
--- Tạo user userA, userB, userC tương ứng với login A, B, C
--- Gán quyền select, update cho userA trên bảng TacGia của CSDL QLThuVien, A có quyền trao quyền này cho người khác
--- Đăng nhập A để kiểm tra
--- Từ A, Trao quyền select cho userB trên bảng TacGia của CSDL QLThuVien
--- Đăng nhập B để kiểm tra
--- Từ B, Trao quyền select cho userC trên bảng TacGia của CSDL QLThuVien
--- Đăng nhập C để kiểm tra
exec sp_addlogin D, 123

exec sp_adduser D, nhaxuatban

grant select, update, insert on TaiLieu to nhaxuatban with grant option
grant select, update, insert on TacGia to nhaxuatban with grant option
grant select, update, insert on Khoa to nhaxuatban with grant option
grant select, update, insert on TheLoai to nhaxuatban with grant option
grant select, update, insert on NhaXuatBan to nhaxuatban with grant option
grant select on ChucVu to nhaxuatban with grant option

