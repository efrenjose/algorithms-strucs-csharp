using System;

namespace algorithmsstrucscsharp
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoBinarySearch();
        }

        public static void DoBinarySearch()
        {

            int[] numbers = new int[] {1, 2, 3, 4, 5,
                                    6, 7, 8, 9, 10,
                                    11, 12, 13, 14, 15,
                                    16, 17, 18 ,19, 20};

            BinarySearch binarySearch = new BinarySearch();

            int location = binarySearch.Search(numbers, 7);

            Console.WriteLine("location = " + location);
        }
    }
}
