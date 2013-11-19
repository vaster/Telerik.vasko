using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.BiDict
{

    /*
     Implement a class BiDictionary<K1,K2,T> that allows adding triples {key1, key2, value} 
     * and fast search by key1, key2 or by both key1 and key2.
     Note: multiple values can be stored for given key.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            IBiDictionary<string, string, string> tracks =
                new BiDictionary<string, string, string>();

            string cSharp = "C#";
            string javaScript = "JavaScript";
            string failIndicator = "Not passed";
            string successIndicator = "Passed";

            string studentName = "Colin Farrel";
            tracks.Add(cSharp, successIndicator, studentName);
            tracks.Add(javaScript, successIndicator, studentName);

            studentName = "Noomi Rapace";
            tracks.Add(cSharp, successIndicator, studentName);
            tracks.Add(javaScript, successIndicator, studentName);

            studentName = "Terrence Howard";
            tracks.Add(cSharp, failIndicator, studentName);
            tracks.Add(javaScript, failIndicator, studentName);

            studentName = "Morgan Freeman";
            tracks.Add(cSharp,successIndicator,studentName);

            studentName = "Michelle Williams";
            tracks.Add(cSharp,failIndicator,studentName);

            Console.WriteLine("All students (C#):");
            ICollection<string> allStudnetsCsharp = tracks[cSharp];
            foreach (string item in allStudnetsCsharp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("All Failed C#:");
            ICollection<string> failedStudnetsCsharp = tracks[cSharp,failIndicator];
            foreach (string item in failedStudnetsCsharp)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Passed JS:");

            ICollection<string> passedStudnetsJS = tracks[javaScript, successIndicator];
            foreach (string item in passedStudnetsJS)
            {
                Console.WriteLine(item);
            }

        }
    }
}
