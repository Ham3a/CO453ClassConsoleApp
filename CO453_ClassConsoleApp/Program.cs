using CO453_ClassConsoleApp.Unit4;
using System;

namespace CO453_ClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = 1;
            double feet = 0;

            Console.WriteLine("Derek's Distance Converter");

            DistanceConverter converter = new DistanceConverter();

            feet = converter.ToFeet(miles);
            Console.WriteLine("The no of feet = " + feet);

            feet = 1760 * 3;
            miles = converter.ToMiles(feet);
            Console.WriteLine("The no of miles = " + miles);
        }
    }
}
