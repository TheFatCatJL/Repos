Use NorthwindFatCatJL
go
--Question 1 
--Create a View Customer1998 containing Customer IDs and names, Product IDs and names for customers who have made orders on the year 1998.
/* View creation
CREATE VIEW Customer1998 as
Select Customers.CustomerID, Customers.CompanyName, ProductID, ProductName 
from Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID 
INNER JOIN [Order Details Extended] ON Orders.OrderID = [Order Details Extended].OrderID
Where year(OrderDate) = 1998
*/
select * from Customer1998

--Question 2
--Using the View Customer1998, retrieve the Customer name, Product name and supplier names 
--for the Customers who have made orders on the year 1998 according to Customer Name.

select Customer1998.CompanyName, Products.ProductName, Suppliers.CompanyName from Customer1998
INNER JOIN Products ON Customer1998.ProductID = Products.ProductID
INNER JOIN Suppliers ON Products.SupplierID = Suppliers.SupplierID
Order by Customer1998.CompanyName

--Question 3
--Retrieve the Customer name and the number of products ordered by them in the year 1998.

--Total Number of product lines
select CompanyName, COUNT(ProductID) as [Number of Products Ordered] from Customer1998 
GROUP BY CompanyName

-- Total Number of products
select CompanyName, COUNT(Quantity) as [Number of Products Ordered (Quantity)] from Customer1998 
INNER JOIN [Order Details] ON Customer1998.ProductID = [Order Details].ProductID
GROUP BY CompanyName

--Question 4a
--Create an Userview to represent total business made by each customer.  The userview includes two columns:
-- – The sum of product’s unit price multiplied by quantity ordered by the customer 
-- – Customer id

/* VIEW CREATION
CREATE VIEW TotalBusinessByCustomerSBeforeDiscount AS
SELECT SUM(UnitPrice*Quantity) AS [Total Order Value (Pre-discounted)], Customers.CustomerID from Customers
INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID
INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
Group By Customers.CustomerID
*/
select * from TotalBusinessByCustomerSBeforeDiscount

--Question 4b
--Using the userview created, retrieve the Average Amount of business that a northwind customer provides.  
--The Average Business is total amount for each customer divided by the number of customer.

Select AVG([TotalBusinessByCustomerSBeforeDiscount].[Total Order Value (Pre-discounted)]) as [Average Business] 
from TotalBusinessByCustomerSBeforeDiscount





