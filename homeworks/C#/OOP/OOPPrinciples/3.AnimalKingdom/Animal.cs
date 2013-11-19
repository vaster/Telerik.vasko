using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalKingdom
{
    public abstract class Animal
    {
        private int age;
        private string name;
        private string sex;


        //properties

        protected int Age
        {
            get { return this.age; }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Age cant be a neggative nubmer.");
                }
                this.age = value; 
            }
        }

        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        protected string Sex
        {
            get { return this.sex; }
            set 
            {
                if (value.ToString().Equals("male") || value.ToString().Equals("female"))
                {
                    this.sex = value;
                }
                else
                {
                    throw new Exception("Invalid sex. Male and Female is the only choice, you enterd ->" + this.sex);
                }
            }
        }

        //methods

        public static double CalcAvarageAge(List<Animal> animals)
        {
            double avarageAge = 0;
            for (int i = 0; i < animals.Count; i++)
            {
                avarageAge = avarageAge + animals[i].Age;
            }

            return avarageAge / animals.Count;
        }
    }
}
