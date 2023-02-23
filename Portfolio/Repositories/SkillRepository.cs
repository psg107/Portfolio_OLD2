using Portfolio.Context;
using Portfolio.Entities;

namespace Portfolio.Repositories
{
    public class SkillRepository : EntityRepositoryBase<SkillEntity>
    {
        public SkillRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
