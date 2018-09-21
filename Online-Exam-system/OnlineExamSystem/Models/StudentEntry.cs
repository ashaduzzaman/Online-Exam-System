using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineExamSystem.Models
{
    public class StudentEntry
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Code { get; set; }
        public string Duration { get; set; }
        public string Credit { get; set; }
    }
}