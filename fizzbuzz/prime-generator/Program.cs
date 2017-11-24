using System;

namespace primegenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string output = FindPrimesInRange(20,60);
            Console.WriteLine(output);
        }

        public static string FindPrimesInRange(int low, int high)
        {
            string output = string.Empty;

            for (int i = low; i < high; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        if (i != j)
                            break;
                        output += i + ", ";
                    }
                }
            }
            return output;
        }
    }
}
