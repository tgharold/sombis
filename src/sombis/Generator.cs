using System;
using System.Collections.Generic;
using System.Text;

namespace sombis
{
    public class Generator
    {
        private static readonly Random _random = new Random();
        
        public Generator()
        {
            var charsAN = new List<char>();
            charsAN.AddRange(CharsA);
            charsAN.AddRange(CharsN);
            CharsAN = charsAN.ToArray();
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
        private readonly char[] CharsAN; // not static because it gets built in the constructor
        
        public string CreateRandomMbi()
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