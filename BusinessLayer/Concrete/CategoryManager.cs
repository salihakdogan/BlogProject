using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetT(int id)
        {
            return _categoryDal.GetT(id);
        }
        
        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public List<Category> TList()
        {
            return _categoryDal.List();
        }

        public void TRemove(Category t)
        {
            _categoryDal.Remove(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }
    }
}
