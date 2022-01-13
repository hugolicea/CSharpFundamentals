// See https://aka.ms/new-console-template for more information
using System;
namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");

            while (true)
            {
                System.Console.WriteLine("Enter grade");
                var input = Console.ReadLine();
                if (input == "Q")
                {
                    break;
                }
                try
                {
                    var grade = double.Parse(input);
                    book.AddGrades(grade);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
            // book.AddGrades(99.0);
            // book.AddGrades(100.0);
            // book.AddGrades(90.0);
            var stats = book.GetStatistics();

            System.Console.WriteLine($"The average grade is {stats.Agerage:N2}");
            System.Console.WriteLine($"The lower grade is {stats.LowValue:N2}");
            System.Console.WriteLine($"The highest grade is {stats.HighValue:N2}");
            System.Console.WriteLine($"The highest grade is {stats.Letter}");
        }
    }
}
