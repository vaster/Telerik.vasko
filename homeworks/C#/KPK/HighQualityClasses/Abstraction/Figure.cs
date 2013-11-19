using System;

namespace Abstraction
{
    // 1. Added abstract methods for perimeter and surface
    // 2. A Figure is really too common to say, we can't know about the shape so we can't judge is there any width, height etc.
    //      So all props are relocated in the right derived classes.
    // Abstract class should have only methods and props common for all his childrens. ->All Person has names, so a prop Name would be suitable for class Person.
    // 
    abstract class Figure
    {
        protected Figure()
        {
            // Empty construcotr left. Maybe a later implementaion is possible. If not the compilator will make a deafult one for as automaticlly.
            // You can add message for example ->"Figure createrd."
            //      and each time a dirved class of Figure is created will say so.
            //      this is beacouse derived class always calls his parent constructor.
        }

        public abstract double CalcPerimeter();
        public abstract double CalcSurface();
    }
}
