/*
 * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
 * a plindrome string is a word, phrase, or sequence that reads the same backwards as forwards, e.g. A man, a plan, a canal: Panama
 * Note: For the purpose of this problem, we define empty string as valid palindrome.
 
 *  Example 1:
 *  Input: "A man, a plan, a canal: Panama"
 *  Output: true
 
 *  Example 2:
 *  Input: "race a car"
 *  Output: false
 *  
 *    ----------------------------------------------------------------------------------------------------
 *    Solution Complexity:
 *      Time  Complexity:  O(n)
 *      Space Complexity:  O(1)
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyAlgoritms
{
    public static class ValidPalindrome
    {
        public static bool Run(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return true;
            }
            int sLen = input.Length;
            int left = 0;
            int right = sLen - 1;
            while (left < sLen && right > -1)
            {
                while (left < sLen && !char.IsDigit(input[left]) && !char.IsLetter(input[left]))
                {
                    left++;
                }
                while (right > -1 && !char.IsDigit(input[right]) && !char.IsLetter(input[right]))
                {
                    right--;
                }
                if (right > -1 && left < sLen)
                {
                    if (char.ToLower(input[right]) != char.ToLower(input[left]))
                    {
                        return false;
                    }
                    right--;
                    left++;
                }
                else
                {
                    return true;

                }

            }
            return true;
        }
    }
}
