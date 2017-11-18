using System;

namespace recursion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" #" + Fibonacci(number));
        }

        public static int Fibonacci(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(number - 2) + Fibonacci(number - 1);
            }
        }
    }
}
