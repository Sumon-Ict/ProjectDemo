using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Program
    {
        private const string Connect_String = "Server=DESKTOP-ORVIE5J\\SQLEXPRESS;Database=Csharp;User Id=sumon;Password=sumonict";
        private static SqlConnection _sqlConnection;
        static void Main(string[] args)
        {
            
            _sqlConnection = new SqlConnection(Connect_String);
           


             var insertsql="insert into  Person  (Name,Age, Address) values('mamun', 78, 'bohgura')";
            // var updatesql = "update Person set name='kobita' Age=23 where id =2";

             Write(insertsql);
            // Write(updatesql);
            // var command = new SqlCommand(sql, _sqlConnection);
           
           /* #region
              if (_sqlConnection.State != System.Data.ConnectionState.Open)
              {
                  _sqlConnection.Open();


              }
              var command=new SqlCommand(insertsql, _sqlConnection);
              command.ExecuteNonQuery(); 
           
            #endregion */
           //this is another way to write data in sql server database 

        }

          public static void Write(string sql)
          {


              try
              {
                  if (_sqlConnection.State != System.Data.ConnectionState.Open)
                  {
                      _sqlConnection.Open();

                  }

                  var command = new SqlCommand(sql, _sqlConnection);
                  command.ExecuteNonQuery();
              }
              catch (SqlException ex)
              {
                  Console.WriteLine("database error found " + ex.Message);

              }

              catch (Exception ex)
              {
                  Console.WriteLine("exception error found" + ex.Message);
              }

              finally
              {
                  if (_sqlConnection?.State != ConnectionState.Closed)
                  {

                      _sqlConnection?.Close();
                  }
              }



  } 

    }
    }

