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
    /// <summary>
    /// <seealso cref="Models.Skill"/>
    /// </summary>
    [Table("Skill")]
    public class SkillEntity
    {
        [Key]
        public int SkillId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(ColumnSize.NAME_SIZE)]
        public string Name { get; set; }

        public virtual ICollection<ProjectSkillEntity> ProjectSkills { get; set; }
    }
}
