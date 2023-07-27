using System;
using System.Text;

/*
Question is as follows:

You are given two strings word1 and word2.
Merge the strings by adding letters in alternating order, starting with word1.
If a string is longer than the other, append the additional letters onto the end of the merged string.

Return the merged string.
*/

namespace LeetCode_Solutions
{
    class Q1768
    {
        private static void Main()
        {
            string word1 = "acegikmo";
            string word2 = "bdfhjlnp";
            Console.WriteLine(MergeAlternately(word1, word2));
            Console.ReadLine();
        }
        private static string MergeAlternately(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int max = Math.Max(word1.Length, word2.Length);     //Taking the max amount of characters between two strings
            for (int i = 0; i < max; i++)
            {
                if (i < word1.Length && i < word2.Length)
                {
                    sb.Append(word1[i]);
                    sb.Append(word2[i]);
                    //if both have the at least "i" characters, take those and put them together in StringBuilder
                }
                else if (i < word1.Length)
                {
                    sb.Append(word1[i]);
                    //If only word1 has i'th character, take the character and put that into StringBuilder
                }
                else if (i < word2.Length)
                {
                    sb.Append(word2[i]);
                    //If only word2 has i'th character, take the character and put that into StringBuilder
                }
            }
            string str = sb.ToString();
            return str;
        }
    }
}
