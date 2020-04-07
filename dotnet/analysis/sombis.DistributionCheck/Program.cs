using System;
using System.Collections.Generic;
using sombis.Core;

namespace sombis.DistributionCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            const int iterations = 1000000;
            var results = new Dictionary<int, Dictionary<char, int>>();
            
            for (var i = 1; i <= iterations; i++)
            {
                var mbi = generator.CreateRandomMbi();
                var chars = mbi.ToCharArray();

                for (var ci = 0; ci < chars.Length; ci++)
                {
                    UpdateResults(results, ci, chars[ci]);
                }
            }
        }

        private static void UpdateResults(
            Dictionary<int, Dictionary<char, int>> results, 
            int ci, 
            char c
            )
        {
            if (!results.ContainsKey(ci))
                results.Add(ci, new Dictionary<char, int>());

            var inner = results[ci];
            
            if (!inner.ContainsKey(c))
                inner.Add(c, 0);

            inner[c] = inner[c] + 1;
        }
    }
}
