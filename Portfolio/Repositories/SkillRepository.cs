using Microsoft.EntityFrameworkCore;
using Portfolio.Context;
using Portfolio.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Repositories
{
    public class SkillRepository : IRepositoryBase<SkillEntity>
    {
        private readonly PortfolioDbContext context;

        public SkillRepository(PortfolioDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SkillEntity> GetAll()
        {
            return context.Skills.AsEnumerable();
        }
    }
}
