create table emp87(emp_contact bigint,emp_name varchar(40),emp_email varchar(60))
insert into emp87 values(8080094895,'sayali','sayali123')
insert into emp87 values(5780094895,'payal','payal123')
insert into emp87 values(3980094895,'asmi','asmi123')
insert into emp87 values(8990094895,'achal','achal123')
select * from emp87
create function fun_emp2
    (  
       @emp_Contact varchar(50),  
       @emp_name varchar(50),  
       @emp_email varchar(50)  
    )  
    returns varchar(150)  
    as  
    begin return(select @emp_Contact+ ' ' +@emp_name + ' ' + @emp_email)  
    end  

select dbo.fun_emp2(emp_contact,emp_name,emp_email) as detail from emp87