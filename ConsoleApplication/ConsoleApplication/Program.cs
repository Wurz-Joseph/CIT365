using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Joseph";
            String location = "Texas";
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2020, 12, 25);
            TimeSpan daysRemaining = christmas - today;

            Console.WriteLine($"My name is {name}. I am from {location}.");
            Console.WriteLine($"Today is {today.ToString("D")}.");
            Console.WriteLine($"There are {daysRemaining.ToString("%d")} days until Christmas.");

            /*
             * Start of the example program from the book.
             */
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            //The next line was added to prompt user to enter a width.
            Console.Write("\nEnter a width: ");

            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            //The next line was added to prompt user to enter a height.
            Console.Write("Enter a height: ");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            //The next line was added to keep the console from automatically terminating.
            Console.ReadKey();

        }
    }
}
