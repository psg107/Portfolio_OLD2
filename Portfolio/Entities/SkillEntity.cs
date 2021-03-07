using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entities
{
    /// <summary>
    /// <seealso cref="Models.Skill"/>
    /// </summary>
    [Table("Skill")]
    public class SkillEntity : IEntity
    {
        [Key]
        public int SkillId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
