using Portfolio.Defines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Entities
{
    [Table("Skill")]
    /// <summary>
    /// <seealso cref="Model.Skill"/>
    /// </summary>
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(ColumnSize.NAME_SIZE)]
        public string Name { get; set; }

        public ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
