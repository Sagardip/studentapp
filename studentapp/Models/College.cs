using System;
using System.Collections;
using System.Collections.Generic;

namespace studentapps.Models
{
    public class College
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public ICollection<Student> Students { get; set; }

        internal void Remove()
        {
            throw new NotImplementedException();
        }
    }
}
