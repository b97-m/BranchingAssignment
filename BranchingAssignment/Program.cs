using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Get package weight from user
            Console.Write("Enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Get package dimensions from user
            Console.Write("Enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if dimensions total greater than 50
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // Calculate quote
            double dimensionsProduct = height * width * length;
            double quote = (dimensionsProduct * weight) / 100;

            // Display the quote to the user
            Console.WriteLine($"Your shipping quote is: ${quote:F2}");
        }
}
