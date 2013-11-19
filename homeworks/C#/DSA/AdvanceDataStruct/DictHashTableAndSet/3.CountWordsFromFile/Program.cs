using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountWordsFromFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("word.txt");
            StringBuilder text = new StringBuilder();
            int startCount = 0;

            using (reader)
            {
                text.Append(reader.ReadToEnd().ToLower());
            }

            string[] words = text.ToString().Split(
                new char[] { '.', ' ', '!', '?','-',',' }, StringSplitOptions.RemoveEmptyEntries);

            IDictionary<string, int> wordsByOccurences = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordsByOccurences.ContainsKey(word))
                {
                    wordsByOccurences[word]++;
                }
                else
                {
                    wordsByOccurences.Add(word, startCount + 1);
                }
            }


            var order = from word in wordsByOccurences
                        orderby word.Value
                        select word;

            foreach (var item in order)
            {
                
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
