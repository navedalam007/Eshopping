using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eshopping.Models;

namespace Eshopping.Services.v1
{
   public interface ICustomer
    {
        List<Customer> GetCustomers();
    }
}
