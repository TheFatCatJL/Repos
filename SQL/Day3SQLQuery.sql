use DafestyFatCatJL
go

--Question 1
--Create a Table called MemberCategories with the following fields 
--MemberCategory  nvarchar(2) 
--MemberCatDescription nvarchar(200)  
--None of the fields above can be null.  Set the MemberCategory as the Primary key

CREATE TABLE MemberCategories (MemberCategory nvarchar(2) not null, MemberCatDescription nvarchar(200) not null, 
CONSTRAINT PK_MemberCategories PRIMARY KEY(MemberCategory))

--Question 2
--Add the following data into the MemberCategories Table: 
--MemberCategory  MemberCatDescription 
--A				Class A Members  
--B				Class B Members  
--C				Class C Members

Insert MemberCategories values ('A', 'Class A Members') 
Insert MemberCategories values ('B', 'Class B Members')
Insert MemberCategories values ('C', 'Class C Members')

--Question 3
--3. Create a Table called GoodCustomers with the following fields: 
--CustomerName  nvarchar(50)
--Address   nvarchar(65)
--PhoneNumber   nvarchar(9)
--MemberCategory  nvarchar(2)   
--Only Customer Name and Phone Number is mandatory. 
--Since there could be two customers having the same name, make CustomerName and Phone Number as a composite primary key. 
--The MemberCategory should have a referential integrity to the MemberCategories Table 
--so that only those categories that have been listed in MemberCategories Table could be entered. 
 
CREATE TABLE GoodCustomers (CustomerName nvarchar(50) not null, Address nvarchar(65), PhoneNumber nvarchar(9) not null, MemberCategory nvarchar(2),
CONSTRAINT PK_Composite_GoodCustomers PRIMARY KEY(CustomerName, PhoneNumber),
CONSTRAINT FK_GoodCustomer_MemberCat_REF_MemberCategories FOREIGN KEY(MemberCategory) REFERENCES MemberCategories(MemberCategory))

--Question 4
--Insert into GoodCustomer all records form Customer table with corresponding fields except Address, which is to be left Null. 
--Only Customers having Member Category ‘A’ or ‘B’ are good customers hence the table should be inserted only those records from the Customers table.

INSERT INTO GoodCustomers (CustomerName, PhoneNumber, MemberCategory)
SELECT CustomerName, PhoneNumber, MemberCategory from Customers where MemberCategory in ('A','B')

--Question 5
--Insert into GoodCustomers the following new customer. CustomerName = Tracy Tan PhoneNumber = 736572 MemberCategory = 'B' 

Insert GoodCustomers (CustomerName, PhoneNumber, MemberCategory) values('Tracy Tan', 736572, 'B')

--Question 6
--Insert into GoodCustomers table the following information for a new customer 
--Since all the columns are provided you may insert the record without specifying the column names. 
--CustomerName = Grace Leong Address = 15 Bukit Purmei Road, Singapore 0904' PhoneNumber = 278865 MemberCategory = 'A' 

Insert GoodCustomers values('Grace Leong', '15 Bukit Purmei Road, Singapore 0904',278865,'A')

--Question 7
--Insert into GoodCustomers table the following information for a new customer 
--Since all the columns are provided you may insert the record without specifying the column names. 
--CustomerName = Lynn Lim Address = 15 Bukit Purmei Road, Singapore 0904' PhoneNumber = 278865 MemberCategory = 'P'
--(Violation of referential integrity)

--Insert GoodCustomers values('Lynn Lim', '15 Bukit Purmei Road, Singapore 0904',278865,'P')

--Question 8
--Change the Address of Grace Leong so that the new address is '22 Bukit Purmei Road, Singapore 0904' in GoodCustomers table. 

UPDATE GoodCustomers Set Address ='22 Bukit Purmei Road, Singapore 0904' where CustomerName = 'Grace Leong'

--Question 9
--Change the Member Category to ‘B’ for customer whose Customer ID is 5108 in GoodCustomers table. 

UPDATE GoodCustomers Set MemberCategory = 'B' where CustomerName = 
(Select CustomerName from Customers where CustomerID = 5108)

--Question 10
--Remove Grace Leong from GoodCustomers table

DELETE from GoodCustomers where CustomerName = 'Grace Leong'

--Question 11
--Remove customers with ‘B’ member category in GoodCustomers table. 

DELETE from GoodCustomers where MemberCategory = 'B'

--Question 12
--Add column FaxNumber (nvarchar(25)) to GoodCustomers table.
ALTER TABLE GoodCustomers Add FaxNumber nvarchar(25)

--Question 13
--Alter the column Address to nvarchar(80) in GoodCustomers table. 
ALTER TABLE GoodCustomers ALTER COLUMN Address nvarchar(80)

--Question 14
--Add column ICNumber (nvarchar(10)) to GoodCustomers table
ALTER TABLE GoodCustomers Add ICNumber nvarchar(10)

--Question 15
--Create a unique index ICIndex on table GoodCustomers bases on ICNumber. 
--Notice that the column ICNumber have no values.  Can you create the unique index successfully?  Why?
--Failure >>> Note UNIQUE treats NULL values as same and UNIQUE prevents multiple duplicates of the same 

--CREATE UNIQUE INDEX IX_GoodCustomers_ICNumber ON GoodCustomers (ICNumber)

--Question 16
--Create an index on table GoodCustomers based on FaxNumber.

CREATE INDEX IX_GoodCustomers_FaxNumber ON GoodCustomers (FaxNumber)

--Question 17
--Drop the index created on FaxNumber.

DROP INDEX IX_GoodCustomers_FaxNumber on GoodCustomers

--Question 18
--Remove the column FaxNumber from GoodCustomer table. 
ALTER TABLE GoodCustomers DROP COLUMN FaxNumber

--Question 19
--Delete all records from GoodCustomers.

DELETE FROM GoodCustomers

--Question 20
--Drop the table GoodCustomers. 

Drop Table GoodCustomers 
