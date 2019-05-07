using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieLibrary.Models
{
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string director { get; set; }
    }
}