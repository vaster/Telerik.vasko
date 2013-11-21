using Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories
{
    public class EFRepository
    {
        private DbContext context;
        private DbSet<User> userEntity;
        private DbSet<Location> locationEntity;

        public EFRepository(DbContext context)
        {
            this.context = context;
            this.userEntity = this.context.Set<User>();
            this.locationEntity = this.context.Set<Location>();
        }


        public void RegisterUser(User userToRegister, ICollection<string> contacts)
        {
            using (this.context)
            {
                foreach (var contact in contacts)
                {
                    if (this.userEntity.Any(e => e.PhoneNumber == contact))
                    {
                        var currFriend = this.GetUserByPhoneNumber(contact);
                        // add friends to the new user
                        userToRegister.Friends.Add(currFriend);
                        // add the new user as a friend
                        currFriend.Friends.Add(userToRegister);
                    }
                }
                this.userEntity.Add(userToRegister);
                this.context.SaveChanges();
            }
        }

        public void LoginUser(string username, string sessionKey)
        {


            var dbUser = this.GetUserByUsername(username);
            dbUser.SessionKey = sessionKey;

            this.context.SaveChanges();

        }

        public void LogoutUser(string sessionKey)
        {
            var dbUser = this.GetUserBySessionKey(sessionKey);
            dbUser.SessionKey = null;
            dbUser.Location = null;
            dbUser.LocationId = null;
            this.context.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
            User dbUser = null;


            dbUser = (from currUser in this.userEntity
                      where currUser.Username == username
                      select currUser).FirstOrDefault();


            return dbUser;
        }

        public User GetUserBySessionKey(string sessionKey)
        {
            User dbUser = null;

            dbUser = (from currUser in this.userEntity
                      where currUser.SessionKey == sessionKey
                      select currUser).FirstOrDefault();


            return dbUser;
        }

        public IEnumerable<User> GetAllUsersWhoSharedLocation(string sessionKey)
        {
            User dbUser = null;
            ICollection<User> sharedLocationFriends = null;

            dbUser = this.GetUserBySessionKey(sessionKey);
            sharedLocationFriends = dbUser.Friends.ToList();

            return sharedLocationFriends;
        }

        public User GetUserByPhoneNumber(string phoneNumber)
        {
            User dbUser = null;

            {
                dbUser = (from currUser in this.userEntity
                          where currUser.PhoneNumber == phoneNumber
                          select currUser).FirstOrDefault();
            }

            return dbUser as User;
        }

        public void UpdateLocation(string sessionKey, Location location)
        {
            User dbUser = this.GetUserBySessionKey(sessionKey);
            var dbLocation = this.locationEntity.Add(location);

            this.context.SaveChanges();

            dbUser.LocationId = dbLocation.Id;

            this.context.SaveChanges();

        }


        // register new user
        // login new user
        // logout user
        // get user by username
        // get all users by contact list
        // update location for a user
    }
}
