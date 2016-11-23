CREATE PROCEDURE CustomerGetOrders2(@kundid nvarchar(50))
	AS
	
SELECT        Customers.CustomerID, Orders.CustomerID AS Expr1
FROM            Customers INNER JOIN
                         Orders ON @kundid = Orders.CustomerID

						 WHERE (Customers.CustomerID =@kundid)