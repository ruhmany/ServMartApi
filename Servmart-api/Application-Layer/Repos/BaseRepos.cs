﻿using ApplicationLayer.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Repos
{
    public class BaseRepos<T>:IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _appContext;

        public BaseRepos( AppDbContext appContext)
        {
           _appContext = appContext;
        }



        public IEnumerable<T> GetAll()
        {
           return _appContext.Set<T>().ToList();
        }
    }
}
