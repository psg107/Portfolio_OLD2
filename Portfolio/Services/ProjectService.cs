using Portfolio.Entities;
using Portfolio.Models;
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
        private readonly IRepositoryBase<Entities.ProjectEntity> projectRepository;
        private readonly MapperService mapperService;

        public ProjectService(IRepositoryBase<Entities.ProjectEntity> projectRepository, MapperService mapperService)
        {
            this.projectRepository = projectRepository;
            this.mapperService = mapperService;
        }

        /// <summary>
        /// 프로젝트 가져오기
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Project> GetProjects()
        {
            return projectRepository.GetAll()
                                    .Select(x => this.mapperService.Mapper.Map<ProjectEntity, Project>(x));
        }

        /// <summary>
        /// 프로젝트에 사용된 스킬 가져오기
        /// </summary>
        /// <returns></returns>
        public List<CountItem<Skill>> GetProjectCountingSkill()
        {
            return GetProjects().SelectMany(x => x.Skills)
                                .GroupBy(x => x.Name)
                                .Select(x => new CountItem<Skill> { Count = x.Count(), Value = x.First() })
                                .OrderByDescending(x => x.Count)
                                .ToList();
        }
    }
}
