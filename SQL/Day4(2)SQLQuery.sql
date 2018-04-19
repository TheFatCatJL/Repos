use DafestyFatCatJL
go

--Question 1 (Stored Procedure)
/*
• Write a stored procedure that would list all members who belong to ‘A’ category. 
• Write statements to call this procedure
*/

CREATE PROCEDURE pr_ListMemberA
AS
SELECT * from Customers WHERE MemberCategory = 'A'

EXECUTE pr_ListMemberA
--Question 2 (Stored Procedure)
/*
• Write stored procedure that would take as parameter (argument) a member category and list all the members belonging to that category. 
• Write calling Statements to call the procedure and test the stored procedure for various inputs. 
• What is the output if the argument is ‘B’? 
• What is the output if the argument is ‘Z’?
*/

CREATE PROCEDURE pr_ListMember_Any
(@MemberCat nvarchar(50)) As
SELECT * from Customers WHERE MemberCategory = @MemberCat

EXECUTE pr_ListMember_Any 'B'
EXECUTE pr_ListMember_Any 'Z'
