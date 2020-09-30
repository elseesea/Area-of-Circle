using System;


namespace Area_of_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            string userInput;
            do
            {
                Console.Write("Enter a radius (in miles): ");
                userInput = Console.ReadLine();
                bool validFloat = double.TryParse(userInput, out radius);
                if (!validFloat)
                {
                    Console.WriteLine("\nInvalid miles. Program aborting.");
                    Environment.Exit(1);
                }
            } while (radius < 0);
            double area = Circle.CalcArea(radius);
            double circumference = Circle.CalcCircumference(radius);
            double diameter = Circle.CalcDiameter(radius);
            Console.WriteLine("The area of a circle of radius " + radius + " is : " + Math.Round(area, 3));
            Console.WriteLine("The circumference of a circle of radius " + radius + " is : " + Math.Round(circumference, 3));
            Console.WriteLine("The diameter of a circle of radius " + radius + " is : " + Math.Round(diameter, 3));

            Console.Write("\nEnter miles per gallon for your car: ");
            userInput = Console.ReadLine();
            double mpg = double.Parse(userInput);
            double gallons = circumference / mpg;
            Console.WriteLine("It will take " + Math.Round(gallons, 3) + " gallons to go one time around a circle with radius of " + radius + " miles.");
        }
    }
}
