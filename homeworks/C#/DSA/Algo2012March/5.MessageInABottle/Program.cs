using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.MessageInABottle
{
    public class Program
    {
        public static StringBuilder result = new StringBuilder();

        public static void Traverse(string code, Dictionary<string, char> cypers, int index)
        {
            foreach (var item in cypers)
            {
                if (item.Key == code)
                {
                    result.Append(code[index]);
                }
                Traverse(code.Substring(index),cypers,1);
            }
        }

        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            string cyper = Console.ReadLine();
            bool toAdd = false;

            Dictionary<string, char> cypers = new Dictionary<string, char>();

            char currSyper = '\0';
            StringBuilder currCode = new StringBuilder();

            for (int i = 0; i < cyper.Length; i++)
            {
                if (cyper[i] >= 'A' && cyper[i] <= 'Z')
                {
                    if (toAdd)
                    {
                        cypers.Add(currCode.ToString(), currSyper);
                        currCode.Clear();
                    }
                    currSyper = cyper[i];
                    toAdd = false;
                }
                else
                {
                    toAdd = true;
                    currCode.Append(cyper[i]);
                    if (i == cyper.Length - 1)
                    {
                        cypers.Add(currCode.ToString(), currSyper);
                    }
                }
            }
        }
    }
}
