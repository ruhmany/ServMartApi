using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.IRepos
{
    public interface IBaseRepo<T> where T : class
    {
        IEnumerable<T> GetAll();


        
    }
}
