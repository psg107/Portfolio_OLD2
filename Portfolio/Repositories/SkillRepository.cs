using Portfolio.Context;
using Portfolio.Entities;

namespace Portfolio.Repositories
{
    public class SkillRepository : RepositoryBase<SkillEntity>
    {
        public SkillRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
