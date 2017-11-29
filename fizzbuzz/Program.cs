using System;

namespace fizzbuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string output = string.Empty;

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) {
                    output += "FizzBuzz, ";
                } else if (i % 3 == 0){
                    output += "Fizz, ";
                } else if (i % 5 == 0) {
                    output += "Buzz, "; 
                } else {
                    output += i + ", ";
                }
            }

            Console.WriteLine(output);
        }
    }
}
