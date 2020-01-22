using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MBGIE.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Post title is required"), Display(Name ="Post Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Post Cannot be empty"), Display(Name = "Post content"), AllowHtml,UIHint("tinyMce_jquery_full")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Date cannot be empty"), Display(Name = "Date of making post")]
        public string DateOfMakingPost { get; set; }

        
        public Categories Categories { get; set; }


        [Display(Name = "Categories"), Required(ErrorMessage = "Please Select an Image")]
        public int CategoriesId { get; set; }

        public Images Images { get; set; }

        [Display(Name = "Images")]
        public int? ImagesId { get; set; }

    }
}