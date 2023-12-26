create table department12(id int,emp_name varchar(40),department_name varchar(40))
insert into department12 values(11,'sayali','electronics')
insert into department12 values(12,'payal','mechanical')
insert into department12 values(13,'asmi','civil')
insert into department12 values(14,'achal','electrical')
select * from department12
create proc dep12
(@department_name as varchar(40))
as begin
select * from department12
where emp_name=@department_name
end;
exec dep12 'sayali'
exec dep12 'payal'
