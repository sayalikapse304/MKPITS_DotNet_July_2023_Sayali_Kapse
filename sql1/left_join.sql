create table customer27(cust_id int,cust_name varchar(40)not null,tel bigint)
create table order27(ordid int,orddate date,cust_id int,product_name varchar(40),qty int,rate int)

insert into customer27 values(234,'sayali',8080094895);
insert into customer27 values(456,'mrunal',7750589387);
insert into customer27 values(567,'mayuri',9421715685);
insert into customer27 values(895,'vrushali',8412006800);
select*from customer27

insert into order27 values(11,'2023-12-09',234,'Tv',1,45000);
insert into order27 values(22,'2023-12-03',456,'Refregetor',2,60000);

select*from order27

select customer27.cust_id,customer27.cust_name,customer27.tel,
order27.ordid,order27.orddate,order27.cust_id,order27.product_name,order27.qty,order27.rate
from customer27
LEFT OUTER JOIN order27 
on customer27.cust_id=order27.cust_id;

  
