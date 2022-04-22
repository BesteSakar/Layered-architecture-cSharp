using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer
{


    /*
     
     In this layer, we define our main classes that we will use throughout the project, 
    so this is where we specify our real objects.
      */
    public class Context : DbContext
    {
        public DbSet<Product>MyProducts { get; set; }
        public DbSet<Categories>MyCategories { get; set; }
    }
}
