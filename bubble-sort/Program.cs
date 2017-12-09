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
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var toRight = array[j];
                        var toLeft = array[j + 1];
                        array[j] = toLeft;
                        array[j + 1] = toRight;
                    }
                }
            }
            return array;
        }
    }
}
