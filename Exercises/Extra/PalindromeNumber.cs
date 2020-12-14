using System.Collections.Generic;

namespace Exercises
{
    public class PalindromeNumber
    {
        // https://leetcode.com/problems/palindrome-number/
        // Determine whether an integer is a palindrome.An integer is a palindrome when it reads the same backward as forward.
        // Follow up: Could you solve it without converting the integer to a string?

        public bool IsPalindrome(int num) // My answer - Time 0(n) - Space 0(n) :( using ToString.
        {
            if (num < 0 )
            {
                return false;
            }

            char[] nums = num.ToString().ToCharArray();

            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                if(nums[left] != nums[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }

        public bool IsPalindromeX(int x) // Teachers answer - Time 0(n) - Space 0(1).
        {
            if (x < 0)
            {
                return false;
            }

            // Now let's think about how to revert the last half of the number. For number 1221, if we do 1221 % 10, we get the last digit 1, to get the second to the last digit, 
            // we need to remove the last digit from 1221, we could do so by dividing it by 10, 1221 / 10 = 122. 
            // Then we can get the last digit again by doing a modulus by 10, 122 % 10 = 2, and if we multiply the last digit by 10 and add the second last digit, 1 * 10 + 2 = 12, 
            // it gives us the reverted number we want. Continuing this process would give us the reverted number with more digits.
            // Now the question is, how do we know that we've reached the half of the number?
            // Since we divided the number by 10, and multiplied the reversed number by 10, when the original number is less than the reversed number, it means we've processed half of the number digits.

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = (revertedNumber * 10) + (x % 10);
                x /= 10;
            }

            // When the length is an odd number, we can get rid of the middle digit by revertedNumber/10
            // For example when the input is 12321, at the end of the while loop we get x = 12, revertedNumber = 123,
            // since the middle digit doesn't matter in palidrome(it will always equal to itself), we can simply get rid of it.
            return x == revertedNumber || x == revertedNumber / 10;
        }
    }
}
