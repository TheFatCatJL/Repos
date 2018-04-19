USE NorthwindFatCatJL
go
--Question 1A
select * from Shippers
--Question 1B
select * from Shippers order by CompanyName
--Question 2A
select FirstName, LastName,Title,BirthDate,City from Employees 
--Question 2B
select distinct Title from Employees
--Question 3
select * from Orders where OrderDate = '19-May-1997'
--Question 4
select * from Customers where City in ('London','Madrid')
--Question 5
select CustomerID, CompanyName from Customers order by CompanyName
--Question 6
select OrderID, Orderdate from Orders where CustomerID = 'HANAR'
--Question 7
select (TitleOfCourtesy + FirstName + LastName) as FullyQualifiedName from Employees order by LastName
select CONCAT(TitleOfCourtesy, FirstName,LastName) as FullyQualifiedName from Employees order by LastName
--Question 8
select OrderID, OrderDate from Orders where CustomerID = (select CustomerID from Customers where CompanyName ='Maison Dewey')
--Create view V_Customers_CompanyName_MaisonDewey AS select CustomerID from Customers where CompanyName ='Maison Dewey'
--select OrderID, OrderDate from Orders where CustomerID = (select CustomerID from V_Customers_CompanyName_MaisonDewey)
--Question 9
select * from Products where ProductName like '%lager%'
--Question 10
select CustomerID, ContactName from Customers where CustomerID not in (select CustomerID from Orders where ContactName is not null)
--select Customers.CustomerID, ContactName from Customers Left Outer Join Orders on Customers.CustomerID = Orders.CustomerID where Customers.CustomerID not in (Select CustomerID from Orders)
--Question 11
select AVG(UnitPrice) as AveragePrice from Products
--Question 12
select distinct City from Customers where City is not null
--Question 13
select CustomerID, ContactName from Customers where CustomerID in (select CustomerID from Orders)
--select distinct Customers.CustomerID, ContactName from Customers, Orders where Customers.CustomerID = Orders.CustomerID
--select Customers.CustomerID, ContactName from Customers Inner Join Orders on Customers.CustomerID = Orders.CustomerID Group By Customers.CustomerID, ContactName
--Question 14
select CompanyName, Phone from Customers where Fax is null
--Question 15
select SUM(UnitsOnOrder) * AVG(UnitPrice) as TotalSales from Products
--Question 16
select OrderID from Orders where CustomerID in (select CustomerID from Customers where CompanyName in ('Alan Out','Blone Coy'))
--Question 17
select CustomerID, count(CustomerID) as TotalOrders from Orders Group by CustomerID
--Question 18
select CompanyName, OrderID from Customers Inner Join Orders on Customers.CustomerID = Orders.CustomerID where Customers.CustomerID = 'BONAP'

--Question 19a
select Customers.CustomerID, Customers.CompanyName, Count(Orders.CustomerID) as NumberOfOrdersMade 
from Customers Inner Join Orders on Customers.CustomerID = Orders.CustomerID  
GROUP BY Customers.CustomerID, CompanyName 
HAVING Count(OrderID) > 10 
ORDER BY NumberOfOrdersMade desc

--Question 19b
select Customers.CustomerID, Customers.CompanyName, Count(Orders.CustomerID) as NumberOfOrdersMade 
from Customers Inner Join Orders on Customers.CustomerID = Orders.CustomerID
WHERE Customers.CustomerID = 'BONAP'
GROUP BY Customers.CustomerID, CompanyName
--Question 19c
select Customers.CustomerID, Customers.CompanyName, Count(Orders.CustomerID) as NumberOfOrdersMade 
from Customers Inner Join Orders on Customers.CustomerID = Orders.CustomerID
GROUP BY Customers.CustomerID, CompanyName
HAVING Count(OrderID) > (Select COUNT(Orders.CustomerID) from Orders where Orders.CustomerID = 'BONAP')
--Question 20a
select ProductID, ProductName from Products where CategoryID = 1 OR CategoryID = 2 ORDER BY ProductID, ProductName
--Question 20b
select ProductID, ProductName 
from Products INNER JOIN Categories on Products.CategoryID = Categories.CategoryID 
WHERE Categories.CategoryName in ('Beverages','Condiments')  
ORDER BY ProductID, ProductName
--Question 21a
select Count(EmployeeID) as [Total Number of Employees] from Employees
--Question 21b
select COUNT(Country) as [Total Number of Employees in USA] from Employees where Country = 'USA'
--Question 22
Select *
from Orders Inner Join Employees on Orders.EmployeeID = Employees.EmployeeID
Inner Join Shippers on Orders.ShipVia = Shippers.ShipperID
where Title = 'Sales Representative' AND CompanyName = 'United Package'
Order By Orders.EmployeeID
--Question 23
select (set1.TitleOfCourtesy + set1.FirstName + set1.LastName) as [Full Names], (set2.TitleOfCourtesy + set2.FirstName + set2.LastName) as Manager 
from Employees set1, Employees set2
where set1.ReportsTo = set2.EmployeeID
--Question 24
Select Top 5 ProductName, sum(UnitPrice*Quantity-ExtendedPrice) as [Total Discount in dollars] from Invoices group by ProductName Order by [Total Discount in dollars] desc
--Questiom 25
Select Customers.CompanyName
from Customers Left Outer Join Suppliers on Customers.City = Suppliers.City
where Suppliers.City is null AND Customers.City is not null

--Question 26
Select distinct Customers.City
from Customers Join Suppliers on Customers.City = Suppliers.City
--Question 27a
/*Northwind proposes to create a mailing list of its business associates.  
The mailing list would consist of all Suppliers and Customers collectively called Business Associates here.  
The details that need to be captured are the Business Associates' Names, Address and Phone.*/

Select CompanyName as [Business Associate Name], Address, Phone from Suppliers UNION
Select CompanyName as [Business Associate Name], Address, Phone from Customers where Address is not null

--Question 27b
Select CompanyName as [Business Associate Name], Address, Phone from Suppliers UNION
Select CompanyName as [Business Associate Name], Address, Phone from Customers where Address is not null UNION
Select CompanyName as [Business Associate Name], 'No Address entry' as Address, Phone from Shippers

--Question 28
Select (B.FirstName+B.LastName) as [Manager's Name]
from Employees as A INNER JOIN Employees As B ON B.EmployeeID = A.ReportsTo
where A.EmployeeID = (SELECT EmployeeID from Orders where OrderID = 10248)

--Question 29
--List the product name and product id with unit price greater than average unit product price.
Select ProductName, ProductID from Products where UnitPrice > (select avg(UnitPrice) from Products)
--Select ProductName, ProductID , (select (AVG(UnitPrice)) from Products) As AveragePrice, UnitPrice from Products where UnitPrice > (select avg(UnitPrice) from Products)


