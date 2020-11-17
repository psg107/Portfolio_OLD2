using Portfolio.Defines;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entities
{
    [Table("Project")]
    /// <summary>
    /// <seealso cref="Model.Project"/>
    /// </summary>
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [MaxLength(ColumnSize.NAME_SIZE)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MaxLength(ColumnSize.DESCRIPTION_SIZE)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [MaxLength(ColumnSize.URL_SIZE)]
        public string SourceUrl { get; set; }

        public ICollection<ProjectSkill> ProjectSkills { get; set; }
    }
}
