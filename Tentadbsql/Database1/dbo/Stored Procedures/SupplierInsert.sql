CREATE PROCEDURE SupplierInsert(@cname nvarchar(40), @cnname nvarchar(30),
 @ctitle nvarchar(60), @adress nvarchar(15), @city nvarchar (50),  @region nvarchar(30),
 @pcode nvarchar (50), @country nvarchar(15), @phone nvarchar(24), @fax nvarchar(24), @hpage ntext)
AS 
INSERT INTO [dbo].[Suppliers]
           ([CompanyName],[ContactName],[ContactTitle],[Address],
		   [City],[Region],[PostalCode],[Country],[Phone],[Fax],[HomePage])
     VALUES
           (@cname, @cnname,@ctitle, @adress, @city, @region, @pcode, @country,@phone, @fax,@hpage)
