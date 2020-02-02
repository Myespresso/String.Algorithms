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
using System.Collections.Generic;
using System.Text;

namespace EasyAlgoritms
{
    public static class Reverse_Words_in_a_String_III
    {
        public static string Run(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }
            Stack<char> stack = new Stack<char>();
            StringBuilder strb = new StringBuilder(input.Length);
            const char White_SPACE = ' ';
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != White_SPACE)
                {
                    stack.Push(input[i]);
                }
                else
                {
                    while (stack.Count > 0)
                    {
                        strb.Append(stack.Pop());
                    }
                    strb.Append(White_SPACE);
                }
            }
            while (stack.Count > 0)
            {
                strb.Append(stack.Pop());
            }
            return strb.ToString();
        }

    }
}
