using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKingdom
{
    public class Dog: Animal,ISound
    {
        public Dog(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex.ToLower();
        }


        public void Roar()
        {
            Console.WriteLine("Bay bay!");
        }
    }
}
