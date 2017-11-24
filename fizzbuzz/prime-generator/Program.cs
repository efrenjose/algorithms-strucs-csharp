using System;

namespace primegenerator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string output = string.Empty;

            for (int i = 2; i < 100; i++)
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

            Console.WriteLine(output);
        }
    }
}
