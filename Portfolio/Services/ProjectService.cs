using Portfolio.Entities;
using Portfolio.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class ProjectService
    {
        private readonly IRepositoryBase<Entities.Project> projectRepository;

        public ProjectService(IRepositoryBase<Entities.Project> projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public List<Project> GetProjects()
        {
            return projectRepository.GetAll().ToList();
        }
    }
}
