using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll(IEnumerable<string> includes = null);

        T Get(int id);
    }
}
