exec sp_addlogin nguyenngu, ngu3107
---tao user
exec sp_adduser A, userA
--gan quyen select 
grant select on Cau1 to userA
-- xoa user
exec sp_dropuser userA
-- test
select * from Cau1