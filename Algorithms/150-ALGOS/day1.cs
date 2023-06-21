using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms._150_ALGOS
{
    internal class day1
    {
        //1. Write a C# Sharp program to compute the sum of the two numerical values.
        //If the two values are the same, return triple their sum.


        public static int SumOf( int x = 2, int y = 3) 
        {
            return x == y ? (x + y) * 3 : x + y;
        }


        //2. Write a C# Sharp program to get the absolute difference between n and 51. 
        //    If n is broader than 51 return triple the absolute difference

        public static int AbsolDiff(int n)
        {
             
            return n > 51 ? (n - 51)*3 : 51 - n; 
        }

        //3.Write a C# program to check two given integers,
        //and return true if one of them is 30 or if their sum is 30.

        public static bool Is30(int n,int m)
        {
            return (m == 30 || n == 30 || m + n == 30) ? true : false;
        }

        //4.Write a C# Sharp program to check a
        //given integer and return true if it is within 10 of 100 or 200.

        public static bool TenOf(int n)
        {
            return  (n >89 && n < 111) || (n > 189 && n < 211) ? true :false;
        }

        //5 Write a C# program to create a string where 'if' is added to the front
        // of a given string. If the string already begins with 'if', return it unchanged.
        public static string IfString(string s)
        {
            return  s.StartsWith("if") ? s : "if " + s;
        }


        //6. Write a C# Sharp program to remove the character at a given
        //position in the string. The given position will be in the range 0..(string length -1) inclusive

        public static string Remove(int m,string s)
        {
            return m >= 0 && m < s.Length ? s = s.Remove(m,1) : s;
        }

 

        public static string CapitaliseWords(string s)
        {
            return Regex.Replace(s, @"(\b\w)|(\b\W)", match => match.Value.ToUpper());
        }








}
}
