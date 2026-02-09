// write the main entry point code here
using System;
namespace GitHubCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get two integers from the user and print their sum
            Console.WriteLine("Enter first integer:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int num2 = int.Parse(Console.ReadLine());
            int result = Sum(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is {result}");

            Console.WriteLine("Hello, GitHub Credentials!");
            
            Console.ReadLine();
        }

        // write a method to calculate the sum of two integers
        static int Sum(int a, int b)
        {
            return a + b;
        }

        // write a method to multiply three integers
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}