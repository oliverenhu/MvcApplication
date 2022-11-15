using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Web;
namespace MvcApplication.Models
{
    static class Data_Access
    {
        public static IDataReader Return_Reader(string Command_Text)
        {


            IDbConnection connection = new SqlConnection(Helper.CNN_string("SMPHARM_DB"));
            {
                //List<Customer> customers = new List<Customer>();
                ConnectionState originalState = connection.State;
                
                if (originalState != ConnectionState.Open)
                    connection.Open();
                try
                {
                    IDbCommand command = connection.CreateCommand();
                    command.CommandText = Command_Text;
                    IDataReader reader=command.ExecuteReader(CommandBehavior.CloseConnection); 
                    return reader;
                    
                }
                catch
                {
                    return null;
                }
                /*finally
                {
                    if (originalState != ConnectionState.Closed)
                        connection.Close();
                }*/
            }
        }
        
    }
}
   