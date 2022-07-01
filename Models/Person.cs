using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models {
    public abstract class Person {
        public int ID { get; set; }

        [Required]                                                  
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Shouldn't be longer than 50")]
        [Column("FirstName")]
        [Display(Name = "FirstName")]
        public string FirstMidName { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get {
                return LastName + ", " + FirstMidName; }
        }
    }
}
