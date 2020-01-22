using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MBGIE.Models
{
    public class ModelProfile
    {
        public int Id { get; set; }


        public ModelImage ModelImage { get; set; }
        public int? ModelImageId { get; set; }

        [Required(ErrorMessage ="Please do enter your current weight"), Display(Name ="Weight in Kg")]
        public double Weight { get; set; }

        [Required(ErrorMessage = "Please do enter your current height in centimeters"), Display(Name = "Weight in CM")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Please enter your current Age"), Display(Name = "Date of Birth")]
        public DateTime DateofBirth { get; set; }

        public Localgovernment Localgovernment { get; set; }
        public int LocalgovernmentId { get; set; }
        public int VoteCount { get; set; }

        [Required(ErrorMessage = "Please enter your First name"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your Last name"), Display(Name = "Surname")]
        public string LatName { get; set; }

        public bool IsActive { get; set; }

        public int Position { get; set; }

        
    }
}