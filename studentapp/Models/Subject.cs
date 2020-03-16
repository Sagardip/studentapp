using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace studentapps.Models
{
    public class Subject
    {

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CreditHour { get; set; }
        public int CourseId { get; set; }
       
        public Course Course { get; set; }
    }
}