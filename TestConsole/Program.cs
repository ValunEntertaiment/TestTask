using System;
using System.Data.SqlClient;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\MSSQLSERVER; Initial Catalog=TestTask; Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Employees");
            Console.WriteLine(sqlCommand.ExecuteNonQuery());

            sqlConnection.Close();
            Console.ReadLine();
        }
    }
}
