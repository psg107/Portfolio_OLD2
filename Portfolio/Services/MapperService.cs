using AutoMapper;
using Portfolio.Entities;
using Portfolio.Models;
using System.Linq;

namespace Portfolio.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class MapperService
    {
        public IMapper Mapper { get; private set; }

        public MapperService()
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.CreateMap<SkillEntity, Skill>();
                config.CreateMap<ProjectEntity, Project>()
                    .ForMember(dest => dest.Skills,
                               option =>
                               {
                                   option.MapFrom(src => src.ProjectSkills.Select(x => Mapper.Map<SkillEntity, Skill>(x.Skill)));
                               });
            });

            this.Mapper = mapperConfiguration.CreateMapper();
        }
    }
}
