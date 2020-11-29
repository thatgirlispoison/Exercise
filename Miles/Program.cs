using System;

namespace Miles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string miles = Console.ReadLine();
            int intMiles = int.Parse(miles);
            Console.WriteLine("How many gallons of gas have you consumed?");
            string gallons = Console.ReadLine();
            int intGallons = int.Parse(gallons);
            int mpg = intMiles / intGallons;
            Console.WriteLine($"Your Miles Per Gallon is {mpg}");
        }
    }
}
//Write a program that asks a user for the number of miles they have driven 
//and the amount of gas they’ve consumed (in gallons), and print their miles-per-gallon.