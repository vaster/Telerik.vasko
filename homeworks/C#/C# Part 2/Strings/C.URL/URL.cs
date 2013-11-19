using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class URL
{
    static void Main(string[] args)
    {
        string url;
        StringBuilder protokol = new StringBuilder();
        StringBuilder server = new StringBuilder();
        StringBuilder resource = new StringBuilder();

        char reader;
        int indexer = 0;

        int indexOfProtokol=0;
        int indexOfServerStart=0;
        int indexOfResource=0;

        Console.Write("Enter URL (http://www.devbg.org/forum/index.php):");
        url = Console.ReadLine();

        indexOfProtokol = url.IndexOf(':');
        for (int i = 0; i < indexOfProtokol; i++)
        {
            reader = url[i];
            protokol.Append(reader);
           
        }
        //////////////////////////////////////
        indexOfServerStart = url.IndexOf('/');
        for (int i = indexOfServerStart+2; i < url.Length; i++)
        {
            reader = url[i];
            if (reader == '/')
            {
                indexer = i;
                break;
            }
            server.Append(reader);
        }
        ///////////////////////////////////
        for (int i = indexer; i < url.Length; i++)
        {
            reader = url[i];
            resource.Append(reader);
        }



        Console.WriteLine("Protokol: {0}",protokol.ToString());
        Console.WriteLine("Server: {0}", server.ToString());
        Console.WriteLine("Resource: {0}", resource.ToString());
    }
}

