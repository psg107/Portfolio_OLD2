using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public interface IRepositoryBase<T>
    {
        List<T> GetAll();

        T Get(int id);
    }
}
