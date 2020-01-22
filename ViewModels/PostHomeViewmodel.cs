using MBGIE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MBGIE.ViewModels
{
    public class PostHomeViewModel
    {
        public List<Post> Posts { get; set; }
        public List<Categories> Categories { get; set; }
        public List<Comment> Comments { get; set; }
    }
}