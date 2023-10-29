USE  dbo;

--1.Write a well-structured tSQL query to calculate the Total profits per order, for orders of type = A ordered in the year 2021.

SELECT 
	OL.Order_ID, 
	SUM(OL.Order_Qty*(OL.Unit_Price-OL.Unit_Cost)) AS Total_Profits
FROM OrderLines OL 
INNER JOIN OrderHeader OH
	ON OL.Order_ID = OH.Order_ID
WHERE OH.Order_Type = 'A'
	AND OH.Order_Date LIKE '%2021%'
GROUP BY OL.Order_ID
Order By OL.Order_ID

--2.Write a well-structured tSQL query to insert a new product called TWY-1 of group type X in the products table

INSERT INTO Product 
VALUES ('TWY-1', 'X')


--3.Write a well-structured tSQL query to calculate the Total profits and Total Qty by Part Group for orders in February 2021.

SELECT 
	P.Part_Group, 
	SUM(OL.Order_Qty) AS TOTAL_QTY, 
	SUM(OL.Order_Qty*(OL.Unit_Price-OL.Unit_Cost)) AS Total_Profits
FROM OrderLines OL 
INNER JOIN OrderHeader OH
	ON OL.Order_ID = OH.Order_ID
INNER JOIN Product P 
	ON P.Part_No = OL.Part_No
WHERE OH.Order_Date LIKE '%/02/2021%'
GROUP BY P.Part_Group

--4.Write a well-structured tSQL query to Update the order line status to 999 for the orders 100000 and 100001 and order type B.

update OrderLines set Status = 999
where Order_ID IN 
	(SELECT Order_ID 
	 FROM OrderHeader 
	 WHERE Order_Type ='B' AND Order_No between 100000 AND 100001 )