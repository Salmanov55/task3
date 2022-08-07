using System;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1,2,3,4,5};
            Console.WriteLine();
        }
        static void PrintMinandMax(int[] arr)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int Min = 0;
            int Max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
               if (nums[Min] > nums[i])
                {
                    Min =nums [i];
                }
               else if (nums[Max] < nums[i])
                {
                    Max =nums [i];
                }
                   int temp = nums[Min];
                nums [Min] = nums [Max];
                nums [Max] = temp;
            }
        }
    }

}
