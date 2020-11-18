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
    public class ProjectRepository : IRepositoryBase<ProjectEntity>
    {
        private readonly PortfolioDbContext context;

        public ProjectRepository(PortfolioDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<ProjectEntity> GetAll()
        {
            return context.Projects.Include(nameof(ProjectEntity.ProjectSkills))
                                   .Include($"{nameof(ProjectEntity.ProjectSkills)}.{nameof(ProjectSkillEntity.Skill)}")
                                   .AsEnumerable();
        }
    }
}
