using System;

namespace Exercises
{
    public class Reversing_String
    {
        public string ReverseString(string str)
        {
            string result = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }

        public string ReverseStringFaster(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        // GitHub version
        public string ReverseStringRecursively(string str)
        {
            if (str.Length == 0)
            {
                return string.Empty;
            }
            return ReverseStringRecursively(str.Substring(1)) + str[0];
        }
    }
}