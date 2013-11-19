using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace major
{

    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct | System.AttributeTargets.Method | System.AttributeTargets.Interface | System.AttributeTargets.Enum)
]
    public class Version: System.Attribute
    {
        private string name;
        private double version;

        public Version(string name)
        {
            this.name = name;
            version = 1.5;
        }

        public double VersionCheck
        {
            get
            {
                return version;
            }
        }
    }



    [Version("minor")]
    public class Sample
    {

       
       
    }
}
