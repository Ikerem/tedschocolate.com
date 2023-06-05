using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void tInsert(T t);
        void tDelete(T t);
        void tUpdate(T t);
        List<T> tGetList();
        T tGetByID(int id);

    }
}
