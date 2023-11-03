using Domain_Layer.Models;
using Infrastructure_Layer.IRepos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Repos
{
    public class BaseRepos<T>:IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _appContext;
        public readonly DbSet<T> Set;
        public BaseRepos( AppDbContext appContext)
        {
           _appContext = appContext;
            Set = appContext.Set<T>();

        }

        public IQueryable<T> Get(
           Expression<Func<T, bool>> Filter,
           string OrderBy,
           bool IsAscending,
           int PageSize,
           int PageIndex)
        {
            var Quary = Set.AsQueryable();
            if (Filter != null)
            {
                Quary = Quary.Where(Filter);
            }
            Quary = Quary.OrderBy(OrderBy, IsAscending);
            if (PageIndex < 1)
            {
                PageIndex = 1;
            }
            
            var temp = Set.Count() / Convert.ToDouble(PageSize);
            if (PageIndex > temp + 1)
            {
                PageIndex = 1;
            }
            int ToBeSkiped = (PageIndex - 1) * PageSize;
            return Quary.Skip(ToBeSkiped).Take(PageSize);
        }

        public IEnumerable<T> GetAll()
        {
           return _appContext.Set<T>().ToList();
        }
        public IQueryable<T> GetList()
        {
            return Set.AsQueryable();
        }
        public EntityEntry<T> Add(T Entry) =>
           Set.Add(Entry);

        public EntityEntry<T> Update(T Entry) =>
             Set.Update(Entry);
        public EntityEntry<T> Delete(T Entry) =>
            Set.Remove(Entry);
    }
}
