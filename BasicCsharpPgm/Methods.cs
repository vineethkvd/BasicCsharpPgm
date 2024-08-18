using System;
using System.IO;
namespace Methods
{
    class CsharpMethods
    {
        public CsharpMethods()
        {
            Console.WriteLine("Default Constructor");
        }
        //void function
        //return no value
        public void Greet()
        {
            Console.WriteLine("Hello, World!");
        }
        //static function
        public static void ShowMessage()
        {
            Console.WriteLine("This is a static method.");
        }
        //return function
        public int Add(int a, int b)
        {
            return a + b;
        }
        // Method with required and optional parameters
        public int ChkSum(int a, int b = 0, int c = 0)
        {
            return a + b + c;
        }

        //Overloaded function
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        //recursive function
        public int Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        // Async function
        public async Task<int> FetchDataAsync()
        {
            // Simulate a delay
            await Task.Delay(2000);
            return 42; // Example result
        }

        // Method to demonstrate lambda expression
        public void DemonstrateLambda()
        {
            // Expression lambda that returns the square of a number
            Func<int, int> square = num => num * num;

            // Passing input to the expression lambda
            Console.WriteLine("Square of number: " + square(5));
        }

    }
}