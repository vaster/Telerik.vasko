namespace AspNetWebApi.Models
{
    using System;
    using System.Linq.Expressions;

    using ASPNET_HW.Models;

    public class PostModel
    {
        public static Expression<Func<Artist, PostModel>> FromPost
        {
            get
            {
                return x => new PostModel { Country = x.Country, Name = x.Name, DateOfBirth = x.DateOfBirth, };
            }
        }


        public string Country { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Artist CreatePost()
        {
            return new Artist { Name = this.Name, DateOfBirth = this.DateOfBirth, Country = this.Country };
        }

        //public void UpdatePost(Artist post)
        //{
        //    if (this.Title != null)
        //    {
        //        post.Title = this.Title;
        //    }

        //    if (this.Content != null)
        //    {
        //        post.Content = this.Content;
        //    }
        //}
    }
}