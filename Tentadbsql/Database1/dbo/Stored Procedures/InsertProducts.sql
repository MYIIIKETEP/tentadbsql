CREATE PROCEDURE [dbo].[InsertProducts]
          (@ProductName nvarchar(40),
           @SupplierID int,
           @CategoryID int,
           @QuantityPerUnit nvarchar(20),
           @UnitPrice money)
          

as

INSERT INTO [dbo].[Products]
           ([ProductName]
           ,[SupplierID]
           ,[CategoryID]
           ,[QuantityPerUnit]
           ,[UnitPrice])
          
     VALUES
         (@ProductName ,
           @SupplierID ,
           @CategoryID ,
           @QuantityPerUnit,
           @UnitPrice)