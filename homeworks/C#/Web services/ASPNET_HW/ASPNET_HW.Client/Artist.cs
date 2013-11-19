using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_HW.Models
{
    public class Artist
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}