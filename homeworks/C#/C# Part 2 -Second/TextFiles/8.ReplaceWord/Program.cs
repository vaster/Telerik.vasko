using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ReplaceWord
{
    /*
     Modify the solution of the previous problem to replace only whole words (not substrings).

     */

    internal class Program
    {
        public const string SOURCE_PATH = "source.txt";

        public const string RESULT_PATH = "result.txt";

        public static StringBuilder ReadInput()
        {
            StreamReader reader = new StreamReader(Program.SOURCE_PATH);
            StringBuilder input = new StringBuilder();

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    input.Append(reader.ReadLine());
                }
            }

            return input;
        }

        public static StringBuilder ReplaceWord(StringBuilder input)
        {
            StringBuilder result = new StringBuilder();

            const string seekedSubstring = "start";
            const string alternative = "finish";

            int index = 0;

            index = input.ToString().IndexOf(seekedSubstring, index);

            for (int i = 0; i < input.Length; i++)
            {
                if (i > index + seekedSubstring.Length)
                {
                    result.Append(input[i]);
                }
            }

            return result;
        }

        public static void WriteResult(StringBuilder result)
        {
            StreamWriter writer = new StreamWriter(Program.RESULT_PATH);

            using (writer)
            {
                writer.Write(result);
            }
        }

        static void Main(string[] args)
        {
            StringBuilder input = Program.ReadInput();
            StringBuilder result = Program.ReplaceWord(input);
            //Program.WriteResult(result);
        }
    }
}
