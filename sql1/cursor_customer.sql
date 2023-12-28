create table customer43(cust_id int,cust_name varchar(50),phone bigint)
insert into customer43 values (11,'sayali',546434353)
insert into customer43 values (12,'payal',43693838)
insert into customer43 values (13,'asmi',13434)
insert into customer43 values (14,'achal',546434353)

select * from customer43

declare
@cust_id int,@cust_name varchar(40),@phone bigint

declare cursor_cust11 Cursor
for select
cust_id,cust_name,phone

from customer43
where cust_id>13;
open cursor_cust11

fetch next from cursor_cust11 into
@cust_id ,
@cust_name ,
@phone

while @@fetch_status=0
begin
print @cust_name+' '+CAST(@cust_id AS varchar)+' '+CAST(@phone as varchar);
fetch next from cursor_cust into
@cust_id, 
@cust_name ,
@phone

end;
close cursor_cust11;


