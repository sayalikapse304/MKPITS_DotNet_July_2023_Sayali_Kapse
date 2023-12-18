create table std9(first_name varchar (20),last_name varchar (20),city varchar (30),state varchar (20))
insert into std9 values('payal','kapse','nagpur','Maharashtra')
insert into std9 values('palkkkkkkkkkk','goswami','ahamadadabad','chatishgadh')
insert into std9 values('Achal','khan','Bhandara','madhyapresh')

select city,first_name,last_name from std9
order by len(first_name)desc;
drop table std9