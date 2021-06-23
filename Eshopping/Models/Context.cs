using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshopping.Models
{
    public class Context:DbContext
    {
       
       
            public Context() { }
            public Context(DbContextOptions<Context> option) : base(option)
            { }
            protected override void OnConfiguring(DbContextOptionsBuilder b)
            {
                b.UseSqlServer("data source = CHETUIWK82\\SQL2017EXP; initial catalog = Eshopping2; trusted_connection = true; MultipleActiveResultsets = true; ");
            }

            public DbSet<Customer> customers { get; set; }
            public DbSet<Admin> Admins { get; set; }
            
              
        
        }
    
}
