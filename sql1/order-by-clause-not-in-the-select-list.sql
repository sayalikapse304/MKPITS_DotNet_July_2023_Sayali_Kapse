create table std9(first_name varchar (20),last_name varchar (20),city varchar (30),stated varchar (20))
insert into std9 values('payal','kapse','nagpur','Maharashtra')
insert into std9 values('palk','goswami','ahamadadabad','chatishgadh')
insert into std9 values('Achal','khan','Bhandara','madhyapresh')

select city,first_name,last_name,stated from std9
order by stated;
drop table std9