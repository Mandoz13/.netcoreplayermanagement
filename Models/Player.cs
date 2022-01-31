using System;
using System.ComponentModel.DataAnnotations;

namespace PlayerManagement.Models
{
    public class Player
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name should be less than 100 character")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-mm-yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required]
        [Display(Name = "Height in cm")]
        public string Height { get; set; }

        [Required]
        [Display(Name = "Weight in kg")]
        public string Weight { get; set; }

        [Required(ErrorMessage = "Birth place name should less than 100 character")]
        [StringLength(100)]
        public string BirthPlace { get; set; }
        
        [Display(Name = "Team Signed To")]
        public string TeamSigned { get; set; }

        public int? TeamId { get; set; }
        public string TeamName { get; set; }
        public Team Team { get; set; }

    }
}
