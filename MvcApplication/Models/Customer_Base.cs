using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MvcApplication.Models
{
    public class Customer_Base : ICustomer_Base
    {
        public List<Customer> Get_Customer_By_Last_Name(string Last_Name)
        {
            string Command_Text = $"SELECT [First_Name],[Last_Name] FROM[smpharm].[dbo].[Customers] WHERE[Last_Name] = '{Last_Name}'; ";
            List<Customer> customers = new List<Customer>();
            IDataReader reader1= Data_Access.Return_Reader(Command_Text);
            if (reader1 == null)
            {
                return customers;
            }
            
            while (reader1.Read())
            {
                Customer c = new Customer();
                c.Last_Name = reader1.GetString(reader1.GetOrdinal("Last_Name"));
                c.First_Name = reader1.GetString(reader1.GetOrdinal("First_Name"));
                customers.Add(c);
            }
            reader1.Close();
            return customers;
            
        }
    }
}
