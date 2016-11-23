ALTER PROCEDURE [dbo].[AddTerritort]
	       (@TerritoryID nvarchar(20),
           @RegionID int,
           @TerritoryDescription nchar(50))

           
AS

INSERT INTO [dbo].[Territories]
           ([TerritoryID]
           ,[RegionID]
           ,[TerritoryDescription])
		         
VALUES
         (@TerritoryID,
           @RegionID,
           @TerritoryDescription)