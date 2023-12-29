CREATE TABLE Product96 (  
     Product_id INT PRIMARY KEY,   
     Product_name VARCHAR(40),   
     Price INT,  
     Quantity INT  
    )  


    INSERT INTO Product96 VALUES(111, 'Mobile', 10000, 10),  
    (112, 'Laptop', 20000, 15),  
    (113, 'Mouse', 300, 20),  
    (114, 'Hard Disk', 4000, 25),  
    (115, 'Speaker', 3000, 20); 
	select * from product96

	 -- Start a new transaction    
    BEGIN TRANSACTION  
    -- SQL Statements  
    UPDATE Product96 SET Price = 5000 WHERE Product_id = 114  
    DELETE FROM Product96 WHERE Product_id = 115  
    --Undo Changes  
    ROLLBACK TRANSACTION  