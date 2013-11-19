using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SubStringExtMethod
{
    public static class StringBuilderExtension
    {
        public static StringBuilder SubString(this StringBuilder sb, int index, int length)
        {
            StringBuilder subStringed = new StringBuilder();

            if (index > sb.Length)
            {
                throw new IndexOutOfRangeException("No such index for starting index in StringBuilder.Substring(int index, int length)");
            }
            if (index < 0)
            {
                throw new IndexOutOfRangeException("No such index for starting index in StringBuilder.Substring(int index, int length)");
            }
            if (length > (sb.Length - index-1))
            {
                throw new IndexOutOfRangeException("Length of StringBuilder.Substring must be pursuant with the current object lenght and the starting index");
            }
           

            for (int i =index; i <= index + length; i++)
            {
                subStringed.Append(sb[i]);
            }

            return subStringed;
        }

    }
}
