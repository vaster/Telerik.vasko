﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKingdom
{
    public class Kitten: Cat
    {
        public Kitten(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = "female";
        }

    }
}
