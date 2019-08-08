using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkBegins.Models {
    public class Schedule{

        public int Id { get; set; }  
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }


        public virtual Student student { get; set; }
        public virtual Course course { get; set; }


        public Schedule() {


        }

    }
}
