using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class RegisterUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string CryptPass { get; set; }

        public ICollection<string> Contacts { get; set; }

        public RegisterUser()
        {
            this.Contacts = new HashSet<string>();
        }
    }
}