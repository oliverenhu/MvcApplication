using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
namespace MvcApplication.Models
{
    
        public class Customer
        {
            public int Customer_Id { get; set; }
            public string First_Name { get; set; }
            public string Last_Name { get; set; }
            public int Status_ID { get; set; }
            
            
            public string Full_Name
            {
            get
                { 
                    return $"{First_Name} {Last_Name}"; 
                }
            }

        }
    
}
