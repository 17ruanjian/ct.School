using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ct.School.Core.Models
{
    /// <summary>
    /// 报名
    /// </summary>
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }

    }
}
