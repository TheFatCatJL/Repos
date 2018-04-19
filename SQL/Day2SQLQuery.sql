--Create Database Qns3036
Use Qns3036
go
/*
Create Table Customer1 (CustomerID nvarchar(50), CustomerName nvarchar(50), Phone int)
Create Table Order1 (OrderID int, CustomerID nvarchar(50), OrderDate DateTime)
Create Table OrderDetails (OrderID int, ProductID nvarchar(50), UnitPrice Real, Quantity Int)
Alter Table Orderdetails Alter COLUMN ProductID NVARCHAR(50) not null
 
*/
--Question 30
Select OrderID, Sum(UnitPrice*Quantity) AS [Value of Order] from OrderDetails group by OrderID Having Sum(UnitPrice*Quantity) > 10000
--Question 31
Select OrderDetails.OrderID, Orders.CustomerID--, Sum(UnitPrice*Quantity) as [Total Order Value]
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID 
group by OrderDetails.OrderID, Orders.CustomerID
Having Sum(UnitPrice*Quantity) > 10000
--Question 32
Select OrderDetails.OrderID, Orders.CustomerID, Customer.CustomerName--, Sum(UnitPrice*Quantity) as [Total Order Value]
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID 
Inner Join Customer ON Orders.CustomerID = Customer.CustomerID
group by OrderDetails.OrderID, Orders.CustomerID,Customer.CustomerName
Having Sum(UnitPrice*Quantity) > 10000
--Question 33
--List the total orders made by each customer.  Your list should have customer id and Amount (Quantity * Price) for each customer.

Select Orders.CustomerID, /*Customer.CustomerName,*/Sum(UnitPrice*Quantity) as [Total Order Value]
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID 
--Inner Join Customer ON Orders.CustomerID = Customer.CustomerID
group by Orders.CustomerID--,Customer.CustomerName

--Question 34
--Retrieve the Average Amount of business that a northwind customer provides.  
--The Average Business is total amount for each customer divided by the number of customer
Select Sum(UnitPrice*Quantity) / (Select count(distinct CustomerID) from Orders) as [Average Business]
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID 

---Question 35
--List all customers (Customer id, Customer name) who have placed orders more than the average business that a northwind customer provides.

Select Orders.CustomerID, /*Customer.CustomerName,*/Sum(UnitPrice*Quantity) as [Total Order Value]
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID 
--Inner Join Customer ON Orders.CustomerID = Customer.CustomerID
group by Orders.CustomerID--,Customer.CustomerName
Having Sum(UnitPrice*Quantity) > (Select Sum(UnitPrice*Quantity) / (Select count(distinct CustomerID) from Orders)
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID)

--Question 36
/*List the total orders made by each customer.  
Your list should have customer id and Amount (Quantity * Price) for each customer in the year 1997. 
(Use year(orderdate) to retrieve the year of the column orderdate) */

Select Orders.CustomerID, /*Customer.CustomerName,*/Sum(UnitPrice*Quantity) as [Amount]
from OrderDetails Inner Join Orders ON OrderDetails.OrderID = Orders.OrderID where YEAR(OrderDate) = 1997
--Inner Join Customer ON Orders.CustomerID = Customer.CustomerID
group by Orders.CustomerID--,Customer.CustomerName

