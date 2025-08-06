using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    public static class Rotate
    {
        public static void RotateAndSum()
        {
            string[] nums = Console.ReadLine().Split();
            int[] arr = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
                arr[i] = int.Parse(nums[i]);

            int k = int.Parse(Console.ReadLine());
            int n = arr.Length;
            int[] sum = new int[n];
            int[] rotated = new int[n];
            Array.Copy(arr, rotated, n);

            for (int r = 0; r < k; r++)
            {
                int last = rotated[n - 1];
                for (int i = n - 1; i > 0; i--)
                    rotated[i] = rotated[i - 1];
                rotated[0] = last;

                for (int i = 0; i < n; i++)
                    sum[i] += rotated[i];
            }

            for (int i = 0; i < n; i++) 
            Console.Write(sum[i] + " ");

        }
    }

}
