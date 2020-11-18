using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entities
{
    /// <summary>
    /// 
    /// </summary>
    [Table("ProjectSkill")]
    public class ProjectSkillEntity
    {
        public int ProjectId { get; set; }

        public ProjectEntity Project { get; set; }

        public int SkillId { get; set; }

        public SkillEntity Skill { get; set; }
    }
}
