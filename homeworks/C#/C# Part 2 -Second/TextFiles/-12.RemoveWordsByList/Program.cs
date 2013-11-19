using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RemoveWordsByList
{
    /*
     Write a program that removes from a text file all words listed in given another text file.
     Handle all possible exceptions in your methods.

     */

    internal class Program
    {
        public const string SOURCE_PATH = "source.txt";

        public const string LIST_OF_WORDS_TO_DELETE_PATH = "words-for-delete.txt";

        public const string RESULT_PATH = "result.txt";

        public static void ReadInput(List<string> input)
        {
            try
            {
                StreamReader reader = new StreamReader(Program.SOURCE_PATH);

                using (reader)
                {
                    string currLine = null;
                    while (!reader.EndOfStream)
                    {
                        currLine = reader.ReadLine();

                        input.Add(currLine);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The name of the input file can't be left blank!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(String.Format("No such file exist in this directory. Please check file name({0}).",
                    Program.SOURCE_PATH));
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(String.Format("Please check the path of the file again! A directory does not exists in the given path!({0})",
                    Program.SOURCE_PATH));
            }
            catch (IOException)
            {
                Console.WriteLine("A critical error has appeared. Try again please!");
            }
        }

        public static void ReadWordsForDelete(List<string> input, List<string> wordsForDelete)
        {
            StreamReader reader = new StreamReader(Program.LIST_OF_WORDS_TO_DELETE_PATH);
            try
            {
                using (reader)
                {
                    string currWord = null;

                    while (!reader.EndOfStream)
                    {
                        currWord = reader.ReadLine();

                        wordsForDelete.Add(currWord);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The name of the input file can't be left blank!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(String.Format("No such file exist in this directory. Please check file name({0}).",
                    Program.LIST_OF_WORDS_TO_DELETE_PATH));
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(String.Format("Please check the path of the file again! A directory does not exists in the given path!({0})",
                    Program.LIST_OF_WORDS_TO_DELETE_PATH));
            }
            catch (IOException)
            {
                Console.WriteLine("A critical error has appeared. Try again please!");
            }
        }

        public static void DeleteWords(List<string> input, List<string> wordsForDelete, List<string> result)
        {
            const string EMPTY_STRING = "";
            StringBuilder tempResult = null;


            foreach (var line in input)
            {
                string currResult = null;
                tempResult = new StringBuilder();
                tempResult.AppendLine(line);

                foreach (var wordForDelete in wordsForDelete)
                {
                    if (line.Contains(wordForDelete))
                    {
                        currResult = tempResult.ToString().Replace(wordForDelete, EMPTY_STRING);
                        tempResult.Clear();
                    }
                    if (currResult != null)
                    {
                        tempResult.AppendLine(currResult.ToString());
                    }
                }
                if (currResult != null)
                {
                    result.Add(currResult);
                }
            }
        }

        public static void WriteResultToFile(List<string> result)
        {
            StreamWriter writer = new StreamWriter(Program.RESULT_PATH);

            try
            {
                using (writer)
                {
                    foreach (var line in result)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The account you are using is not permited for this operation!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The name of the file can't be left blank!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(String.Format("Please check the path again. A directory you tring to open does not exist({0})!", Program.RESULT_PATH));
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The number of charachters describing the path is longer than the system you're operating allows!");
            }
        }

        static void Main(string[] args)
        {

            List<string> input = new List<string>();
            Program.ReadInput(input);

            List<string> wordsForDelete = new List<string>();
            Program.ReadWordsForDelete(input, wordsForDelete);

            List<string> result = new List<string>();
            Program.DeleteWords(input, wordsForDelete, result);

            Program.WriteResultToFile(result);

        }
    }
}
