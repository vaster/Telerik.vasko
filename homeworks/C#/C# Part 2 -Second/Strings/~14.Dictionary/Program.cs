using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    /*
     A dictionary is stored as a sequence of text lines containing words and their explanations.
     * Write a program that enters a word and translates it by using the dictionary.
     * Sample dictionary:
     * 
     * .NET – platform for applications from Microsoft
        CLR – managed execution environment for .NET
        namespace – hierarchical organization of classes

     */
    internal class Program
    {
        public static StringBuilder GetTranslation(string[] dictionary, string word)
        {
            StringBuilder result = new StringBuilder();

            string[] currTranslation = new string[2];
            
            foreach (var dictItem in dictionary)
            {
                currTranslation = dictItem.Split('–');

                if (currTranslation[0].Trim() == word)
                {
                    result.Append(word + " -->" + currTranslation[1]);
                }
    
            }

            return result;
        }

        static void Main(string[] args)
        {
            string[] dictionary = { ".NET – platform for applications from Microsoft",
                                    "CLR – managed execution environment for .NET",
                                    "namespace – hierarchical organization of classes"
                                  };

            string[] words = { ".NET", "CLR", "namespace" };

            foreach (var word in words)
            {
                Console.WriteLine(Program.GetTranslation(dictionary,word));
            }


        }
    }
}
