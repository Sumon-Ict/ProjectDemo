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
           


             var insertsql="insert into  Person  (Name,Age, Address) values('sakib', 78, 'bohgura')";
             var updatesql = "update Person set name='kobita', Age=23 where id =2";

            var deletesql = "delete from person where ID=2";

             Write(insertsql);
             Write(updatesql);
            Write(deletesql);


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

            var result = Read2("Person");

            // output procedure  data from the sql server database 
            foreach (var row in result)
            {
                foreach(var col in row)
                {
                    Console.WriteLine($"{col.Key}={col.Value}");
                }
                Console.WriteLine(new string('=',8));
            }

        }

       // write operation into sql server database 
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

           // public static     retuntype                methodname(parameter)  
           //read operation from sql server database 
        public static IList<Dictionary<string, object>>Read2(string tableName) 
        {
            var result=new List<Dictionary<string, object>>();

            var query = "select * from  " + tableName;

            try
            {

                if (_sqlConnection.State != System.Data.ConnectionState.Open)
                {  _sqlConnection.Open(); }

                 var command = new SqlCommand(query, _sqlConnection);

                var reader= command.ExecuteReader();

                while(reader.Read())
                {
                    var row = new Dictionary<string, object>();

                    for(int i=0;i<reader.FieldCount;i++)
                    {
                        row.Add(reader.GetName(i), reader.GetValue(i));

                    }
                    result.Add(row);
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("exception error found"+ex.Message);
            }

            return result;



        }

    }
    }

