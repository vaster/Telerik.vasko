using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
 Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
 Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male.
 Each animal produces a specific sound. 
 Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ)
 
 
 */
namespace _3.AnimalKingdom
{
    class Core
    {
        static void Main(string[] args)
        {
            //testing
            List<Cat> cats = new List<Cat>()
            {
                new Cat("Maca",3,"female"),
                new Kitten("Kotence",1),
                new Tomcat("Kotak",4),
            };

            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Sharo",12,"male"),
                new Dog("Marta",14,"female"),
                new Dog("Djonka",4,"male"),
            };

            List<Frog> frogs = new List<Frog>()
            {
                new Frog("Jabcho",22,"male"),
            };

            List<Animal> animals = new List<Animal>();
            animals.AddRange(cats);
            animals.AddRange(dogs);
            animals.AddRange(frogs);

            double statisticForAge = Animal.CalcAvarageAge(animals);

            Console.WriteLine("Avarage age of all animlas is {0:0.0} years", statisticForAge);
        }
    }
}
