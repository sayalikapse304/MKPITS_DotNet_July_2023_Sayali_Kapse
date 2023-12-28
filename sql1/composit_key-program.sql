CREATE TABLE student87
(rollNumber INT, 
name VARCHAR(30), 
class VARCHAR(30), 
section VARCHAR(1), 
mobile VARCHAR(10),
PRIMARY KEY (rollNumber, mobile));

insert into student87 values(1,'amit','dotnet','A','1234567890')

insert into student87 values(2,'amit','dotnet','B','6252424432')
select * from student87
drop table student87