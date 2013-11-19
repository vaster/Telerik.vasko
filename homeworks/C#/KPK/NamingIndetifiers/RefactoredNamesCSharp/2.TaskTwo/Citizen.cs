using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredNamesCSharp
{
    public class Citizen
    {
        private enum Sex
        {
            Male,
            Female,
        };

        public void GenerateHuman(int uniqeHumanNumber)
        {
            Human human = new Human();
            human.Age = uniqeHumanNumber;

            if (uniqeHumanNumber % 2 == 0)
            {
                human.Name = "Batkata";
                human.Sex = Sex.Male;
            }
            else
            {
                human.Name = "Maceto";
                human.Sex = Sex.Female;
            }
        }

        private class Human
        {
            public Sex Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
