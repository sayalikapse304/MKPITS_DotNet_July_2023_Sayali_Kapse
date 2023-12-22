create table customer12(custid	int,
custname	varchar(20),
state	varchar(20),
city	varchar(20));
insert into customer12 values(11,'sayali','Maharashtra','Nagpur'),
                             (22,'payal','Mp','ujain'),
                             (33,'Achal','chatasigadh','Raipur'),
                             (44,'Asmi','Maharashtra','Nagpur'),
							 (55,'mohit','Mp','ujain ')

							 select *from customer12


	create table order12(orderid int,custid int,orderdate date,productname varchar(40));
	
	insert into order12 values(1,22,'2023-12-08','mouse'),
	                          (2,22,'2023-12-09','keyboard'),
							  (3,44,'2023-12-08','laptop'),
							  (1,11,'2023-12-08','computer'),
							  (1,33,'2023-12-08','laptop'),
							  (1,33,'2023-12-08','computer')
							  select *from order12

select custid
from customer12 where city='Nagpur'
select orderid,custid,orderdate,productname
from order12
where custid in 
(select custid from customer12 where city='ujain')
order by orderdate desc

drop table customer12
drop table order12