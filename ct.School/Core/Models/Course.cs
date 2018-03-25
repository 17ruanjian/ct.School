using System.Collections.Generic;
using ct.School.Application.EnumsType;

namespace ct.School.Core.Models
{
    public class Course
    {
        /// <summary>
        /// 课程
        /// </summary>
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public CourseGrade Grade { get; set; }
        public ICollection <Enrollment> Enrollments { get; set; }

    }
}