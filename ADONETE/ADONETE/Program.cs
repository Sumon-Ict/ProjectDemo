using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ADONETE
{
    internal class Program
    {
        private const string Connection_String = "Server =DESKTOP-ORVIE5J\\SQLEXPRESS;Database=Csharp;User Id = sumon;Password=sumonict";

        private static SqlConnection _sqlConnection;


        static void Main(string[] args)
        {

            Console.WriteLine("helow word");
         _sqlConnection = new SqlConnection(Connection_String);


        }
        public static void Write(string sql)
        {
            try
            {
                if (_sqlConnection.State != System.Data.ConnectionState.Open)

                { _sqlConnection.Open(); }

                var command = new SqlCommand(sql, _sqlConnection);
                command.ExecuteNonQuery();

            }


            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _sqlConnection?.Close();
            }


        }   
    }
}
