using Portfolio.Context;
using Portfolio.Entities;

namespace Portfolio.Repositories
{
    public class ProjectRepository : RepositoryBase<ProjectEntity>
    {
        public ProjectRepository(PortfolioDbContext context) : base(context)
        {
        }
    }
}
