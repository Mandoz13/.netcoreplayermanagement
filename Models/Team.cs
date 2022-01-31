

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayerManagement.Models
{
    public class Team
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Team name should be less than 100 character")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = " Ground name should be less than 100 character")]
        [StringLength(100)]
        public string Ground { get; set; }


        [Required(ErrorMessage = "Coach name should be less than 100 character")]
        [StringLength(100)]
        public string Coach { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Founded Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-YY-dd}")]
        public DateTime FoundedYear { get; set; }

        [Required]
        public string Region { get; set; }

        public List<Player> Players { get; set; } 
     
    }
}
