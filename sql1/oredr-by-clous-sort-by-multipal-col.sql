create table std8(first_name varchar (20),last_name varchar (20),city varchar (30))
insert into std8 values('payal','kapse','nagpur')
insert into std8 values('palk','goswami','ahamadadabad')
insert into std8 values('Achal','khan','Bhandar')
insert into std8 values('Asmi','lanjewar','lakhani')
select city,first_name,last_name from std8
order by city

drop table std8