using System.Collections.Generic;
using studentapps.Models;

namespace studentapps.ViewModels
{
    public class CourseCreateVM
    {
        public int Id { get; set; }
        public string title{ get; set; }
         public IEnumerable<Subject> Subject { get; set; }
         public int SelectedSubjectId { get; set; }
    }
}