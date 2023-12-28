create table empByDEpartment(dep_id int,dep_name varchar(50),emp_name varchar(60),phone bigint)

insert into empByDEpartment values(22,'electrinics','sayali',5965433)
insert into empByDEpartment values(22,'sayali','payal',5965433)
insert into empByDEpartment values(22,'sayali','asmi',5965433)
select * from empByDEpartment

create function f18()
returns table
as 
return (select * from empByDEpartment )

select * from f18()