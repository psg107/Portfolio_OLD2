using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entities
{
    [Table("ProjectSkill")]
    /// <summary>
    /// 
    /// </summary>
    public class ProjectSkill
    {
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        public int SkillId { get; set; }

        public Skill Skill { get; set; }
    }
}
