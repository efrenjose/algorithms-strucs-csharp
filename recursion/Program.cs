using System;

namespace recursion
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a number");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(" #" + Fibonacci(number));

            //Console.WriteLine(Recursive(3));
            Console.WriteLine(GetFib(3));
            Console.WriteLine(Fibonacci(8));
        }

        public static int Recursive(int input)
        {
            int output;
            if (input <= 0)
            {
                return input;
            }
            else
            {
                output = Recursive(input - 1);
                return output;
            }
            
        }

        public static int GetFib(int position) {
            if (position == 0) return 0;
            if (position == 1) return 1;

            int first = 0, second = 1;
            int next = first + second;

            for (int i = 2; i < position; i++)
            {
                first = second;
                second = next;
                next = first + second;
            }
            return next;
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
