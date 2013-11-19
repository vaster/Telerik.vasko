using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CountOccurrences
{
    internal class Program
    {
        public const string WORDS_PATH = "words.txt";

        public const string TEST_PATH = "test.txt";

        public const string RESULT_PATH = "result.txt";

        public static void ReadWords(List<string> words)
        {
            try
            {
                StreamReader reader = new StreamReader(Program.WORDS_PATH);
                using (reader)
                {
                    string currWord = null;

                    while (!reader.EndOfStream)
                    {
                        currWord = reader.ReadLine();
                        words.Add(currWord);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The name of the file contaning the words can't be left blank!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(String.Format("There is no such file on this path. Please check the name again({0})!",
                    Program.WORDS_PATH));
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(String.Format("The path you have selected is not valid. A directory in the path does not exist({0})",
                    Program.WORDS_PATH));
            }
        }

        public static void ReadTest(List<string> test)
        {
            try
            {
                StreamReader reader = new StreamReader(Program.TEST_PATH);
                using (reader)
                {
                    string currWord = null;
                    while (!reader.EndOfStream)
                    {
                        currWord = reader.ReadLine();
                        test.Add(currWord);
                    }
                }
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The name of the test file name can't be left blank!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(String.Format("There is no such file on this path. Please check the name again({0})!",
                    Program.TEST_PATH));
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(String.Format("The path you have selected is not valid. A directory in the path does not exist({0})",
                    Program.TEST_PATH));
            }
        }

        public static Dictionary<string, int> CountOccurrences(List<string> words, List<string> test)
        {
            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            const int initializeValue = 1;

            foreach (var word in words)
            {
                foreach (var testWord in test)
                {
                    if (word == testWord)
                    {
                        if (wordsCount.ContainsKey(word))
                        {
                            wordsCount[word]++;
                        }
                        else
                        {
                            wordsCount.Add(word, initializeValue);
                        }
                    }
                }
            }

            return wordsCount;
        }

        public static SortedDictionary<int, string> OrderWordsByOccurrences(Dictionary<string, int> wordsCount)
        {
            SortedDictionary<int, string> result = new SortedDictionary<int, string>();

            foreach (var pair in wordsCount)
            {
                result.Add(pair.Value,pair.Key);
            }

            return result;
        }


        public static void WriteSortedWordsToFile(SortedDictionary<int,string> result)
        {
            try
            {
                StreamWriter writer = new StreamWriter(Program.RESULT_PATH);

                using (writer)
                {
                    foreach (var pair in result)
                    {
                        writer.WriteLine(pair.Value + " " + pair.Key);
                    }
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The name of the file for writing the result can'be left blank!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You're not permited to access this file!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine(String.Format("The path of the file for writing is not right. A directory does not exists({0})!",
                    Program.RESULT_PATH));
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The number of charachters describing the path is longer than the system you're operating allows!");
            }
        }

        static void Main(string[] args)
        {
            List<string> words = new List<string>();
            Program.ReadWords(words);

            List<string> test = new List<string>();
            Program.ReadTest(test);

            Dictionary<string, int> wordsCount = Program.CountOccurrences(words,test);
            SortedDictionary<int, string> result = Program.OrderWordsByOccurrences(wordsCount);

            Program.WriteSortedWordsToFile(result);
        }
    }
}
