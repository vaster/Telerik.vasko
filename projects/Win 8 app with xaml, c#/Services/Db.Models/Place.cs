using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Models
{
    public class Place
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Category { get; set; }
        public string Continent { get; set; }
        public virtual ICollection<ImageUrl> ImageUrl { get; set; }

        public Place()
        {
            this.ImageUrl = new HashSet<ImageUrl>();
        }
    }
}
