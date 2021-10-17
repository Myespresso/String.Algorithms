/*
 * Question:
 *    Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
 * 
 *    Example 1:
 *    Input: "Let's take LeetCode contest"
 *    Output: "s'teL ekat edoCteeL tsetnoc"
 *    Note: In the string, each word is separated by single space and there will not be any extra space in the string.
 *    ----------------------------------------------------------------------------------------------------
 *    Solution Complexity:
 *      Time  Complexity:  O(n^2)
 *      Space Complexity: O(n)
*/
using System;

namespace EasyAlgoritms
{
    public static class Reverse_Words_in_a_String_III
    {
        {
            string reversedWord = "";
            string output = "";
            const char WHITE_SPACE = ' ';

            foreach (char character in input)
            {
                if (character == WHITE_SPACE)
                {
                    output += reversedWord + " ";
                    reversedWord = string.Empty;
                }
                else
                    reversedWord = character + reversedWord;
            }
            return output.Insert(output.Length, reversedWord);
        }
    }
}
