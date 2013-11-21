﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UserToUser
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int FriendId { get; set; }
        public virtual User Friend { get; set; }
    }
}
