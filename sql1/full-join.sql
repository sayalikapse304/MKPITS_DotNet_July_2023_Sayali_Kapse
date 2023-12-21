create table customer29(cust_id int,cust_name varchar(40)not null,tel bigint)
create table order29(ordid int,orddate date,cust_id int,product_name varchar(40),qty int,rate int)

insert into customer29 values(234,'sayali',8080094895);
insert into customer29 values(456,'mrunal',7750589387);
insert into customer29 values(567,'mayuri',9421715685);
insert into customer29 values(895,'vrushali',8412006800);
select*from customer29

insert into order29 values(11,'2023-12-09',234,'Tv',1,45000);
insert into order29 values(22,'2023-12-03',455,'Refregetor',2,60000);

select*from order29

select customer29.cust_id,customer29.cust_name,customer29.tel,
order29.ordid,order29.orddate,order29.cust_id,order29.product_name,order29.qty,order29.rate
from customer29
full OUTER JOIN order29 
on customer29.cust_id=order29.cust_id;

  