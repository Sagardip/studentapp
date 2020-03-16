using System.Collections.Generic;
using studentapps.Models;

namespace studentapps.ViewModels
{
    public class StudentDetailsVM
    {
        public string Name { get; set; }
        public string Roll_no { get; set; }
        public College  College { get; set; }
        public string  EditImagePath { get; set; }
       
    }
}