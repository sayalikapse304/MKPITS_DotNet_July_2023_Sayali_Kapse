select* from products333
SELECT 
	product_name, 
	list_price
FROM 
	products333
ORDER BY 
	product_name

create proc prod2
as 
begin
select * from products333
end;

exec prod2

create proc mprod443
	as
	begin
	select * from products333 where model_year=2001
	end
	
	exec mprod443
	

alter proc prod1
as
begin
select product_name,list_price from products333
order by list_price
end;

exec prod1



	alter proc mprod443
	as
	begin 
	insert into products333 values('sport',3,4,2004,5600)
	select * from products333
	end
	exec mprod443

drop procedure mprod443
--------------------------------------------------------------------------------------------
create proc prod3444(@minprice as decimal)
as
begin
select * from products333
where list_price > @minprice
order by list_price
end;
exec prod3444 1200
-------------------------------------------------------------------------------------------------
create proc prod99(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from products333
where list_price > @minp and list_price < @maxp
and product_name LIKE '%' + @pn + '%'

order by product_name
end;

exec prod99 @minp=120,@maxp=6000,@pn='cluch'

----------------------------------------------------------------------------------------------------------
create proc prod7(@minp as decimal,@maxp as decimal)
as
begin
select * from products333
where list_price > @minp and list_price < @maxp
order by product_name
end;

exec prod7 120,5000
--------------------------------------------------------------------------------------------------------------
create proc prod8(@minp as decimal,@maxp as decimal,@pn as varchar(max))
as
begin
select * from products333
where list_price > @minp and list_price < @maxp
and product_name=@pn
order by product_name
end;

exec prod8 @minp=120,@maxp=6000,@pn='break'
---------------------------------------------------------------------------------------------------------------
create proc prod10(@minp as decimal=100,@maxp as decimal=1000,@pn as varchar(max))
as
begin
select * from products333
where list_price > @minp and list_price < @maxp
and product_name LIKE '%' + @pn + '%'

order by product_name
end;

exec prod10 @minp=120,@maxp=600,@pn='oil'
exec prod10 @minp=300,@pn='cluch'
exec prod10 @maxp=600,@pn='break'
drop procedure prod10
---------------------------------------------------------------------------------------------------