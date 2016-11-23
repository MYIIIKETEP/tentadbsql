CREATE VIEW [dbo].[CountCategories]
as
SELECT Count(Categories.CategoryID) as exp1
FROM            dbo.Categories
