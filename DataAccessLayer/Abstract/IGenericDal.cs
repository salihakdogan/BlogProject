using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Remove(T t);
        void Update(T t);
        List<T> List();
        T GetT(int id);
        List<T> GetById(Expression<Func<T, bool>> prm);
    }
}
