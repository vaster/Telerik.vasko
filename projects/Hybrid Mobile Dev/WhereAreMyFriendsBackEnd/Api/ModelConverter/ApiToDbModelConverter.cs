using Api.Models;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.ModelConverter
{
    public static class ApiToDbModelConverter
    {
        static ApiToDbModelConverter()
        {
        }

        public static User Convert(RegisterUser user)
        {
            User dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName = user.LastName;
            dbUser.PhoneNumber = user.PhoneNumber;
            dbUser.Password = user.CryptPass;
            dbUser.Username = user.Username;

            return dbUser;
        }

        public static Location Convert(FriendLocation location)
        {
            var dbLocation = new Location();
            dbLocation.Description = location.Description;
            dbLocation.Lathitude = location.Lathitude;
            dbLocation.Longitude = location.Longitude;
            string[] timeComponents = location.Time.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            dbLocation.DateAdded = new DateTime(int.Parse(location.Year),
                int.Parse(location.Month),
                int.Parse(location.Day),
                int.Parse(timeComponents[0]),
                int.Parse(timeComponents[1]),
                0);

            return dbLocation;
        }

        public static FriendLocation Convert(Location location)
        {
            var apiLocation = new FriendLocation();
            apiLocation.Description = location.Description;
            apiLocation.Lathitude = location.Lathitude;
            apiLocation.Longitude = location.Longitude;
            apiLocation.Year = location.DateAdded.Value.Year.ToString();
            apiLocation.Month = location.DateAdded.Value.Month.ToString();
            apiLocation.Day = location.DateAdded.Value.Day.ToString();
            apiLocation.Time = location.DateAdded.Value.Hour.ToString() + ":" + location.DateAdded.Value.Minute.ToString();

            return apiLocation;
        }

        public static IEnumerable<Friend> Convert(IEnumerable<User> dbUsers)
        {
            ICollection<Friend> friends = new HashSet<Friend>();
            foreach (var dbUser in dbUsers)
            {
                if (!string.IsNullOrEmpty(dbUser.SessionKey) && dbUser.Location != null)
                {
                    var currFriend = new Friend();
                    currFriend.FirstName = dbUser.FirstName;
                    currFriend.LastName = dbUser.LastName;

                    currFriend.Location = ApiToDbModelConverter.Convert(dbUser.Location);

                    friends.Add(currFriend);
                }
            }

            return friends;
        }
    }
}