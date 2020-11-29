using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length?");
            string length = Console.ReadLine();
            int intLength = int.Parse(length);
            Console.WriteLine("What is the width?");
            string width = Console.ReadLine();
            int intWidth = int.Parse(width);
            int area = intLength * intWidth;
            Console.WriteLine($"The area is {area}");
        }
    }
}
