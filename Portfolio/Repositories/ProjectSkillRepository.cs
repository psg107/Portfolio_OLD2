using Portfolio.Context;
using Portfolio.Entities;

namespace Portfolio.Repositories
{
    public class ProjectSkillRepository : RepositoryBase<ProjectSkillEntity>
    {
        public ProjectSkillRepository(PortfolioDbContext context) : base(context)
        {
            
        }
    }
}
