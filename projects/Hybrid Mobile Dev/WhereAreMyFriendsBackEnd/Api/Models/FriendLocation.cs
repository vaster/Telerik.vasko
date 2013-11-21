using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class FriendLocation
    {
        public double Lathitude { get; set; }
        public double Longitude { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Time { get; set; }
    }
}