namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        /// <summary>
        ///  Represent 'string' as hexadecimal value of his bytes by the MD5 Message-Digest Algorithm.
        ///     Commonly used as hash generator of a high security level. 
        /// </summary>
        /// <param name="input">String value to be hashed.</param>
        /// <returns>Hexadecimal value as string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new StringBuilder to collect the bytes
            // and create a string.
            var builder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return builder.ToString();
        }

        /// <summary>
        /// Deteminate does a string value contains a logically positive value.
        ///     Logically positive values are {true, ok, yes, 1, да} - not CaseSensitive;
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>Bool value.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }
       
        /// <summary>
        /// To short.
        /// Convert string into 16-bit signed integer value.
        ///     If this operation failed the output will be ignored.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>16-bit signed integer value.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// To integer.
        /// Convert string into 32-bit signed integer value.
        ///     If this operation failed the output will be ignored.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>32-bit signed integer value.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// To long.
        /// Convert string into 64-bit signed integer value.
        ///     If this operation failed the output will be ignored.
        /// </summary>
        /// <param name="input">String input.</param>
        /// <returns>64-bit signed integer value.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Convert string into a DateTime value.
        ///     If this operation failed the output will be ignored.
        /// </summary>
        /// <param name="input">String value in format described by the Local Region settings of the machine or additionaly specified in the application.</param>
        /// <returns>DateTime value.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Makes the first letter of a non empty string capitalized.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>String value.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Extract string between two substrings in a string.
        /// </summary>
        /// <param name="input">String value to extract from.</param>
        /// <param name="startString">String value to start extracting from its position if exixst such without including it.</param>
        /// <param name="endString">String value to end the extraction to its position without including it.</param>
        /// <param name="startFrom">Indicate from wich index of the <see cref="input"/> the <see cref="startString"/> and the <see cref="endString"/> will be searched.</param>
        /// <returns>String value.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;

            // No substring exist if we don't have where to start or to end extracting.
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            // No substing exist if the start position exclude our start string last symbol.
            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            // No substring exist if our end string is allocated somewhere befoure the start string.
            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert every cyrillic symbol from a string into its latin representation.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>String value consisting only latin letters.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert every latin symbol from a string to its cyrillic representation.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>String value consisting only cyrillic letters.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Validate username as a string to specific pattern.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>Validated string value.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }
        
        /// <summary>
        /// Validate file name as a string to specific pattern.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>Validated sting value.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Extract specific number of symbols by starting from the beginning.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <param name="charsCount">Number of symbols to be extract.</param>
        /// <returns>String value.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Extract the file exntesion from a file name.
        /// </summary>
        /// <param name="fileName">String representation of file name.</param>
        /// <returns>String value.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            //Simple check if any extension exist.
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Gives more information of an a extension.
        /// </summary>
        /// <param name="fileExtension">Windows standart exnetion of a file.</param>
        /// <returns>String value.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Copies 8-bit values from source array to destination array.
        /// </summary>
        /// <param name="input">String value.</param>
        /// <returns>Array of 8-bit values.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
