using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Portfolio.Entities
{
    [Flags]
    public enum ProjectType
    {
        /// <summary> 미설정 </summary>
        None = 0,

        /// <summary> 개인 </summary>
        Private = 1,

        /// <summary> 회사 </summary>
        Company = 2,

        /// <summary> 미완성 </summary>
        Incomplete = 4,

        /// <summary> 사용안함 </summary>
        Deprecated = 8
    }

    /// <summary>
    /// <seealso cref="Models.Project"/>
    /// </summary>
    [Table("Project")]
    public class ProjectEntity : IEntity
    {
        [Key]
        public int ProjectId { get; set; }

        /// <summary>
        /// 프로젝트명
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 프로젝트 종류
        /// </summary>
        [DefaultValue(ProjectType.None)]
        public ProjectType ProjectType {get;set;}

        /// <summary>
        /// 설명
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; }

        /// <summary>
        /// 제작년도 (모르면 null)
        /// </summary>
        [Range(2000, 2100)]
        public int? CreateYear { get; set; }

        /// <summary>
        /// 소스 주소
        /// </summary>
        [MaxLength(100)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 관련 주소
        /// </summary>
        [MaxLength(1000)]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// 이미지 경로
        /// </summary>
        public string ImageFilePath { get; set; }

        /// <summary>
        /// 사용 스킬
        /// </summary>
        public virtual ICollection<ProjectSkillEntity> ProjectSkills { get; set; }
    }
}
