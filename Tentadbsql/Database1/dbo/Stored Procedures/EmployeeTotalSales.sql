﻿CREATE PROCEDURE EmployeeTotalSales (@emloyeeID int)
as
SELECT        SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS TotalOrderValue, e.EmployeeID
FROM            Employees e INNER JOIN
                         Orders o ON e.EmployeeID = o.EmployeeID INNER JOIN
                         [Order Details] od ON o.OrderID = od.OrderID
						 WHERE e.EmployeeID = @emloyeeID
GROUP BY e.EmployeeID