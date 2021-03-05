using System;
using System.Data.SqlClient;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using(SqlConnection sqlConnection = new SqlConnection("Data Source=VALUN;Initial Catalog=TestTask;Integrated Security=True"));
            {
                SqlCommand sqlCommand = new SqlCommand("select * from Employees");
                Console.WriteLine(sqlCommand.ExecuteNonQuery());
            }
            Console.ReadLine();
        }
    }
}
