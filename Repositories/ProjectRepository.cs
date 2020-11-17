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
    public class ProjectRepository : IRepositoryBase<Project>
    {
        private readonly PortfolioDbContext context;

        public ProjectRepository(PortfolioDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Project> GetAll()
        {
            return context.Projects.Include(nameof(Project.ProjectSkills))
                                   .Include($"{nameof(Project.ProjectSkills)}.{nameof(ProjectSkill.Skill)}")
                                   .AsEnumerable();
        }
    }
}
