using System;

namespace Enum_3
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine($"Max = {(long)LongRange.Max}");
            Console.WriteLine($"Min = {(long)LongRange.Min}");
        }
    }
}