﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IBlogService : IGenericService<Blog>
	{
        List<Blog> GetBlogById(int id);
        List<Blog> GetBlogListWithCategory();
    }
}
