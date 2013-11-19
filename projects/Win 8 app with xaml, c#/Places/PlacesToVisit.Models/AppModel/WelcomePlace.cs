using PlacesToVisit.Models.PlacesCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacesToVisit.Models.AppModel
{
    public class WelcomePlace
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Continent { get; set; }
    }
}
