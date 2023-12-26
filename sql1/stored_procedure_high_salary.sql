create table emp99(emp_id int,emp_name varchar(40),salary int)
insert into emp99 values(11,'sayali',90000)
insert into emp99 values(12,'mohit',30000)
insert into emp99 values(13,'payal',40000)
insert into emp99 values(14,'asmi',20000)
insert into emp99 values(15,'nikhil',10000)
select * from emp99

create proc e11
(@sal as int)
as 
begin
select * from emp99
where salary>@sal
end;
exec e11 20000

