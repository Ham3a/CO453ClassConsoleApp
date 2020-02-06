using CO453_ClassConsoleApp.Unit4;
using System;

namespace CO453_ClassConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDistanceConverter();
            TestBook();
        }

        private static void TestBook()
        {
            Book book = new Book();

            book.GetDetails();
            book.WriteChapter1();
        }

        /// <summary>
        /// Task 4.1
        /// </summary>
        public static void TestDistanceConverter()
        {
            double miles = 1;
            double feet = 0;

            Console.WriteLine("Derek's Distance Converter");

            DistanceConverter converter = new DistanceConverter();

            miles = converter.GetDouble("Miles");
            feet = converter.ToFeet(miles);

            Console.WriteLine("The no of Miles = " + miles);
            Console.WriteLine("The no of feet = " + feet);

            feet = converter.GetDouble("Feet");
            miles = converter.ToMiles(feet);

            Console.WriteLine("The no of feet = " + feet);
            Console.WriteLine("The no of miles = " + miles);

        }
    }
}
