using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF
{
    public class StudentMetadata
    {
        public int StudentId { get; set; }

        [Required (ErrorMessage = "First name is required!")]
        [StringLength(20, ErrorMessage = "First name must be 20 characters or less.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last name is required!")]
        [StringLength(20, ErrorMessage = "Last name must be 20 characters or less.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; } = null!;

        [StringLength(15, ErrorMessage = "Major must be 15 characters or less.")]
        public string? Major { get; set; }

        [StringLength(50)]
        public string? Address { get; set; }

        [StringLength(25)]
        public string? City { get; set; }

        [StringLength(2)]
        public string? State { get; set; }

        [StringLength(10)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip code")]
        public string? ZipCode { get; set; }

        [StringLength(13)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required (ErrorMessage = "Email is required!")]
        [StringLength(60)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = null!;

        [StringLength(100)]
        [Display(Name = "Image")]
        public string? PhotoUrl { get; set; }

        [Required]
        [Display(Name = "Student Status Id")]
        public int Ssid { get; set; }
    }

    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Start date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(40)]
        [Display(Name = "Instructor name")]
        public string InstructorName { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string Location { get; set; } = null!;

        [Required]
        [Display(Name = "Scheduled Class Status Id")]
        public int Scsid { get; set; }
    }

    public class CourseMetadata
    {
        public int CourseId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Course name")]
        public string CourseName { get; set; } = null!;

        [Required]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [UIHint("Multiline text")]
        public string CourseDescription { get; set; } = null!;

        [Required]
        [Display(Name = "Credit hours")]
        [Range(0, 10)]
        public byte CreditHours { get; set; }

        [StringLength(250)]
        public string? Curriculum { get; set; }

        [StringLength(500)]
        [DataType(DataType.MultilineText)]
        [UIHint("Multiline text")]
        public string? Notes { get; set; }

        [Required]
        [Display(Name = "Active?")]
        public bool IsActive { get; set; }
    }

    public class EnrollmentMetadata
    {
        public int EnrollmentId { get; set; }

        [Required]
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Scheduled Class Id")]
        public int ScheduledClassId { get; set; }

        [Required]
        [Display(Name = "Enrollment Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime EnrollmentDate { get; set; }
    }

    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Name")]
        public string Ssname { get; set; } = null!;

        [StringLength(250)]
        [Display(Name = "Description")]
        public string? Ssdescription { get; set; }
    }

    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Scsname { get; set; } = null!;
    }
}
