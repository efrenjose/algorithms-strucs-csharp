using System;

namespace bubblesort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arrayToSort = new int[] { 8, 3, 1, 7, 0, 6,
                                            3, 12, 5, 20, 17, 9};

            var sortedArray = Bubblesort(arrayToSort);

            foreach (var item in sortedArray)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] Bubblesort(int[] array)
        {
            for (int j = array.Length; j > 0; j--)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var left = array[i];
                        var right = array[i + 1];
                        array[i] = right;
                        array[i + 1] = left;
                    }
                }
            }

            return array;
        }
    }
}
