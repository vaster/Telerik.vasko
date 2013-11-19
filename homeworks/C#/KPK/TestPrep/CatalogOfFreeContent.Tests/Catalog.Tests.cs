using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Catalog
{
    [TestClass]
    public class CatalogTest
    {
        [TestMethod]
        public void Initialize()
        {
            ICatalog catalog = new Catalog();
        }

        [TestMethod]
        public void AddContent()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);

        }

        [TestMethod]
        public void AddDublicateContent()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);
            catalog.Add(content);
        }

        [TestMethod]
        public void GetOneContetWhenOneExists()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);

            IEnumerable<IContent> actual = catalog.GetListContent(parameters[0], 1);

            foreach (IContent currContent in actual)
            {
                Assert.AreEqual(currContent, content);
            }
        }

        [TestMethod]
        public void GetThreeContentWhenThreeExists()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);

            IEnumerable<IContent> actual = catalog.GetListContent(parameters[0], 3);

            foreach (IContent currContent in actual)
            {
                Assert.AreEqual(currContent, content);
            }
        }

        [TestMethod]
        public void GetNoneContentWhenNoExists()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);

            IEnumerable<IContent> actual = catalog.GetListContent("Anatomy", 3);

            foreach (IContent currContent in actual)
            {
                Assert.AreNotEqual(currContent, content);
            }
        }

        [TestMethod]
        public void Get30ContentsWhen3AreExpected()
        {
            int contentsCount = 0;

            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);

            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);

            IEnumerable<IContent> actual = catalog.GetListContent(parameters[0], 3);

            foreach (IContent currContent in actual)
            {
                Assert.AreEqual(currContent, content);
                contentsCount++;
            }

            Assert.AreEqual(3,contentsCount);
        }

        [TestMethod]
        public void Get3ContentsWhen10AreExpected()
        {
            int contentsCount = 0;

            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);

            catalog.Add(content);
            catalog.Add(content);
            catalog.Add(content);

            IEnumerable<IContent> actual = catalog.GetListContent(parameters[0], 10);

            foreach (IContent currContent in actual)
            {
                Assert.AreEqual(currContent, content);
                contentsCount++;
            }

            Assert.AreEqual(3, contentsCount);
        }

        [TestMethod]
        public void GetTwoDifferentContentsWhenExists()
        {

            ICatalog catalog = new Catalog();

            string[] firsParameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent firstContent = new Content(CatalogItem.Book, firsParameters);

            string[] secondParameters = new string[] { "Biology", "Mr.Cell", "3387", "www.xxxx.com" };
            IContent secondContent = new Content(CatalogItem.Movie, secondParameters);


            IEnumerable<IContent> contentOne = catalog.GetListContent(firsParameters[0], 1);
            IEnumerable<IContent> contentTwo = catalog.GetListContent(secondParameters[0], 1);

            foreach (IContent currContet in contentOne)
            {
                Assert.AreEqual(firstContent, currContet);
            }

            foreach (IContent currContet in contentTwo)
            {
                Assert.AreEqual(secondContent, currContet);
            }
        }

        [TestMethod]
        public void UpdateTwoUrls()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);
            catalog.Add(content);
            int actual = catalog.UpdateContent("http://www.introprogramming.info","www.xxxx.net");

            Assert.AreEqual(2,actual);
        }

        [TestMethod]
        public void NoneAreUpdated()
        {
            ICatalog catalog = new Catalog();
            string[] parameters = new string[] { "Intro C#", "S.Nakov", " 12763892", "http://www.introprogramming.info" };
            IContent content = new Content(CatalogItem.Book, parameters);
            catalog.Add(content);
            catalog.Add(content);
            int actual = catalog.UpdateContent("www.somethingelse.com", "www.xxxx.net");

            Assert.AreEqual(0, actual);
        }


    }
}
