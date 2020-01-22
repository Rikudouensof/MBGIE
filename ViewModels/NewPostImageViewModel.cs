using MBGIE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MBGIE.ViewModels
{
    public class NewPostImageViewModel
    {
        public List<Categories> Categories { get; set; }
        public Post Post { get; set; }
        public Images Imagesz { get; set; }
    }
}