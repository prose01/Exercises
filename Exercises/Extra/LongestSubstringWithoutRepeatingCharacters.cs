using System;
using System.Collections.Generic;

namespace Exercises
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s) // My answer - Time 0(n) - Space 0(n)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            char[] items = s.ToCharArray(); // No need to do this as a string is an array s[0] == a.

            int max = 1;
            int temp = 1;
            Dictionary<char, bool> index = new Dictionary<char, bool>();

            index.Add(items[0], true);

            for (var i = 1; i < s.Length; i++)
            {
                if (!index.ContainsKey(items[i]))
                {
                    index.Add(items[i], true);
                    temp++;
                }
                else
                {
                    temp--;
                }

                max = Math.Max(max, temp);
            }

            return max;
        }

        public int LengthOfLongestSubstringWindow(string s) // Teachers answer - Time 0(n) - Space 0(n).
        {
            if (s == null || s == String.Empty)
                return 0;

            Dictionary<char, bool> index = new Dictionary<char, bool>();

            int currentMax = 0;
            int leftWindow = 0;
            int rightWindow = 0;

            while (j < s.Length)
            {
                if (!index.ContainsKey(s[rightWindow]))
                {
                    index.Add(s[rightWindow++], true);
                    currentMax = Math.Max(currentMax, rightWindow - leftWindow);
                }
                else
                {
                    index.Remove(s[leftWindow++]);
                }
            }

            return currentMax;
        }
    }
}
