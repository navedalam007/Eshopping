using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshopping.Models
{
    public class Admin
    {
        [key]
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
