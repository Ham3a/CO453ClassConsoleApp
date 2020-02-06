using CO453_ClassConsoleApp.Unit4;
using System;

namespace CO453_ClassConsoleApp
{
    /// <summary>
    /// This class create objects for each of the tasks as
    /// defined in Part A of CO453 and tests that each object
    /// works
    /// 
    /// Objects include: DistanceConverter,  Book
    /// 
    /// Author: Dr Derek Peacock
    /// </summary>
    class Program
    {
        /// <summary>
        /// This method is called first when the program is executed
        /// </summary>
        static void Main(string[] args)
        {
            //TestDistanceConverter();
            TestBook();
        }

        /// <summary>
        /// Task 4.2 Create a Book object and test that it writes chapter 1 and 2
        /// Task 4.3 Add a Book Constructor method to initialise all the attributes
        /// </summary>
        private static void TestBook()
        {
            Book book = new Book();

            book.GetDetails();
            book.WriteChapter1();
        }

        /// <summary>
        /// Task 4.1 Create a Converter and check that it converts between
        /// miles and feet using double numbers
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
