using System;
using System.Collections.Generic;

namespace UniversityRestApi.Models
{
    public partial class OfficeAssignment
    {
        public int InstructorId { get; set; }
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}
