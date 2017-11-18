using System;
namespace algorithmsstrucscsharp
{
    public class BinarySearch
    {
        public int Search(int[] array, int targetValue)
        {
            var min = 0;
            var max = array.Length - 1;
            var guessLocation = 0;

            while (max >= min)
            {
                guessLocation = Convert.ToInt32(Math.Floor(Convert.ToDouble((min + max) / 2)));

                Console.WriteLine("guessLocation: " + guessLocation);

                if (array[guessLocation] == targetValue)
                {
                    return guessLocation;
                }

                if (array[guessLocation] < targetValue)
                {
                    min = guessLocation + 1;
                }
                else
                {
                    max = guessLocation - 1;
                }
            }

            return -1;
        }
    }
}
