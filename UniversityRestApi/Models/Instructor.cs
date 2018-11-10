using System;
using System.Collections.Generic;

namespace UniversityRestApi.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            CourseAssignment = new HashSet<CourseAssignment>();
            Department = new HashSet<Department>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public string LastName { get; set; }

        public OfficeAssignment OfficeAssignment { get; set; }
        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        public ICollection<Department> Department { get; set; }
    }
}
