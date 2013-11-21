using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Places.Models
{
    public class WelcomePlace
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Continent { get; set; }
        public string ImageUrl { get; set; }

        public WelcomePlace()
        {
        }
    }
}