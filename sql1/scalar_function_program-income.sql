create table Tax(income1 int,tax_rate int)
insert into Tax values(500,50)
insert into Tax values(600,20)
select * from Tax
drop table tax
create function fun122
(@income1 int,@tax_rate int)
returns int
as begin return(select @income1 * @tax_rate)
end
select dbo.fun122(income1,tax_rate) as detail from Tax

