using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspMvcContoso.Models
{ 
    public class Student
    {
        public int ID { get; set; }
        [Required, StringLength(20)]
        public string LastName { get; set; }
        [Required, StringLength(20)]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        //Relationships or navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
