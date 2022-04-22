using BusinessLayer;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeUrunlerTask
{
    internal class Program
    {
        /*
         
        This layer is the layer where interaction with the user is made.
        The main purpose here is to show the data to the user and transmit the data from the user to 
        Data Access with the Business Layer.
         */
        static void Main(string[] args)
        {
            CategoryManagement ky = new CategoryManagement();

            foreach (var item in ky.GetAll())
            {
                Console.WriteLine("ID" + item.CategoryId + " " + "Category Name :" + item.CategoryName);
            }


            Categories k = new Categories();
            k.CategoryName = "";
             ky.BLAdd(k);

            //ky.BLDelete(7);
            //ky.BLDelete(6);

            Console.WriteLine("----------------------------------------------------");

            ProductManagement kp = new ProductManagement();

            foreach (var item in kp.GetAll())
            {
                Console.WriteLine("ID" + item.ProductID + " "+ "Product Name : " + item.ProductName);
            }


            Product p = new Product();

            //kp.BLDelete(2);
            p.ProductName = "LGTv";
            kp.BLAdd(p);


            Categories c = new Categories();
            c.CategoryId = 2;
             c.CategoryName= "Sofa";
            ky.BLUpdate(c);







            Console.Read();
        }
    }
}
