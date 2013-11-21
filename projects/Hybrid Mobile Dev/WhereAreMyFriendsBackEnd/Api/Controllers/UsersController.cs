using Api.Helper;
using Api.ModelConverter;
using Api.Models;
using Api.Validator;
using Contexts;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class UsersController : ApiController
    {
        DbContext context;
        EFRepository repo;

        public UsersController()
        {
            this.context = new ApiContext();
            this.repo = new EFRepository(this.context);
        }

        [ActionName("register")]
        public HttpResponseMessage PostRegisterUser(RegisterUser userToRegister)
        {
            // user validation
            ApiValidator.ValidateName(userToRegister.FirstName, userToRegister.LastName);
            ApiValidator.ValidateUsername(userToRegister.Username);
            ApiValidator.ValidatePassword(userToRegister.CryptPass);
            ApiValidator.ValidatePhonenNumber(userToRegister.PhoneNumber);

            User dbUser = ApiToDbModelConverter.Convert(userToRegister);
            this.repo.RegisterUser(dbUser, userToRegister.Contacts);

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }
        [ActionName("login")]
        public HttpResponseMessage PutLoginUser(LoginUser userToLogin)
        {
            // validate username passowrd combination for existense
            User dbUser = ApiValidator.ValidateLogin(userToLogin.Username, userToLogin.CryptPass);
            string sessionKey = SessionKeyGenerator.GetSessionKey(dbUser.Username);
            dbUser.SessionKey = sessionKey;

            this.repo.LoginUser(dbUser.Username, dbUser.SessionKey);

            return this.Request.CreateResponse(HttpStatusCode.OK, sessionKey);
        }
        [ActionName("logout")]
        public HttpResponseMessage PutLogoutUser(string sessionKey)
        {
            // some validation needed

            this.repo.LogoutUser(sessionKey);

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }
        [ActionName("getFriends")]
        public HttpResponseMessage GetFriends(string sessionKey)
        {
            var dbFriends = this.repo.GetAllUsersWhoSharedLocation(sessionKey);
            var friends = ApiToDbModelConverter.Convert(dbFriends);

            return this.Request.CreateResponse(HttpStatusCode.OK, friends);
        }
        [ActionName("updateLoc")]
        public HttpResponseMessage UpdateLocation(string sessionKey, FriendLocation location)
        {
            var dbLocation = ApiToDbModelConverter.Convert(location);

            this.repo.UpdateLocation(sessionKey, dbLocation);

            return this.Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
