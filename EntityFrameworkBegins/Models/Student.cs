using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkBegins.Models {
    public class Student {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30)]
        public string Lastname { get; set; }
        [Range(600,2400, ErrorMessage = "SAT score 600 <= x <= 2400")]
        public int SAT { get; set; }
        public double GPA { get; set; }
        public bool IsFulltime { get; set; } = true;

        public int? MajorId { get; set; }
        public virtual Major Major { get; set; }

        public override string ToString() {
            return $"{this.Id}, Name[{this.Firstname} {this.Lastname}] {this.Major}";
        }
        public Student() {


        }
    }
}
