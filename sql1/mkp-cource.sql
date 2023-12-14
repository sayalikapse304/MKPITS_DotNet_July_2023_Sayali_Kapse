create table mkp(id int primary key,sname varchar(20),
coursename varchar(20), city varchar(20))

insert into mkp values(1,'sayali','dotnet','nagpur')
insert into mkp values(2,'payal','dotnet','nagpur')
insert into mkp values(3,'asmi','dotnet','mumbai')
insert into mkp values(4,'mohit','java','nagpur')

select * from mkp

select coursename,count(*) from mkp
where city='nagpur'
group by coursename
drop table mkp