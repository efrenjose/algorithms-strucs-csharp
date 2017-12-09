using System;

namespace reversestring
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string stringToReverse = "efrensevaparapuertorico";
            string stringReversed = string.Empty;

            /*for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                stringReversed += stringToReverse[i];
            }
            Console.WriteLine(stringReversed);*/

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                stringReversed += stringToReverse.Substring(i, 1);
            }
            Console.WriteLine(stringReversed);
        }
    }
}
