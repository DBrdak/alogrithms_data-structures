namespace Maximum_Subarray
{
    internal class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            int current = nums[0];
            int check = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                check = Math.Max(nums[i], check + nums[i]);
                current = Math.Max(current, check);
            }

            return current;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaxSubArray(new[]{ -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}