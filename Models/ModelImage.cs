﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MBGIE.Models
{
    public class ModelImage
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string ModelUsername { get; set; }
        public DateTime Date { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}