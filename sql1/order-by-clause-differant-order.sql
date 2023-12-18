create table std9(first_name varchar (20),last_name varchar (20),city varchar (30))
insert into std9 values('payal','kapse','nagpur')
insert into std9 values('palk','goswami','ahamadadabad')
insert into std9 values('Achal','khan','Bhandar')
insert into std9 values('Asmi','lanjewar','lakhani')
select city,first_name,last_name from std9
order by city desc,first_name asc;
drop table std9