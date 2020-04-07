using System;
using sombis.Core;

namespace sombis
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new Generator();

            var consoleWidth = Console.WindowWidth;
            var consoleHeight = Console.WindowHeight;
            var perLineLimit = Math.Floor(((double)consoleWidth) / (Generator.MBILength + 1));
            
            for (var row = 1; row <= consoleHeight - 1; row++)
            {
                for (var col = 1; col <= perLineLimit; col++)
                {
                    var mbi = generator.CreateRandomMbi();  
                    Console.Write($"{mbi} ");
                }
                Console.WriteLine();
            }
        }
    }
}
