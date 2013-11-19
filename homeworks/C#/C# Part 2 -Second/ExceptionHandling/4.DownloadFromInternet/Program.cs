using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _4.DownloadFromInternet
{
    public class Program
    {
        /*
         Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory.
         Find in Google how to download files in C#. 
         Be sure to catch all exceptions and to free any used resources in the finally block.

         */

        static void Main(string[] args)
        {
            WebClient Client = new WebClient();
            try
            {
                Client.DownloadFile("http://blogs.learnnowonline.com/Portals/153597/images/csharp.png", @"C:\text\CSharp.png");
                Console.WriteLine("Succses");
            }
            catch (WebException)
            {
                Console.WriteLine("The file does not exist(another pusibility probably empty file), or there has been error while dowloading the file. Try again later.");
                Console.WriteLine("If this was not usefull check your download URL and destination path.");
            }
            finally
            {
                Client.Dispose();
            }
        }
    }
}
