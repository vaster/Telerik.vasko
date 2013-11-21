using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Friend
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public FriendLocation Location { get; set; }
    }
}