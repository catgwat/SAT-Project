using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace SAT.DATA.EF.Models
{
    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student 
    {
        [NotMapped]
        public IFormFile? Image { get; set; }
    }

    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }

    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment { }

    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }

    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }

    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus { }
}
