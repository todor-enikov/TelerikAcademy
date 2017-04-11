using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace ADO.NET
{
    public class Startup
    {
        public static object GlobalUser { get; private set; }

        public static void Main()
        {
            //task 1
            Startup.NumberOfRowsInCategories();
            //task 2
            Startup.RetrievingNameAndDescriptionFromTableNorthwind();
            //task 3
            Startup.ProductCategoriesAndTheNameOfTheCategory();
            //task 4
            Startup.AddingProductToTheProductsTable("Salam", 1, 3, "5 kg", 6m);
            //task 5
            //
            //task 6
            Startup.AppendingNewRowsOleDB();
            //task 7

        }

        public static void NumberOfRowsInCategories()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");

            dbConnection.Open();
            Console.WriteLine("Connection is opened");
            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Categories", dbConnection);

                var result = (int)command.ExecuteScalar();

                Console.WriteLine("The count of the categories is: {0}", result);
            }
        }

        public static void RetrievingNameAndDescriptionFromTableNorthwind()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");

            dbConnection.Open();
            Console.WriteLine("Connection is opened");
            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT CategoryName,Description FROM Categories", dbConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string categoryName = (string)reader["CategoryName"];
                    string description = (string)reader["Description"];
                    Console.WriteLine("The category name is: {0} and has description: {1}", categoryName, description);
                }
            }
        }

        public static void ProductCategoriesAndTheNameOfTheCategory()
        {
            SqlConnection dbConnection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");

            dbConnection.Open();
            Console.WriteLine("Connection is opened");
            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("SELECT p.ProductName,c.CategoryName FROM Categories c INNER JOIN Products p ON c.CategoryID = p.CategoryID ORDER BY c.CategoryName", dbConnection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string productName = (string)reader["ProductName"];
                    string categoryName = (string)reader["CategoryName"];
                    Console.WriteLine("The name of the product is: {0} AND it is in category: {1}", productName, categoryName);
                }
            }
        }

        public static void AddingProductToTheProductsTable(string productName, int supplierId, int categoryId, string quantityPerUnit, decimal unitPrice)
        {
            SqlConnection dbConnection = new SqlConnection("Server=.;Database=Northwind;Integrated Security=true");

            dbConnection.Open();
            Console.WriteLine("Connection is opened");
            using (dbConnection)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Products " +
                    "(ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice) VALUES " +
                    "(@productName, @supplierId, @categoryId, @quantityPerUnit, @unitPrice)", dbConnection);
                command.Parameters.AddWithValue("@productName", productName);
                command.Parameters.AddWithValue("@supplierId", supplierId);
                command.Parameters.AddWithValue("@categoryId", categoryId);
                command.Parameters.AddWithValue("@quantityPerUnit", quantityPerUnit);
                command.Parameters.AddWithValue("@unitPrice", unitPrice);
                command.ExecuteNonQuery();
                Console.WriteLine("You added the product {0} successfully!", productName);
            }
        }

        public static void RetrievingImageFromTheDB()
        {

            ////Get byte array from image file in the database with basic query
            //SqlDataAdapter myAdapter1 = new SqlDataAdapter("Select [logo] FROM [dbo].[tblCompanyInfo]", GlobalUser.currentConnectionString);
            //DataTable dt = new DataTable();
            //myAdapter1.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    // Get the byte array from image file
            //    byte[] imgBytes = (byte[])row["logo"];

            //    // If you want convert to a bitmap file
            //    TypeConverter tc = TypeDescriptor.GetConverter(typeof(BitConverter));
            //    BitConverter MyBitmap = (BitConverter)tc.ConvertFrom(imgBytes);
            //}

        }

        public static void AppendingNewRowsOleDB()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
            @"Data Source=..\..\Library.mdb;Persist Security Info=False";

            OleDbConnection dbConn = new OleDbConnection(connectionString);

            // Open connection
            dbConn.Open();
            using (dbConn)
            {
                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO Users ([username], [password]) VALUES (@user, @pass)", dbConn);

                cmd.Parameters.AddWithValue("@user", "new user name");
                cmd.Parameters.AddWithValue("@pass", "secret password");

                // Execute command
                try
                {
                    //cmd.Parameters["@user"].Value = "tooooooooooooooooooooooooooooooooooo long user name";
                    cmd.ExecuteNonQuery();

                    Console.WriteLine("Row inserted successfully.");
                }
                catch (OleDbException exception)
                {
                    Console.WriteLine("SQL Error occured: " + exception);
                }

            }
        }
    }
}
