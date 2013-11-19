using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    public abstract class People
    {
        private string name;

        //properties

        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
