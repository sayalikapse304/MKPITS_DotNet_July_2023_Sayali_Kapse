create table productQty1115(id int,region varchar(30),product varchar(40),year int,quantity int,price int)
insert into productQty1115 values(11,'East','computer',2023,2,50000)
insert into productQty1115 values(12,'East','computer',2024,1,60000)
insert into productQty1115 values(13,'west','laptop',2025,2,30000)
insert into productQty1115 values(14,'North','harddisk',2020,2,10000)
insert into productQty1115 values(15,'East','mouse',2023,1,70000)
insert into productQty1115 values(16,'North','computer',2023,2,90000)
select*from productQty1115

 
create function f1()
returns table
as 
return (select * from productQty1115)

select * from f1()