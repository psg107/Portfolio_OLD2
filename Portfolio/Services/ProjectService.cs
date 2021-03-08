using Microsoft.EntityFrameworkCore;
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
        private readonly ProjectRepository projectRepository;
        private readonly SkillRepository skillRepository;
        private readonly ProjectSkillRepository projectSkillRepository;
        private readonly MapperService mapperService;

        public ProjectService(
            ProjectRepository projectRepository, 
            SkillRepository skillRepository,
            ProjectSkillRepository projectSkillRepository,
            MapperService mapperService)
        {
            this.projectRepository = projectRepository;
            this.skillRepository = skillRepository;
            this.projectSkillRepository = projectSkillRepository;
            this.mapperService = mapperService;
        }

        /// <summary>
        /// 프로젝트 가져오기
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Project> GetProjects()
        {
            var projects = projectRepository.GetAll()
                                            .Where(x => !x.IsHidden)
                                            .Include(x => x.ProjectSkills)
                                            .Include($"{nameof(ProjectEntity.ProjectSkills)}.{nameof(ProjectSkillEntity.Skill)}")
                                            .Select(x => this.mapperService.Mapper.Map<ProjectEntity, Project>(x));

            return projects;
        }

        /// <summary>
        /// 프로젝트에 사용된 스킬 가져오기
        /// </summary>
        /// <returns></returns>
        public List<CountItem> GetProjectCountingSkill()
        {
            var skills = projectRepository.GetAll()
                .Where(x => !x.IsHidden)
                .SelectMany(x => x.ProjectSkills)
                .GroupBy(x => new { x.SkillId, x.Skill.Name })
                .Select(x => new CountItem
                {
                    Name = x.Key.Name,
                    Id = x.Key.SkillId,
                    Count = x.Count()
                })
                .OrderByDescending(x => x.Count);

            return skills.ToList();
        }
    }
}
