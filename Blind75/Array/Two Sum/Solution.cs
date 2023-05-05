using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Two_Sum
{
    internal class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if(i == j)
                        continue;

                    if (nums[i] + nums[j] == target)
                        return new[] { i, j };
                }
            }
            return null;
        }

        static void Main(string[] args)
        {
            var input = TwoSum(new[] { 3, 2, 4, 3, 4, 1, 5 }, 9);

            if(input is not null)
                Console.WriteLine($"[{input[0]},{input[1]}]");
        }
    }
}