CREATE PROCEDURE AddIfNotExist(@name nvarchar (40))
as
DECLARE @newID INT
Select TOP 1  @newID = ProductID FROM Products Where ProductName = @name