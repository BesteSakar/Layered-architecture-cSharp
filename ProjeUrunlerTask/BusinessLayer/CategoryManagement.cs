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


    public class CategoryManagement
    {
        Repository<Categories> CategoryRep = new Repository<Categories>();


        public List<Categories> GetAll()
        {
            return CategoryRep.List();
        }

        public int BLAdd(Categories c)
        {
            if(c.CategoryName.Length <= 4)
            {
                return -1;
            }

            return CategoryRep.Insert(c);
        }


        public int BLDelete(int c)
        {
            if (c!= 0)
            {
                
                Categories k = CategoryRep.Find(x => x.CategoryId == c);
               
                return CategoryRep.Delete(k);
            }

            return -1;
        }


        public int BLUpdate(Categories k)
        {
            if (k.CategoryName == "" || k.CategoryName.Length <= 3 || k.CategoryName.Length >= 30)
            {
                return -1;
            }
            Categories kat = CategoryRep.Find(x => x.CategoryId == k.CategoryId);
            kat.CategoryName = k.CategoryName;
            return CategoryRep.Update(kat);
        }








    }
}
