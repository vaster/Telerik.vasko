using System;
using System.Collections.Generic;
using System.IO;

class FullFilePath
{
    static void Main(string[] args)
    {
        string path = null;
        string line = null;

        Console.Write("Enter path:");
        path = Console.ReadLine();

        try
        {
            line = File.ReadAllText(path);
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("You have not entered any path for file.");
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("The file you are trying to open does not exist, or you have not specified the file extension.");
        }
        catch (System.IO.DirectoryNotFoundException)
        {
            Console.WriteLine("There is no such path(directory) on this machine");
        }
        catch (System.IO.PathTooLongException)
        {
            Console.WriteLine("Entered path too long for the standards operating on this system.");
        }
        catch (System.NotSupportedException)
        {
            Console.WriteLine("The path it is in invalid format. You probably entered symbols that typicaly are not used for describing a file path.");
        }

        Console.WriteLine(line);
    }
}

