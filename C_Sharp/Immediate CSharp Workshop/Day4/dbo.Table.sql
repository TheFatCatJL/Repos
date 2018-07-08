CREATE TABLE [dbo].[Table]
(
	[BankAccountID] INT NOT NULL PRIMARY KEY, 
    [CustomerName] NVARCHAR(50) NULL DEFAULT 'No Name', 
    [CustomerAdd] NVARCHAR(150) NULL DEFAULT 'No Address' , 
    [CustomerDOB] DATE NULL DEFAULT 01-01-1900, 
    [AccountType] NVARCHAR(20) NULL DEFAULT 'Savings', 
    [AccountBalance] MONEY NULL DEFAULT 0, 
    [AccountInterest] FLOAT NULL DEFAULT 0 
)
