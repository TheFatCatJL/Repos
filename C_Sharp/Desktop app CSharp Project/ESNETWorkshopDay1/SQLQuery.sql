use DafestyESNET
go

CREATE PROCEDURE ChangeVideoPrice
(
@videoprice real,
@videocode int
)
As
Begin
UPDATE Movies
SET RentalPrice = @videoprice
WHERE VideoCode = @videocode
End

CREATE PROCEDURE ViewVideoPrice
(
@videocode int
)
As
Begin
SELECT VideoCode,RentalPrice FROM Movies WHERE VideoCode = @videocode
End

exec ViewVideoPrice 1

select * from Movies
exec ChangeVideoPrice 1.5,2

select * from Customers
