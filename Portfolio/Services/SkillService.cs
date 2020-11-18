using Portfolio.Entities;
using Portfolio.Models;
using Portfolio.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Services
{
    [Obsolete("안씀")]
    /// <summary>
    /// 
    /// </summary>
    public class SkillService
    {
        private readonly IRepositoryBase<Entities.SkillEntity> skillRepository;
        private readonly MapperService mapperService;

        public SkillService(IRepositoryBase<Entities.SkillEntity> skillRepository, MapperService mapperService)
        {
            this.skillRepository = skillRepository;
            this.mapperService = mapperService;
        }

        public List<Skill> GetSkills()
        {
            return skillRepository.GetAll()
                                  .Select(x => this.mapperService.Mapper.Map<SkillEntity, Skill>(x))
                                  .ToList();
        }
    }
}
