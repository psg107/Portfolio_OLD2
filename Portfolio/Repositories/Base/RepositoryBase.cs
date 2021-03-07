using Microsoft.EntityFrameworkCore;
using Portfolio.Context;
using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> 
        where T : class, IEntity
    {
        private readonly PortfolioDbContext context;

        public RepositoryBase(PortfolioDbContext context)
        {
            this.context = context;
        }

        public IQueryable<T> GetAll(IEnumerable<string> includes = null)
        {
#warning include 고장남;;
            var query = context.Set<T>();
            if (includes != null)
            {
                foreach (var item in includes)
                {
                    query.Include(item);
                }
            }

            return query.AsQueryable();
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
