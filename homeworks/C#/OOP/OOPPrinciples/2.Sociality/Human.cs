using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sociality
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;



        //properties

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }


        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
    }
}
