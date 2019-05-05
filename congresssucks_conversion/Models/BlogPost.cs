using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace congresssucks_conversion.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Tags { get; set; }
        public DateTime Updated { get; set; }
    }
}