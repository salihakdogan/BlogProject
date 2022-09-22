using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public Blog GetT(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Blog t)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TList()
        {
            return _blogDal.List();
        }

        public void TRemove(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }       

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetById(x => x.BlogID == id);
        }
    }
}
