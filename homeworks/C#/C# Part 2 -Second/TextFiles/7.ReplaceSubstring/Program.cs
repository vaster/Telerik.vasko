using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.ReplaceSubstring
{
    internal class Program
    {

        /*
         Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file.
         Ensure it will work with large files (e.g. 100 MB).
         */

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

        public static StringBuilder ReplaceSubstring(StringBuilder input)
        {
            StringBuilder result = new StringBuilder();

            const string seekedSubstring = "start";
            const string alternative = "finish";

            result.Append(input.Replace(seekedSubstring, alternative));

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
            StringBuilder result = Program.ReplaceSubstring(input);
            Program.WriteResult(result);
        }
    }
}
