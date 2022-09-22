using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService <T> where T : class
    {
        void TAdd(T t);
        void TRemove(T t);
        void TUpdate(T t);
        List<T> TList();
        T GetT(int id);
    }
}
