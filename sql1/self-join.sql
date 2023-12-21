 create table mmstudent(id int primary key identity,
     first_name varchar(10),last_name varchar(20),
     city varchar(10))
     
     insert into mmstudent values('sahil','sharma','nagpur'),
     ('ravi','kumar','nagpur'),
	 ('manoj','kumar','mumbai'),
     ('dinesh','sharma','mumbai'),
	 ('kishore','kumar','delhi')
     
     select * from mmstudent
     
     select s1.first_name,s2.last_name,s2.city
     from mmstudent s1,mmstudent s2
     where s1.id <> s2.id 
     and s1.city=s2.city
     order by s2.city