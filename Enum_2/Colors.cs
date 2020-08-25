using System;
using System.Collections.Generic;
using System.Linq;

namespace Enum_2
{
    public enum Colors
    {
        Red = 4,
        Black = 2,
        Blue = 15,
        Green = 1,
        Yellow = 6,
        White = 23
    }

    public static class Extentions
    {
        public static void ColorsOrderBy()
        {
            List<int> valuesList = new List<int>();

            foreach (var item in Enum.GetValues(typeof(Colors)))
            {
                valuesList.Add((int)item);
            }

            foreach (var item in valuesList.OrderBy(x => x))
            {
                Console.WriteLine($"{Enum.GetName(typeof(Colors), item)} = {item}");
            }
        }
    }
}