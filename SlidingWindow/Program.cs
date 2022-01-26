using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DistinctCharacters("cbbebi", 3));
          

        }
        public static int DistinctCharacters(string s, int k)
        {
            string windowSum = string.Empty;
            int maxLength = int.MinValue;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < s.Length; windowEnd++)
            { 
                windowSum += s[windowEnd];
                var count = windowSum.Distinct().Count();
                if (count > k)
                {
                    windowStart++;
                    windowSum = s[windowStart].ToString();
                }
                if (windowSum.Length > maxLength)
                {
                        maxLength = windowSum.Length;
                }      
            }
            return maxLength;

        }
        
    }
}
