using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkBegins.Models {
    public class Course {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Instructor { get; set; }
        public int Credits { get; set; }
        public int MajorId { get; set; }

        public Course() {


        }


    }
}
