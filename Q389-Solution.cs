﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode_Solutions
{
    class Q389
    {
        private static void Main()
        {
            string s = "abcdefgh";          //First string
            string t = "ahbcdfegi";         //Second string, which will include all the characters in the first string, and a random char
            char c = FindTheDifference(s, t);
            Console.WriteLine(c);
            Console.ReadKey();
        }
        private static char FindTheDifference(string s, string t)
        {
            List<char> tList = new List<char>();
            List<char> sList = new List<char>();
            tList.AddRange(t);
            sList.AddRange(s);
            tList.Sort();                   //Using List.Sort() consumes a lot of memory, will fix this later.
            sList.Sort();
            int i = tList.Count() - 1;
            for (int x = 0; x < i; x++)
            {
                if (tList[x] == sList[x]) continue;
                else i = x;
            }
            return tList[i];
        }

    }
}