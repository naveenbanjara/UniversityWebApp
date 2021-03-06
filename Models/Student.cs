using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required,StringLength(50, MinimumLength = 2) ,Display(Name ="Last Name")]
        public string LastName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required, StringLength(50, MinimumLength = 2, ErrorMessage ="First Name cannot be longer than 50 characters"),
            Column("FirstName") ,Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date),DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true),
            Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        public string FullName
        {
            get
            {
                return LastName + "," + FirstMidName;
            }
        }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
