using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerical grade between 0 and 100: ");
           double grade = Convert.ToDouble(Console.ReadLine());
            
                if (grade >= 90 && grade <= 100)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (grade >= 60 && grade <= 69)
                {
                    Console.WriteLine("Grade: D");
                }
                else if (grade <= 60 && grade >= 0)
            {
                    Console.WriteLine("Grade: F");
                }
            
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
            }
        }
    }
}