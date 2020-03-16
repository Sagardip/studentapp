using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace studentapps.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string title { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public Course()
        {
            Subjects = new Collection<Subject>();
        }
    }
}
