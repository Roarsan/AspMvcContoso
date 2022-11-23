using System.ComponentModel.DataAnnotations;

namespace AspMvcContoso.Models
{
    public enum Grades
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grades? Grade { get; set; }

        //Relationships or navigation properties
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
