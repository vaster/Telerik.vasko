using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string SessionKey { get; set; }
        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<User> Friends { get; set; }

        public User()
        {
            this.Friends = new HashSet<User>();
        }
    }
}
