using Portfolio.Context;
using Portfolio.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public abstract class EntityRepositoryBase<T> : IRepositoryBase<T> 
        where T : class, IEntity
    {
        private readonly PortfolioDbContext context;

        public EntityRepositoryBase(PortfolioDbContext context)
        {
            this.context = context;
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T Get(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
