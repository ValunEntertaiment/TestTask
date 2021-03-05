using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(localdb)\\VALUN; Initial Catalog=TestTask; Integrated Security=True;");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from Employees");
            Console.WriteLine(sqlCommand.ExecuteNonQuery());

            sqlConnection.Close();
        }
    }
}
