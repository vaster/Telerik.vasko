using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Models
{
    public class ImageUrl
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public virtual Place Place { get; set; }
    }
}
