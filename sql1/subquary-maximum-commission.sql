

create table salsman123(salesman_id int,name varchar(40), city varchar(40),commission int)

insert into salsman123 values(22,'sayali','nagpur',200)
insert into salsman123 values(23,'payal','bhandara',400)
insert into salsman123 values(24,'achal','amaravati',500)
insert into salsman123 values(25,'asmi','bhandara',600)
insert into salsman123 values(26,'paru','nagpur',700)
insert into salsman123 values(27,'dhani','akola',800)
select*from salsman123


create table order313(ord_no int,purch_amt int,ord_date date,customer_id int,salesman_id int)
insert into order313 values(101,300,'2023-12-09',1,22)
insert into order313 values(102,400,'2023-12-04',2,23)
insert into order313 values(107,300,'2023-12-07',3,24)
insert into order313 values(103,500,'2023-12-05',4,25)
insert into order313 values(104,600,'2023-12-08',5,26)
insert into order313 values(105,700,'2023-12-03',6,27)
select*from order313

SELECT *
FROM salsman123
WHERE commission = (
SELECT MAX(commission) 
FROM salsman123);