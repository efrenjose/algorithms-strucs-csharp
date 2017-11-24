using System;
using System.Collections.Generic;
using System.Linq;

namespace mergesort
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] array = { 4,1,7,3,2,10,8,20,77,32,86,45 };

            int[] returnedArr = MergeSorter.MergeSort(array);
        }
    }

    public static class MergeSorter
    {

        public static int[] MergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
                return numbers;

            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i < (numbers.Length / 2))
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

            return Merge(left, right);

        }

        public static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count()> 0 && right.Count() > 0)
            {
                if (left.First() <= right.First())
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else 
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }

            while (left.Count() > 0)
            {
                result.Add(left.First());
                left.RemoveAt(0);
            }

            while (right.Count() > 0)
            {
                result.Add(right.First());
                right.RemoveAt(0);
            }

            return result.ToArray();
        }
    }
}
