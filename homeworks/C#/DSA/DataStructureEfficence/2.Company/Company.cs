using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace _2.Company
{
    public class Company
    {
        public OrderedMultiDictionary<int, Article> Articles { get; private set; }

        public Company()
        {
            this.Articles = new OrderedMultiDictionary<int, Article>(false);
        }

        public void AddArticle(Article article)
        {
            this.Articles.Add(article.Price, article);
        }
    }
}
