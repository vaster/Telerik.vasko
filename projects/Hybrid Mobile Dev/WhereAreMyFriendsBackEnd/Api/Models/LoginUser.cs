﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class LoginUser
    {
        public string Username { get; set; }
        public string CryptPass { get; set; }
    }
}