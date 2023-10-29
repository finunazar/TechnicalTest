CREATE DATABASE dbo;
   
USE  dbo;

CREATE TABLE OrderHeader
(
Order_ID int Identity(1,1) Primary Key, 
Order_No int, 
Order_Type varchar(1), 
Order_Date varchar(10)
);
CREATE TABLE Product
(
Part_No varchar(10) PRIMARY KEY,
Part_Group varchar(1)
);
CREATE TABLE OrderLines
(
Order_ID int FOREIGN KEY REFERENCES OrderHeader(Order_Id), 
Line_No int, 
Part_No varchar(10) FOREIGN KEY REFERENCES Product(Part_No),
Order_Qty int,
Currency varchar(10),
Unit_Price decimal(5,2),
Unit_Cost decimal(5,2),
[Status] int
);


INSERT INTO OrderHeader VALUES 
(100000,	'A', '09/01/2021'),
(100001,	'A', '10/01/2021'),
(100002,	'A', '11/02/2021'),
(100000,	'B', '12/02/2021'),
(100001,	'B', '13/03/2021'),
(100003,	'A', '14/03/2021')

INSERT INTO Product VALUES
('ABC-1','A'),
('ABC-2','A'),
('ABC-3','A'),
('XYZ-5','C'),
('ABC-4','A'),
('ABC-5','A'),
('DEF-1','B'),
('DEF-2','B'),
('DEF-3','B'),
('DEF-4','B'),
('DEF-5','B'),
('XYZ-1','C'),
('XYZ-2','C'),
('XYZ-3','C'),
('XYZ-4','C')

INSERT into OrderLines VALUES
(1,	1.000,	'ABC-1',	10	,'USD',	1.50,	1.00,	100),
(2,	1.000,	'DEF-1',	5	,'USD',	2.50,	1.50,	100),
(2,	2.000,	'ABC-5',	6	,'USD',	6.35,	6.00,	100),
(3,	1.000,	'DEF-4',	7	,'USD',	4.25,	4.50,	100),
(4,	1.000,	'ABC-4',	15	,'USD',	7.55,	5.00,	100),
(4,	2.000,	'ABC-5',	100	,'USD',	6.20,	6.00,	100),
(4,	3.000,	'DEF-4',	20	,'USD',	1.50,	4.50,	100),
(5,	1.000,	'DEF-5',	35	,'USD',	2.70,	3.00,	100),
(5,	2.000,	'XYZ-1',	40	,'USD',	8.20,	6.25,	100),
(6,	1.000,	'DEF-4',	50	,'USD',	5.00,	4.50,	100),
(6,	2.000,	'ABC-4',	60	,'USD',	6.75,	5.00,	100)

select * from OrderHeader 
select * from Product		 
select * from OrderLines 
