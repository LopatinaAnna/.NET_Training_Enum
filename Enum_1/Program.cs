using System;

namespace Enum_1
{
    static class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Enter number(0<=n<12): ");
                string input = Console.ReadLine();
                try
                {
                    int n = int.Parse(input);
                    if (n < 0 || n >= 12)
                        Console.WriteLine("Incorrect input");
                    else Console.WriteLine(Enum.GetName(typeof(Month), n));
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect input");
                }
                Console.WriteLine("\nEnter Esc to exit or any other key to continue");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}