using System;
using System.Collections.Generic;
using System.Net;

class DownloadAndStore
{
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

