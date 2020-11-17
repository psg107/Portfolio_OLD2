using Portfolio.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Context
{
    public static class PortfolioDbContextSeed
    {
        private enum Skill
        {
            CSharp,
            EntityFramework
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static (List<Entities.Skill> skills, List<Project> projects, List<ProjectSkill> projectSkills) GenerateSeed()
        {
            var skillIndex = 1;
            var skills = new List<Entities.Skill>
            {
                new Entities.Skill
                {
                    SkillId = skillIndex++,
                    Name = Skill.CSharp.ToString()
                },
                new Entities.Skill
                {
                    SkillId = skillIndex++,
                    Name = Skill.EntityFramework.ToString()
                }
            };

            var projectIndex = 1;
            var projects = new List<Project>
            {
                new Project
                {
                    ProjectId = projectIndex++,
                    Name = "테스트",
                    Description = "테스트설명.."
                }
            };

            var projectSkills = new List<ProjectSkill>
            {
                new ProjectSkill
                {
                    ProjectId = projects.SingleOrDefault(x => x.Name == "테스트").ProjectId,
                    SkillId = skills.SingleOrDefault(x => x.Name == Skill.CSharp.ToString()).SkillId
                },
                new ProjectSkill
                {
                    ProjectId = projects.SingleOrDefault(x => x.Name == "테스트").ProjectId,
                    SkillId = skills.SingleOrDefault(x => x.Name == Skill.EntityFramework.ToString()).SkillId
                }
            };

            return (skills, projects, projectSkills);
        }
    }
}
