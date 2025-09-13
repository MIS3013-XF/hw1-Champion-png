// HW1b Grade

// Your Name: Champion Scott
// Did you seek help ? If yes, specify the helper or web link here: No, I did not seek help

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your grade (0-100): ");

        }
    }
}
using System;   
namespace SaleTotal
{
    class Program
    {
        static void Main()
        {
            const double SALES_TAX_RATE = 0.085; // 8.5%

            Console.Write("What is the product name of the item you are purchasing? ");
            string productName = Console.ReadLine();

            Console.Write($"How many {productName}(s) do you want to buy? ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write($"What is the price for each {productName}? ");
            double priceEach = double.Parse(Console.ReadLine());

            double subtotal = quantity * priceEach;
            double salesTax = subtotal * SALES_TAX_RATE;
            double total = subtotal + salesTax;

            Console.WriteLine($"\nYour subtotal for your bill is {subtotal:C}");
            Console.WriteLine($"Your sales tax for your bill is {salesTax:C}");
            Console.WriteLine($"Your total for your bill is {total:C}");

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }

}
using System;

namespace StudentGrade
{
    class Program
    {
        static void Main()
        {
            // weights – adjust to match your syllabus
            const double HW_WEIGHT = 0.20;
            const double PART_WEIGHT = 0.10;
            const double QUIZ_WEIGHT = 0.20;
            const double EXAM_WEIGHT = 0.50;

            Console.Write("What is your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("What is your student id? ");
            string studentId = Console.ReadLine();

            Console.Write("What is your overall percentage grade for homeworks? ");
            double hwPercent = double.Parse(Console.ReadLine());

            Console.Write("What is your overall percentage grade for participation? ");
            double partPercent = double.Parse(Console.ReadLine());

            Console.Write("What is your overall percentage grade for quizzes? ");
            double quizPercent = double.Parse(Console.ReadLine());

            Console.Write("What is your overall percentage grade for exams? ");
            double examPercent = double.Parse(Console.ReadLine());

            double finalGrade = hwPercent * HW_WEIGHT +
                                partPercent * PART_WEIGHT +
                                quizPercent * QUIZ_WEIGHT +
                                examPercent * EXAM_WEIGHT;

            Console.WriteLine($"\nStudent: {firstName} {lastName} (ID: {studentId})");
            Console.WriteLine($"Your final grade is {finalGrade:F2}%");

            Console.WriteLine("\nPress any key to exit . . .");
            Console.ReadKey();
        }
    }
}