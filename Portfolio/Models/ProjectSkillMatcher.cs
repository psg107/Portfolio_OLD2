using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class ProjectSkillMatcher
    {
        public ProjectEntity Project { get; set; }

        public List<SkillEntity> Skills { get; set; }
    }
}
