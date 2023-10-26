using Infrastructure_Layer.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _dbcontxt;

        public UnitOfWork(AppDbContext dbcontxt)
        {
            _dbcontxt = dbcontxt;
        }

        public int CommitChanges()
        {
            return _dbcontxt.SaveChanges();
        }
    }
}
