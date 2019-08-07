﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EntityFrameworkBegins.Models {
    class Major {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Range(600,2400)]
        public int MinSat { get; set; }

        public Major() {

        }
    }
}
