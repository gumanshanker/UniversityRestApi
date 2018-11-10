using System;
using System.Collections.Generic;

namespace UniversityRestApi.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseAssignment = new HashSet<CourseAssignment>();
            Enrollment = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }
        public string Title { get; set; }

        public Department Department { get; set; }
        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
