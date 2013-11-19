using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TaskOne
{

    public class Chef
    {
        //Straight - line code rules implement:
        //  1. Cook() at first position in our code.
        //  2.Logicaly separate group-related methods with empty line.
        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();

            Peel(potato);
            Peel(carrot);

            Cut(potato);
            Cut(carrot);

            Bowl bowl = GetBowl();
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Carrot GetCarrot()
        {
            //...
            return new Carrot();
        }

        private Potato GetPotato()
        {
            //...
            return new Potato();
        }

        private void Cut(Vegetable potato)
        {
           
            //...
        }

        private void Peel(Vegetable vegetable)// Added Peel method instead of the second 'public void Cook()'.
        {
            //TODO:
        }

        private Bowl GetBowl()
        {
            //... 
            return new Bowl();
        } 
    }
}

