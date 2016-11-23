CREATE PROCEDURE [dbo].[AddTerritort]
	       (@TerritoryID nvarchar(20),
           @RegionID int,
           @TerritoryDescription nchar(50))

           
AS

INSERT INTO [dbo].[Territories]
           ([TerritoryID]
           ,[TerritoryDescription]
           ,[RegionID])
		         
VALUES
         (@TerritoryID,
           @RegionID,
           @TerritoryDescription)