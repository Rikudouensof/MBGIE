using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MBGIE.Models
{
    public class ContactUs
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Date")]
        public DateTime DateofContact { get; set; }



        [EmailAddress, Required, Display(Name ="Email" )]
        public string Email { get; set; }

        [StringLength(maximumLength:150, MinimumLength = 3)]
        [Required, Display(Name = "Title")]
        public string Title { get; set; }

        [StringLength(int.MaxValue, MinimumLength = 7)]
        public string Body { get; set; }
    }
}