using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _2.Company
{

    /*
     * A large trade company has millions of articles, each described by barcode, vendor, title and price.
     * Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y].
     * Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET. 
    */

    public class Program
    {
        static void Main(string[] args)
        {

            Article microsoftArticle = new Article(30011,"Microsoft","And Now?",10);
            Article appleArticle = new Article(1001,"Apple","Going for all.",12);
            Article hpArticle = new Article(9122,"HP","Not good.",29);
            Article magazineArticle = new Article(2302,"Agenda","It's all good.",27);

            Company company = new Company();

            company.AddArticle(microsoftArticle);
            company.AddArticle(appleArticle);
            company.AddArticle(hpArticle);
            company.AddArticle(magazineArticle);

            int startPrince = 11;
            int endPrice = 28;

            OrderedMultiDictionary<int, Article>.View rangeOfArticles =  company.Articles.Range(startPrince,true,endPrice,true);

            foreach (KeyValuePair<int,ICollection<Article>> articles in rangeOfArticles)
            {
                Console.WriteLine(articles);
            }

        }
    }
}
