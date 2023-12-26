create table GateEmpCount(emp_id int,emp_name varchar(40))
insert into GateEmpCount values(1,'sayali')
insert into GateEmpCount values(2,'payal')
insert into GateEmpCount values(3,'asmi')
insert into GateEmpCount values(4,'achal')
select * from GateEmpCount

create proc emp
as
begin
select * from GateEmpCount
end 
exec emp
select count(emp_name)as 'total employee'from GateEmpCount

