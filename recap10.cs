using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade (A, B, C, D, E, F)");
            string grade = Console.ReadLine();

            switch (grade)
            {
                case "A":
                    Console.WriteLine("Good job");
                    break;
                case "B":
                    Console.WriteLine("Pretty good");
                    break;
                case "C":
                    Console.WriteLine("Passed");
                    break;
                case "D":
                    Console.WriteLine("Not so good");
                    break;
                case "E":
                    Console.WriteLine("Failed");
                    break;
                case "F":
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("N/A");
                    break;
            }
        }
    }
}
