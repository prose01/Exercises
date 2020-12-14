using System;
using System.Collections.Generic;

namespace Exercises
{
    public class RomanToInteger
    {
        // https://leetcode.com/problems/roman-to-integer/

        // Convert integer numerals to Roman equivalents.
        public string IntegerToRomanConverter(int input)
        {
            // This method does not handle values over 3000.
            if (input >= 3000 || input < 1)
            {
                throw new ArgumentOutOfRangeException("Input skal være mellem 1 og 3000.", new Exception());
            }

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string result = "";

            // Add thousands.
            int num;
            num = input / 1000;
            result += thousands[num];
            input %= 1000;

            // Add hundreds.
            num = input / 100;
            result += hundreds[num];
            input %= 100;

            // Add tens.
            num = input / 10;
            result += tens[num];
            input %= 10;

            // Add ones.
            result += ones[input];

            return result;
        }

        // Convert Roman numerals to integer equivalent.
        public int RomanToIntegerConverter(string roman)
        {
            if (roman.Length == 0) return 0;

            Dictionary<char, int> values = new Dictionary<char, int>
            {
                { ' ', 0 },
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            int result = 0;
            int current_value = 0;
            int previous_value = 0;
            int third_value = 0;
            int consecutiveCount = 0;

            roman = roman.ToUpper();

            for (int i = roman.Length - 1; i >= 0; i--)
            {
                current_value = values[roman[i]];

                // Check for invalid Roman numerals
                consecutiveCount = (current_value == previous_value) ? consecutiveCount + 1 : 1;
                if (consecutiveCount > 3 && current_value != 1000)
                    throw new ArgumentOutOfRangeException("Der må højst stå tre ens romertal efter hinanden.", new Exception());

                int subtractionnumber = (previous_value.ToString()[0] == '1') ? (previous_value / 10) : (previous_value / 5);
                if (subtractionnumber > 0 && current_value > 0 && current_value != subtractionnumber && current_value < previous_value)
                    throw new ArgumentOutOfRangeException("Kun I, X og C kan stå foran et større romertal.", new Exception());

                if (current_value == previous_value && current_value < third_value)
                    throw new ArgumentOutOfRangeException("Der må kun stå ét mindre romertal foran et større romertal.", new Exception());

                // Add or subtract values.
                if (current_value < previous_value)
                {
                    result -= current_value;
                    third_value = previous_value;
                    previous_value = current_value;
                }
                else
                {
                    result += current_value;
                    third_value = previous_value;
                    previous_value = current_value;
                }
            }

            // Return the result.
            return result;
        }
    }
}
