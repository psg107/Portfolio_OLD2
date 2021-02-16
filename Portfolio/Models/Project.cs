using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    /// <summary>
    /// <seealso cref="Entities.ProjectEntity"/>
    /// </summary>
    public class Project
    {
        public int ProjectId { get; set; }

        /// <summary>
        /// 이름
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 종류
        /// </summary>
        public ProjectType ProjectType { get; set; }

        /// <summary>
        /// 설명
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 프로젝트 제작일
        /// </summary>
        public int? CreateYear { get; set; }

        /// <summary>
        /// 소스코드 경로
        /// </summary>
        public string SourceUrl { get; set; }

        /// <summary>
        /// 참고 주소
        /// </summary>
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// 이미지 경로
        /// </summary>
        public string ImageFilePath { get; set; }

        /// <summary>
        /// 사용 기술
        /// </summary>
        public List<Skill> Skills { get; set; }
    }
}
