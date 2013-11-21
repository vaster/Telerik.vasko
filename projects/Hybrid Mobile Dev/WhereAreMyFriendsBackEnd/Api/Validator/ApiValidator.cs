using Api.Models;
using Contexts;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api.Validator
{
    public static class ApiValidator
    {
        public const int USERNAME_MIN_LENGTH = 6;
        public const int USERNAME_MAX_LENGTH = 20;
        public const int PASSWORD_LENGHT = 40;
        public const string USERNAME_VALID_CHARACHTERS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789_.";
        public const string PHONE_NUMBER_VALID_CHARACTERS = "1234567890+";
        //public const string PASSWORD_VALID_CHARACHTERS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM123456789!@#$%^&*";

        public static void ValidateUsername(string username)
        {
            if (username == null || username.Length == 0)
            {
                throw new ArgumentNullException(String.Format("The username can't be blank!"));
            }
            if (username.Length < ApiValidator.USERNAME_MIN_LENGTH || username.Length > ApiValidator.USERNAME_MAX_LENGTH)
            {
                throw new ArgumentOutOfRangeException(String.Format("The username length must be {0} - {1} characters long",
                    ApiValidator.USERNAME_MIN_LENGTH, ApiValidator.USERNAME_MAX_LENGTH));
            }
            else
            {
                // invalid symbol check
                foreach (var characther in username)
                {
                    if (!(ApiValidator.USERNAME_VALID_CHARACHTERS.Contains(characther)))
                    {
                        throw new ArgumentException(String.Format("Ivalid username. Can contains only leters, digits and '_' or '.'"));
                    }
                }
            }
        }

        // if needed
        public static void ValidateName(string firstname, string lastname)
        {
            if (firstname == null || firstname.Length == 0)
            {
                throw new NullReferenceException(String.Format("Your first name can't be left blank!"));
            }
            if (lastname == null || lastname.Length == 0)
            {
                throw new NullReferenceException(String.Format("Your last name can't be left blank!"));
            }
        }

        public static void ValidatePassword(string password)
        {
            if (password == null || password.Length == 0)
            {
                throw new NullReferenceException(String.Format("Password can't be blank!"));
            }
            if (password.Length !=  ApiValidator.PASSWORD_LENGHT)
            {
                throw new ArgumentException(String.Format("Password is not crypted right!"));
            }
            //else
            //{
            //    foreach (var characther in password)
            //    {
            //        if (!(ApiValidator.PASSWORD_VALID_CHARACHTERS.Contains(characther)))
            //        {
            //            throw new ArgumentException(String.Format("Ivalid password. Can contains only leters, digits and special character!"));
            //        }
            //    }
            //}
        }

        public static void ValidatePhonenNumber(string phoneNumber)
        {
            if (phoneNumber == null || phoneNumber.Length == 0)
            {
                throw new NullReferenceException(String.Format("Password can't blank!"));
            }
            if ((phoneNumber.StartsWith("0") && phoneNumber.Length != 10) || phoneNumber.StartsWith("+") && phoneNumber.Length != 13)
            {
                throw new ArgumentException(String.Format("The phone number is not valid for Bulgaria!"));
            }
            foreach (var character in phoneNumber)
            {
                if (!ApiValidator.PHONE_NUMBER_VALID_CHARACTERS.Contains(character))
                {
                    throw new ArgumentException(String.Format("Invalid phone number! Only nubmers are allowed and '+'."));
                }
            }
        }

        public static User ValidateLogin(string username, string cryptPass)
        {
            DbContext context = new ApiContext();
            EFRepository repo = new EFRepository(context);

            User dbUser = repo.GetUserByUsername(username);
            if (dbUser == null || dbUser.Password != cryptPass)
            {
                throw new ArgumentException(String.Format("Invalid Username or Password!"));
            }

            return dbUser;
        }
    }
}