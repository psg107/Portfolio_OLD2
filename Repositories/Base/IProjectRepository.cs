using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Repositories
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> GetAll();
    }
}
