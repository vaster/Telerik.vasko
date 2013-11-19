using PlacesToVisit.Models.PlacesCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacesToVisit.Models.AppModel
{
    public class PlaceShortDescription
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Images { get; set; }
        public Category Category { get; set; }

        public PlaceShortDescription()
        {
        }
    }
}
