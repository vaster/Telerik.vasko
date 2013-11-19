using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SOURCE_PATH = "info.txt";

            const string OUTPUT_PATH = "xml-info.xml";


            string[] personInfoTxt = File.ReadAllLines(SOURCE_PATH);

            XElement personInfo = 
                new XElement("personInfo",
                    new XElement("name",personInfoTxt[0]),
                    new XElement("address",personInfoTxt[1]),
                    new XElement("phone",personInfoTxt[2]));

            personInfo.Save(OUTPUT_PATH);
        }
    }
}
