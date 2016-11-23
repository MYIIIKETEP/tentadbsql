using Tentadbsql.Northwind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Tentadbsql
{
    class Program
    {
        static string cns = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NORTHWND;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        static void Main(string[] args)
        {


            string v = "'Confections'";
            //ProductByCategoryName("'Confections'");
            //SaleByTerritory();
            //EployeesPerRegion();
            OrdersPerEmployee();
        }

        private static void OrdersPerEmployee()
        {
            using (var context = new Model1())
            {
                var xxx = from data in context.Orders
                          where data.Employees.EmployeeID == data.EmployeeID
                          select new { data.Employees.FirstName, data.OrderID };
                foreach (var s in xxx)
                {
                    Console.WriteLine(s);
                }




            }
        }

        private static void EployeesPerRegion()
        {
            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT COUNT(et.EmployeeID) AS expr1, r.RegionDescription FROM Region AS r INNER JOIN Territories AS t ON r.RegionID = t.RegionID INNER JOIN EmployeeTerritories AS et ON t.TerritoryID = et.TerritoryID GROUP BY r.RegionID, r.RegionDescription";
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine(rd.GetInt32(0) + " " + rd.GetString(1));
            }
        }

        private static void SaleByTerritory()
        {
            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "WITH    EmployeeSales AS(SELECT   e.EmployeeID, e.LastName, SUM(od.Quantity * od.UnitPrice) ESales FROM     dbo.Employees AS e INNER JOIN dbo.Orders AS o ON e.EmployeeID = o.EmployeeID INNER JOIN dbo.[Order Details] AS od ON o.OrderID = od.OrderID GROUP BY e.EmployeeID, e.LastName), EmployeeRegion AS(SELECT DISTINCT EmployeeID, r.RegionID, RegionDescription FROM     dbo.Region AS r INNER JOIN dbo.Territories AS t ON r.RegionID = t.RegionID INNER JOIN dbo.EmployeeTerritories AS et ON t.TerritoryID = et.TerritoryID) SELECT EmployeeRegion.RegionDescription ,  SUM(EmployeeSales.ESales) RegionTotalSale   FROM    EmployeeSales INNER JOIN EmployeeRegion ON EmployeeSales.EmployeeID = EmployeeRegion.EmployeeID GROUP BY EmployeeRegion.RegionID , EmployeeRegion.RegionDescription";

            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Console.WriteLine(rd.GetString(0) + " " + rd.GetDecimal(1));
            }
        }

        private static void ProductByCategoryName(string v)
        {
            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT Products.ProductName, Products.UnitPrice, Products.UnitsInStock FROM Categories INNER JOIN Products ON Categories.CategoryName =" + v;


                SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
                {
                Console.WriteLine(rd.GetString(0) + " " + rd.GetDecimal(1) + " " + rd.GetSqlInt16(2));
                }

            rd.Close();
            cn.Close();
            cn.Open();
        }
    }
}

            
    



        //using (var context = new Model1())
        //    {
        //        var xxx = from data in context.Products
        //                  where data.Categories.CategoryName == v
        //                  select data;
        //        foreach (var s in xxx)
        //        {
        //            Console.WriteLine(s.ProductName + " " +  )
        //        }
