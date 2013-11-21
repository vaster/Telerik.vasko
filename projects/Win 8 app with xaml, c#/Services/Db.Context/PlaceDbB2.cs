using Db.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Context
{
    public class PlaceDbB2 :DbContext
    {
        public PlaceDbB2()
            : base("PlaceDbB2")
        {
        }

        public DbSet<Place> Places { get; set; }
        public DbSet<ImageUrl> ImageUrls { get; set; }
    }
}
