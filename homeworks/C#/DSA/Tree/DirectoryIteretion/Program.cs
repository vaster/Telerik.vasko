using System;

namespace DirectoryIteretion
{
    /*
     Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe. 
     Use the class System.IO.Directory.
     */

    public class Program
    {
        static void Main(string[] args)
        {
            Interator directoryInterator = new Interator();

            directoryInterator.InterateDirectory();
        }
    }
}
