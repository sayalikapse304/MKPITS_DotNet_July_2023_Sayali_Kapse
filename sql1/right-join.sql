create table customer28(cust_id int,cust_name varchar(40)not null,tel bigint)
create table order28(ordid int,orddate date,cust_id int,product_name varchar(40),qty int,rate int)

insert into customer28 values(234,'sayali',8080094895);
insert into customer28 values(456,'mrunal',7750589387);
insert into customer28 values(567,'mayuri',9421715685);
insert into customer28 values(895,'vrushali',8412006800);
select*from customer28

insert into order28 values(11,'2023-12-09',234,'Tv',1,45000);
insert into order28 values(22,'2023-12-03',455,'Refregetor',2,60000);

select*from order28

select customer28.cust_id,customer28.cust_name,customer28.tel,
order28.ordid,order28.orddate,order28.cust_id,order28.product_name,order28.qty,order28.rate
from customer28
Right OUTER JOIN order28 
on customer28.cust_id=order28.cust_id;

  drop table customer28
  drop table order28
