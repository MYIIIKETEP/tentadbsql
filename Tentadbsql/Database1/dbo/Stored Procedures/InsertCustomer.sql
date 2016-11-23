CREATE PROCEDURE [dbo].[InsertCustomer] 
            (@CustomerID nchar(5),
           @CompanyName nvarchar(40),
           @ContactName nvarchar(30))
        

as



INSERT INTO [dbo].[Customers]
           ([CustomerID]
           ,[CompanyName]
           ,[ContactName])
         
     VALUES
           (@CustomerID ,
           @CompanyName ,
           @ContactName )
         