create table std11(first_name varchar (20),last_name varchar (20),city varchar (30),state varchar (20))
insert into std11 values('payal','kapse','nagpur','Maharashtra')
insert into std11 values('palkkkkkkkkkk','goswami','ahamadadabad','chatishgadh')
insert into std11 values('Achal','khan','Bhandara','madhyapresh')

select top 40 percent first_name,last_name from std11
order by last_name ;

drop table std11