using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication.Models
{
    public interface ICustomer_Base 
    {
        List<Customer> Get_Customer_By_Last_Name(string Last_Name);

    }
}