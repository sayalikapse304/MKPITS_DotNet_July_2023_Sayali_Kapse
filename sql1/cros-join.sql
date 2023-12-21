create table customer26(cust_id int,cust_name varchar(40)not null,tel bigint)
create table order26(ordid int,orddate date,cust_id int,product_name varchar(40),qty int,rate int)

insert into customer26 values(234,'sayali',8080094895);
insert into customer26 values(456,'mrunal',7750589387);
insert into customer26 values(567,'mayuri',9421715685);
insert into customer26 values(895,'vrushali',8412006800);
select*from customer26

insert into order26 values(11,'2023-12-09',234,'Tv',1,45000);
insert into order26 values(22,'2023-12-03',456,'Refregetor',2,60000);

select*from order26

select customer26.cust_id,customer26.cust_name,customer26.tel,
order26.ordid,order26.orddate,order26.cust_id,order26.product_name,order26.qty,order26.rate
from customer26
CROSS JOIN order26 
where customer26.cust_id=order26.cust_id;

  
drop table customer26
drop table order26