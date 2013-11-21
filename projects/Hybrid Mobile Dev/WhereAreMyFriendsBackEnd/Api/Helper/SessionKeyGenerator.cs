using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Api.Helper
{
    public static class SessionKeyGenerator
    {
        public const string SESSIONKEY_CHARACTERS = "qwertyuiopasdfghjklzxcvbnm1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
        public const int SESSIONKEY_LENGTH = 50;
        public static Random rand;

        static SessionKeyGenerator()
        {
            SessionKeyGenerator.rand = new Random();
        }

        public static string GetSessionKey(string username)
        {
            StringBuilder sessionKeySymbols = new StringBuilder(SessionKeyGenerator.SESSIONKEY_CHARACTERS + username);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < SessionKeyGenerator.SESSIONKEY_LENGTH; i++)
            {
                int index = SessionKeyGenerator.rand.Next(0, sessionKeySymbols.Length - 1);
                result.Append(sessionKeySymbols[index]);
            }

            return result.ToString();
        }
    }
}