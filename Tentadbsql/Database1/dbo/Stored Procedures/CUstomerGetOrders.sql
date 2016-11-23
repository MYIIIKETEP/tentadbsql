	CREATE PROCEDURE CUstomerGetOrders(@kundid nvarchar(50))
	AS
SELECT        Customers.CustomerID, Orders.CustomerID AS Expr1
FROM            Customers INNER JOIN
                         Orders ON Customers.CustomerID = Orders.CustomerID