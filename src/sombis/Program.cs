using System;

namespace sombis
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();
            
            const int iterations = 10;

            for (var i = 1; i <= iterations; i++)
            {
                var mbi = generator.CreateRandomMbi();
                
                Console.WriteLine(mbi);
            }            
        }

    }
}
