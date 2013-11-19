using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _3.ReadFromFile
{
    /*
     Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
     * reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…).
     Be sure to catch all possible exceptions and print user-friendly error messages.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\WINDOWS\win.ini";

            string output = null;

            try
            {
                output = File.ReadAllText(path);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Not a valid path!");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Path length must be lower than 260 symbols!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("No such directory on this machine!");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The main, or some of the sub directories can't be accessed due to " +
               "your acount rights on the machine");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file your tring to open does not exist in this directory!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The path is in an invalid format!");
            }
            catch(SecurityException)
            {
                Console.WriteLine("You don't have the rights for this operation!");
            }
        }
    }
}
