﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlogApp.Data.Abstarct;
using MyBlogApp.Entities.Concrete;
using MyBlogApp.Shared.Data.Concrete.EntityFramework;

namespace MyBlogApp.Data.Concrete.EntityFramework.Repositories
{
    public class EfArticleRepository : EFEntityRepositoryBase<Article>, IArticleRepository
    {
        public EfArticleRepository(DbContext context) : base(context)
        {
        }
    }
}
