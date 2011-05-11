using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class PostTag
    {
        public Post post { get; set; }
        public Tagi tag { get; set; }
    }
}