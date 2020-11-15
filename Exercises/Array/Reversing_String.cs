using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises
{
    public class Reversing_String
    {
        public string reverseString(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }

        public string reverseStringFaster(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}