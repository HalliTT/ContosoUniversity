using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        [ValidateNever]
        public Grade? Grade { get; set; }

        [ValidateNever]
        public Course Course { get; set; }
        [ValidateNever]
        public Student Student { get; set; }
    }
}
