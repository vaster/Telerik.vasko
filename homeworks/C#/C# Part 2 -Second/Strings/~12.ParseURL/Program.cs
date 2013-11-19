using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{

    /*
     Write a program that parses an URL address given in the format:

    and extracts from it the [protocol], [server] and [resource] elements.
    For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
     * 
    [protocol] = "http"
    [server] = "www.devbg.org"
    [resource] = "/forum/index.php"

     */

    internal class Program
    {
        public const char PROTOCOL_DELIMITER = ':';

        public const char SERVER_SOURCE_DELIMITER = '/';

        public static StringBuilder ExtractInformationFromUrl(string url)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder protocol = new StringBuilder();
            StringBuilder server = new StringBuilder();
            StringBuilder resource = new StringBuilder();


            int endIndexOfProtocol = url.IndexOf(Program.PROTOCOL_DELIMITER);

            for (int i = 0; i < endIndexOfProtocol; i++)
            {
                protocol.Append(url[i]);
            }

            int countOfSlashes = 0;

            int endIndexOfServer = url.IndexOf(Program.SERVER_SOURCE_DELIMITER, endIndexOfProtocol + 3);

            for (int i = endIndexOfProtocol + 3; i < endIndexOfServer; i++)
            {
                server.Append(url[i]);
            }

            for (int i = endIndexOfServer; i < url.Length; i++)
            {
                resource.Append(url[i]);
            }



            result.AppendLine("[protocol] = " + protocol);
            result.AppendLine("[server] = " + server);
            result.AppendLine("[resource] = " + resource);

            return result;
        }

        static void Main(string[] args)
        {
            string url = "http://www.devbg.org/forum/index.php";

            StringBuilder result = Program.ExtractInformationFromUrl(url);

            Console.WriteLine(result);
        }
    }
}
