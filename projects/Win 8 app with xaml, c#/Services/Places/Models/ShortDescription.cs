using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Models
{
    public class ShortDescription
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Continent { get; set; }
        public string ShortDescriptions { get; set; }
        public ICollection<string> ImageUrl { get; set; }

        public ShortDescription()
        {
            this.ImageUrl = new List<string>();
        }
    }
}