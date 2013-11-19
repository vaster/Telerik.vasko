using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReplaceTagsInHTML
{
    static void Main(string[] args)
    {
        string input ="<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string final;

        final = input.Replace("<a href","[URL");
        final = final.Replace("</a>", "[/URL]");
        final = final.Replace("\"",string.Empty);

        Console.WriteLine(final);
    }
}

