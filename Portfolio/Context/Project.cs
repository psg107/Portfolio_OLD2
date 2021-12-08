using Portfolio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Context
{
    public class Project
    {
        public string Name { get; set; }
        public List<string> ProjectType { get; set; }
        public string Description { get; set; }
        public int? CreateYear { get; set; }
        public string SourceUrl { get; set; }
        public bool IsHiddenSourceUrl { get; set; }
        public string ReferenceUrl { get; set; }
        public string ImageFilePath { get; set; }
        public bool IsHidden { get; set; }
        public List<string> Skills { get; set; } = new List<string>();
    }
}
