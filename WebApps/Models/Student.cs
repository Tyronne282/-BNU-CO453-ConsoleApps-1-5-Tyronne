using System;
using System.ComponentModel.DataAnnotations;


namespace WebApps.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [StringLength(20), Required]
        public string FirstName { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [Range(0, 100)]
        public int Mark { get; set; }
    }
}
