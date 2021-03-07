using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [Table("ProjectSkill")]
    public class ProjectSkillEntity : IEntity
    {
        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
        public ProjectEntity Project { get; set; }

        [ForeignKey(nameof(Skill))]
        public int SkillId { get; set; }
        public SkillEntity Skill { get; set; }

        public virtual ICollection<ProjectSkillEntity> ProjectSkills { get; set; }
    }
}
