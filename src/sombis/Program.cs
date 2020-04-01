using System;
using System.Collections.Generic;
using System.Text;

namespace sombis
{
    class Program
    {
        private static readonly Random _random = new Random();

        static void Main(string[] args)
        {
            var charsAN = new List<char>();
            charsAN.AddRange(CharsA);
            charsAN.AddRange(CharsN);
            CharsAN = charsAN.ToArray();
            
            const int iterations = 10;

            for (var i = 1; i <= iterations; i++)
            {
                var mbi = CreateRandomMbi();
                
                Console.WriteLine(mbi);
            }            
        }
        
        /// <summary>C – Numeric 1 thru 9</summary>
        private static readonly char[] CharsC = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        
        /// <summary>N – Numeric 1 thru 9</summary>
        private static readonly char[] CharsN = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        /// <summary>A – Alphabetic Character (A...Z); Excluding (S, L, O, I, B,  Z)</summary>
        private static readonly char[] CharsA = {
            'a', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'm',
            'n', 'p', 'q', 'r', 't', 'u', 'v', 'w', 'x', 'y'
            };

        /// <summary>AN – Alpha-Numeric (A list + N list)</summary>
        private static char[] CharsAN;
        
        private static string CreateRandomMbi()
        {
            // https://www.cms.gov/Medicare/New-Medicare-Card

            var sb = new StringBuilder();

            sb.Append(RandomElement(CharsC));
            sb.Append(RandomElement(CharsA));
            sb.Append(RandomElement(CharsAN));
            sb.Append(RandomElement(CharsN));
            sb.Append(RandomElement(CharsA));
            
            sb.Append(RandomElement(CharsAN));
            sb.Append(RandomElement(CharsN));
            sb.Append(RandomElement(CharsA));
            sb.Append(RandomElement(CharsA));
            sb.Append(RandomElement(CharsN));
            
            sb.Append(RandomElement(CharsN));

            return sb.ToString().ToUpperInvariant();
        }

        private static char RandomElement(char[] array)
        {
            return array[_random.Next(0, array.Length)];
        }
    }
}
