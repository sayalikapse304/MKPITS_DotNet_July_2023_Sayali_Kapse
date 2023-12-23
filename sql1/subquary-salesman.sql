create table salsman1(salesman_id int,name varchar(40), city varchar(40),commission int)

insert into salsman1 values(22,'sayali','nagpur',200)
insert into salsman1 values(23,'payal','bhandara',400)
insert into salsman1 values(24,'achal','amaravati',500)
insert into salsman1 values(25,'asmi','bhandara',600)
insert into salsman1 values(26,'paru','nagpur',700)
insert into salsman1 values(27,'dhani','aloka',800)
select*from salsman1


create table order444(ord_no int,purch_amt int,ord_date date,customer_id int,salesman_id int)
insert into order444 values(101,300,'2023-12-09',1,22)
insert into order444 values(102,400,'2023-12-04',2,23)
insert into order444 values(107,300,'2023-12-09',3,24)
insert into order444 values(103,500,'2023-12-05',4,25)
insert into order444 values(104,600,'2023-12-08',5,26)
insert into order444 values(105,700,'2023-12-03',6,27)
select*from order444

SELECT *
FROM order444
WHERE salesman_id =
    (SELECT salesman_id 
     FROM salsman1 
     WHERE name='paru');

