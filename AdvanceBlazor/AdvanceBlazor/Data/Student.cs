using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvanceBlazor.Data
{
    public class Student
    {
        [Key]
        public int StudentID  { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City  { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }


    }
}
