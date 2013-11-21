using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Location
    {
        public int Id { get; set; }
        public double Lathitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public DateTime? DateAdded { get; set; }
    }
}
