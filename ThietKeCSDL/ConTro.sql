Declare hs cursor for select mahs from DSHS
Open hs
Declare @mahs nvarchar(5), @dtb float
Fetch next from hs into @mahs
While (@@fetch_status = 0)
begin
select @dtb=round((toan*2+ly*2+hoa+ly)/6,2) from diem where MAHS=@mahs
update dshs set dtbc = @dtb where MAHS=@mahs
Fetch next from hs into @mahs
end
Close hs; Deallocate hs

select *from DSHS

--Diem trung binh thap nhat
Declare hs cursor for select mahs from DSHS
Open hs
Declare @mahs nvarchar(5), @toan float, @ly float, @hoa float, @van float, @dtn float
Fetch next from hs into @mahs
while(@@FETCH_STATUS = 0)
begin
select @toan=toan, @ly=ly, @hoa=hoa, @van=van from diem where MAHS=@mahs
set @dtn=@toan
if @dtn>@ly set @dtn=@ly
if @dtn>@hoa set @dtn=@hoa
if @dtn>@van set @dtn=@van
update dshs set dtn=@dtn where MAHS=@mahs
Fetch next from hs into @mahs
end
close hs; Deallocate hs
select * from DSHS


update DSHS set dtn=thapnhat from(select mahs,
	(case
		when toan<=ly and toan<=hoa and toan<=van then toan
		when ly<toan and ly<hoa and ly<van then ly
		when hoa<toan and hoa<ly and hoa<van then hoa
		else van
	end) as thapnhat from DIEM
	) bangA
where DSHS.MAHS=bangA.MAHS