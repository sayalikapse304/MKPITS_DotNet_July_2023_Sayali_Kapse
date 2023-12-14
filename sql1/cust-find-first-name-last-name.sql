create table cust4(custid int,first_name varchar(20),last_name varchar(20))
insert into cust4 values(1,'sayali','kapse')
insert into cust4 values(3,'payal','kapse')
insert into cust4 values(2,'asmi','shanu')

select * from cust4 where custid=1
select * from cust4 where custid>1
select * from cust4 where custid>1 and custid<66
select * from cust4 where first_name='sayali' and last_name='kapse'
select *from cust4