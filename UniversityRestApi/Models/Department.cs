using System;
using System.Collections.Generic;

namespace UniversityRestApi.Models
{
    public partial class Department
    {
        public Department()
        {
            Course = new HashSet<Course>();
        }

        public int DepartmentId { get; set; }
        public decimal Budget { get; set; }
        public int? InstructorId { get; set; }
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
        public DateTime StartDate { get; set; }

        public Instructor Instructor { get; set; }
        public ICollection<Course> Course { get; set; }
    }
}
