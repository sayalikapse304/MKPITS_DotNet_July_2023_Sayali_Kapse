create table employee21(emp_id int identity primary key,emp_name varchar(30))

CREATE TABLE EmpLog 
	(LogID int IDENTITY(1,1) NOT NULL,
	EmpID int NOT NULL,
	Operation nvarchar(10) NOT NULL,
	UpdatedDate Datetime NOT NULL)

	create trigger empt
	on employee21
	for insert
	as
	insert into EmpLog(EmpID,Operation,UpdatedDate)
select emp_id,'insert',GETDATE() from inserted; 

insert into employee21 values('sayali')
insert into employee21 values('payal')
select * from employee21
select * from EmpLog



