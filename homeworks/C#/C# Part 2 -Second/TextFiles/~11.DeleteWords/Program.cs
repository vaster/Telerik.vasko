using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.DeleteWords
{

    /*
     Write a program that deletes from a text file all words that start with the prefix "test".
     Words contain only the symbols 0...9, a...z, A…Z, _.
    */
    internal class Program
    {
        public const string SOURCE_PATH = "source.txt";

        public const string RESULT_PATH = "result.txt";

        public const string PREFIX_BY_PATTERN = "test";

        public static void ReadInput(IList<string> input)
        {
            StreamReader reader = new StreamReader(Program.SOURCE_PATH);

            string currLine = "";

            using (reader)
            {
                while (currLine != null)
                {
                    currLine = reader.ReadLine();

                    if (currLine != null)
                    {
                        input.Add(currLine);
                    }
                }
            }
        }

        public static void FindIndexesOfPatternPrefix(IList<string> input, IList<int> startIndexesOfPatterPrefix)
        {
            for (int currLine = 0; currLine < input.Count; currLine++)
            {
                int currPrefixIndex = 0;

                while (currPrefixIndex >= 0)
                {
                    currPrefixIndex = input[currLine].IndexOf(Program.PREFIX_BY_PATTERN, currPrefixIndex);
                    startIndexesOfPatterPrefix.Add(currPrefixIndex);
                    if (currPrefixIndex >= 0)
                    {
                        currPrefixIndex++;
                    }
                }
            }
        }

        public static StringBuilder RemoveWordsWithPrefixByPattern(IList<string> input, IList<int> startIndexesOfPatterPrefix)
        {
            StringBuilder result = new StringBuilder();
            int currPrefixIndex = 0;

            for (int currLineIndex = 0; currLineIndex < input.Count; currLineIndex++)
            {
                string line = input[currLineIndex];

                for (int currSymbolIndex = 0; currSymbolIndex < line.Length; currSymbolIndex++)
                {
                    if (!(currSymbolIndex >= startIndexesOfPatterPrefix[currPrefixIndex]))
                    {
                        result.Append(line[currSymbolIndex]);
                    }

                    else if (currSymbolIndex == line.IndexOf(' ', currSymbolIndex))
                    {
                        currPrefixIndex++;
                    }
                }
            }

            return result;
        }

        public static void WriteToFile(StringBuilder result)
        {
            StreamWriter writer = new StreamWriter(Program.RESULT_PATH);

            using (writer)
            {
                writer.Write(result.ToString());
            }
        }

        static void Main(string[] args)
        {
            IList<string> input = new List<string>();
            IList<int> startIndexesOfPatterPrefix = new List<int>();

            Program.ReadInput(input);
            Program.FindIndexesOfPatternPrefix(input, startIndexesOfPatterPrefix);
            StringBuilder result = Program.RemoveWordsWithPrefixByPattern(input, startIndexesOfPatterPrefix);

            Program.WriteToFile(result);
        }
    }
}
