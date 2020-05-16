using System;

namespace EastAsianWidthDotNet.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = "全角.".GetWidth();
            Console.WriteLine($"Width is {width}.");
        }
    }
}
