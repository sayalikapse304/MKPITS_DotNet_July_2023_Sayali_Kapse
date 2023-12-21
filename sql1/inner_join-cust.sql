create table customer22(cust_id int,cust_name varchar(40)not null,tel bigint)
create table order22(ordid int,orddate date,cust_id int,product_name varchar(40),qty int,rate int)

insert into customer22 values(234,'sayali',8080094895);
insert into customer22 values(456,'mrunal',7750589387);
insert into customer22 values(567,'mayuri',9421715685);
insert into customer22 values(895,'vrushali',8412006800);
select*from customer22

insert into order22 values(11,'2023-12-09',234,'Tv',1,45000);
insert into order22 values(22,'2023-12-03',456,'Refregetor',2,60000);
insert into order22 values(33,'2023-12-02',567,'Oven',1,15000);
insert into order22 values(44,'2023-12-04',895,'washingmachin',1,3000);
select*from order22

select customer22.cust_id,customer22.cust_name,customer22.tel,
order22.ordid,order22.orddate,order22.cust_id,order22.product_name,order22.qty,order22.rate
from customer22
inner join order22
on customer22.cust_id=order22.cust_id;

drop table customer22 
drop table order22