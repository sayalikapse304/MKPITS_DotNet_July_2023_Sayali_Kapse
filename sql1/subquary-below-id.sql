create table customer12131 (custid int,cust_name varchar(40),city varchar(40),salesman_id int)
insert into customer12131 values(1,'sami','mumbai',22) 
insert into customer12131 values(2,'mohit','delhi',23) 
insert into customer12131 values(3,'pranay','nagardhan',24) 
insert into customer12131 values(4,'nikhil','ramtek',25) 
insert into customer12131 values(5,'abhi','ramdham',26) 
insert into customer12131 values(6,'ved','mansar',27) 
select*from customer12131

create table salsman3212(salesman_id int,name varchar(40), city varchar(40),commission int)

insert into salsman3212 values(22,'sayali','nagpur',200)
insert into salsman3212 values(23,'sayali','bhandara',400)
insert into salsman3212 values(24,'achal','amaravati',500)
insert into salsman3212 values(25,'asmi','bhandara',600)
insert into salsman3212 values(26,'paru','nagpur',700)
insert into salsman3212 values(27,'dhani','akola',800)
select*from salsman3212

create table order31131(ord_no int,purch_amt int,ord_date date,customer_id int,salesman_id int)
insert into order31131 values(101,300,'2023-12-09',1,22)
insert into order31131 values(102,400,'2023-12-04',2,23)
insert into order31131 values(107,300,'2023-12-07',3,24)
insert into order31131 values(103,500,'2023-12-05',4,25)
insert into order31131 values(104,600,'2023-12-08',5,26)
insert into order31131 values(105,700,'2023-12-03',6,27)
select*from order31131
SELECT *
FROM customer12131
WHERE custid in
    (SELECT salesman_id -24
     FROM salsman3212
     WHERE name = 'dhani');