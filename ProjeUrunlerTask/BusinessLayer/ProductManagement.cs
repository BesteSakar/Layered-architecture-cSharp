using DataAcessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{

    /*

 In this layer, we write our workloads. First of all, I must say that this layer is the layer that
 will process the data that has been pulled into the project by Data Access.
 We do not directly use the Data Access layer.
 By putting the Business layer in between, we let Business do it for us.

 */
    public class ProductManagement
    {
      

        Repository<Product> ProductRep = new Repository<Product>();
        public List<Product> GetAll()
        {
            return ProductRep.List();
        }

        public int BLAdd(Product c)
        {
            if (c.ProductName.Length <= 4)
            {
                return -1;
            }

            return ProductRep.Insert(c);
        }


        public int BLDelete(int c)
        {
            if (c != 0)
            {

                Product k = ProductRep.Find(x => x.CategoryId == c);

                return ProductRep.Delete(k);
            }

            return -1;
        }


    }
}
