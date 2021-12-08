using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace Portfolio.Context
{
    public static class PortfolioDbContextSeed
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static (List<Entities.SkillEntity> skills, List<ProjectEntity> projects, List<ProjectSkillEntity> projectSkills) GenerateData()
        {
            var projectsJsonFile = File.ReadAllTextAsync("Project.json", Encoding.UTF8).Result;
            var projects = JsonSerializer.Deserialize<List<Project>>(projectsJsonFile, new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

#warning 이곳에서 입력된 json데이터 검증 필요
            //프로젝트에 중복된 스킬이 있으면 오류

            //대소문자 및 공백을 무시하고 비교했을 때 동일한 스킬이 여러 개 이상 존재하면 오류

            //기타 등등..

            var skillEntities = projects
                .SelectMany(x => x.Skills)
                .Distinct()
                .Select((x, i) => new SkillEntity
                {
                    Name = x,
                    SkillId = i + 1
                })
                .ToList();

            var projectEntities = projects
                .Select((x, i) => new ProjectEntity
                {
                    ProjectId = i + 1,
                    Name = x.Name,
                    ProjectType = new Func<ProjectType>(() =>
                    {
                        var projectTypes = x.ProjectType.Select(y => (ProjectType)Enum.Parse(typeof(ProjectType), y));

                        ProjectType output = ProjectType.None;

                        foreach (var projectType in projectTypes)
                        {
                            output = output | projectType;
                        }

                        return output;
                    }).Invoke(),
                    Description = x.Description,
                    CreateYear = x.CreateYear,
                    SourceUrl = x.SourceUrl,
                    IsHiddenSourceUrl = x.IsHiddenSourceUrl,
                    ReferenceUrl = x.ReferenceUrl,
                    ImageFilePath = x.ImageFilePath,
                    IsHidden = x.IsHidden
                })
                .ToList();

            var projectSkillEntities = projectEntities
                .Select(x => new
                {
                    ProjectId = x.ProjectId,
                    SkillIds = projects.FirstOrDefault(y => y.Name == x.Name)?.Skills?.Select(y =>
                    {
                        var skillEntity = skillEntities.FirstOrDefault(z => z.Name == y);
                        var skillId = skillEntity.SkillId;
                        return skillId;
                    })
                })
                .SelectMany(x => x.SkillIds, (parent, child) => new ProjectSkillEntity
                {
                    ProjectId = parent.ProjectId,
                    SkillId = child
                })
                .ToList();

            return (skillEntities, projectEntities, projectSkillEntities);
        }
    }
}
