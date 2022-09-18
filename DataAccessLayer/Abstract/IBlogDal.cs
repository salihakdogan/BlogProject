using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> ListBlog();
        void AddBlog(Blog blog);
        void RemoBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Blog GetBlog(int id);
    }
}
