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
            ProductByCategoryName();
        }

        private static void ProductByCategoryName()
        {
            SqlConnection cn = new SqlConnection(cns);
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "SELECT Products.ProductName, Products.UnitPrice, Products.UnitsInStock FROM Categories INNER JOIN Products ON Categories.CategoryName = 'Confections' ";


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
