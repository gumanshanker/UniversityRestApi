using System;
using System.Collections.Generic;

namespace UniversityRestApi.Models
{
    public partial class Student
    {
        public Student()
        {
            Enrollment = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Enrollment> Enrollment { get; set; }
    }
}
