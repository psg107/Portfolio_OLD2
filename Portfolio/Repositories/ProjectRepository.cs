using Portfolio.Context;
using Portfolio.Entities;

namespace Portfolio.Repositories
{
    public class ProjectRepository : EntityRepositoryBase<ProjectEntity>
    {
        public ProjectRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
