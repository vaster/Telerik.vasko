using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using MusicDB.Model;
using System.Collections;
using ASPNET_HW.Models;
using AspNetWebApi.Models;

namespace ASPNET_HW.Controllers
{
    public class MusicController : ApiController
    {
        private IList<ASPNET_HW.Models.Artist> data = new List<ASPNET_HW.Models.Artist>();

        // GET api/music
        public IEnumerable Get()
        {
            using (var db = new MusicDBEntities())
           {
               foreach (var art in db.Artists)
               {
                   data.Add(new ASPNET_HW.Models.Artist()
                   {
                       Name = art.ArtistName,
                       Country = art.Country,
                       DateOfBirth = art.DateOfBirth
                   });
               }

               return data;
           }

        }

        // GET api/music/5
        public ASPNET_HW.Models.Artist Get(int id)
        {
            using (var db = new MusicDBEntities())
            {
                foreach (var art in db.Artists)
                {
                    data.Add(new ASPNET_HW.Models.Artist()
                    {
                        Name = art.ArtistName,
                        Country = art.Country,
                        DateOfBirth = art.DateOfBirth
                    });
                }

                return data[id];
            }

        }

        // POST api/music
        public HttpResponseMessage Post([FromBody]PostModel value)
        {
            var post = value.CreatePost();
            this.data.Add(post); 
            
            var message = this.Request.CreateResponse(HttpStatusCode.Created);
            message.Headers.Location = new Uri(this.Request.RequestUri + post.Name.ToString());
            return message;
        }

        // PUT api/music/5
        public void Put(int id, [FromBody]ASPNET_HW.Models.Artist value)
        {
            using (var db = new MusicDBEntities())
            {
                foreach (var art in db.Artists)
                {
                    data.Add(new ASPNET_HW.Models.Artist()
                    {
                        Name = art.ArtistName,
                        Country = art.Country,
                        DateOfBirth = art.DateOfBirth
                    });
                }

                data[id] = value;
            }
        }

        // DELETE api/music/5
        public void Delete(int id)
        {
            using (var db = new MusicDBEntities())
            {
                foreach (var artist in db.Artists)
                {
                    if (artist.Id == id)
                    {
                        db.Artists.Remove(artist);
                    }
                }
            }
        }
    }
}
