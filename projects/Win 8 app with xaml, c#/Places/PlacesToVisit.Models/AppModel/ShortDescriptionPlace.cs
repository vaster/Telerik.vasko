using PlacesToVisit.Models.PlacesCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacesToVisit.Models.AppModel
{
    public class ShortDescriptionPlace
    {
        public string Title { get; set; }
        public string ShortDescriptions { get; set; }
        public IList<string> ImageUrl { get; set; }
        public string Category { get; set; }
        public string Continent { get; set; }

        public ShortDescriptionPlace()
        {
            this.ImageUrl = new List<string>();
        }
    }
}
