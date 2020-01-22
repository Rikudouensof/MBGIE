using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MBGIE.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
    }
}