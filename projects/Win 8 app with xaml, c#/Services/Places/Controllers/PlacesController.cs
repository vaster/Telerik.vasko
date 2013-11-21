using Db.Context;
using Db.Models;
using Db.Repositoy;
using Newtonsoft.Json;
using Places.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Places.Controllers
{
    public class PlacesController : ApiController
    {
        private EFRepo<Place> repo;
        private EFRepo<ImageUrl> imageRepo;
        private PlaceDbB2 context;
        private PlaceDbB2 imageContex;

        public PlacesController()
        {
            // try
            this.context = new PlaceDbB2();
            this.imageContex = new PlaceDbB2();
            this.repo = new EFRepo<Place>(this.context);
            this.imageRepo = new EFRepo<ImageUrl>(this.imageContex);
        }

        [ActionName("welcome")]
        public HttpResponseMessage GetWelcomePlaces()
        {
            ICollection<WelcomePlace> result = new HashSet<WelcomePlace>();
            WelcomePlace curr = null;

            foreach (var item in this.repo.GetAll())
            {
                curr = new WelcomePlace();
                curr.Title = item.Title;
                curr.Category = item.Category;
                curr.Continent = item.Continent;

                var imagesForThisPhenomena =
                    (from currImage in this.imageRepo.GetAll()
                     where currImage.Place.Title == curr.Title
                     select currImage.Url).FirstOrDefault();

                curr.ImageUrl = imagesForThisPhenomena;
                result.Add(curr);
            }
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }

        [ActionName("short")]
        public HttpResponseMessage GetShortDescriptionPlaces(string title)
        {
            ShortDescription curr = null;

            var item = (from currDb in this.repo.GetAll()
                        where currDb.Title == title
                        select currDb).First();

            curr = new ShortDescription();
            curr.Title = item.Title;
            curr.Continent = item.Continent;
            curr.Category = item.Category;
            curr.ShortDescriptions = item.ShortDescription;

            var imagesForThisPhenomena =
                (from currImage in this.imageRepo.GetAll()
                 where currImage.Place.Title == curr.Title
                 select currImage.Url);

            curr.ImageUrl = imagesForThisPhenomena.ToList();

            return this.Request.CreateResponse(HttpStatusCode.OK, curr);
        }

        [ActionName("full")]
        public HttpResponseMessage GetFullDescriptionForAPlace(string title)
        {
            var description = (from curr in this.repo.GetAll()
                               where curr.Title == title
                               select curr.LongDescription).FirstOrDefault();

           //
           // List<string[]> descriptionPartsWithPaging = new List<string[]>();
           // string[] descriptionsParts = description.Split('^');
           //
           //
           // for (int i = 0; i < descriptionsParts.Length; i++)
           // {
           //     string[] currPaging = new string[2];
           //     if (descriptionsParts[i].Length >= 2000)
           //     {
           //         int pagingStartIndex = descriptionsParts[i].IndexOf(" ", 2000);
           //         currPaging[0] = descriptionsParts[i].Substring(0, pagingStartIndex);
           //         currPaging[1] = descriptionsParts[i].Substring(pagingStartIndex + 1);
           //     }
           //     else
           //     {
           //         currPaging = new string[1];
           //         currPaging[0] = descriptionsParts[i];
           //     }
           //
           //     descriptionPartsWithPaging.Add(currPaging);
           // }

            return this.Request.CreateResponse(HttpStatusCode.OK, description);
        }

        [ActionName("bycontinent")]
        public HttpResponseMessage GetAssocietesByContinent(string continent)
        {
            ICollection<WelcomePlace> result = new HashSet<WelcomePlace>();
            WelcomePlace curr = null;

            foreach (var item in this.repo.GetAll())
            {
                if (item.Continent == continent)
                {
                    curr = new WelcomePlace();
                    curr.Title = item.Title;
                    curr.Category = item.Category;
                    curr.Continent = item.Continent;

                    var imagesForThisPhenomena =
                        (from currImage in this.imageRepo.GetAll()
                         where currImage.Place.Title == curr.Title
                         select currImage.Url).FirstOrDefault();

                    curr.ImageUrl = imagesForThisPhenomena;
                    result.Add(curr);
                }
            }
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }


        [ActionName("bycategory")]
        public HttpResponseMessage GetAssocietesByCategory(string category)
        {
            ICollection<WelcomePlace> result = new HashSet<WelcomePlace>();
            WelcomePlace curr = null;


            foreach (var item in this.repo.GetAll())
            {
                if (item.Category == category)
                {
                    curr = new WelcomePlace();
                    curr.Title = item.Title;
                    curr.Category = item.Category;
                    curr.Continent = item.Continent;

                    var imagesForThisPhenomena =
                        (from currImage in this.imageRepo.GetAll()
                         where currImage.Place.Title == curr.Title
                         select currImage.Url).FirstOrDefault();

                    curr.ImageUrl = imagesForThisPhenomena;
                    result.Add(curr);
                }
            }
            return this.Request.CreateResponse(HttpStatusCode.OK, result);
        }
    }
}
