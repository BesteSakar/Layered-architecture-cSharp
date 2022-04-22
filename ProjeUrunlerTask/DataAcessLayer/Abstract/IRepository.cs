using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.Abstract
{
    public interface IRepository<T>
    {
        //ın this interface,we define the operations we want.
        int Insert(T p);
        int Update(T p);

        int Delete(T p);

        List<T> List();
        T GetById(int id);
    }
}
