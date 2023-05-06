namespace Maximum_Product_Subarray
{
    internal class Solution
    {
        public static int MaxProduct(int[] nums)
        {
            var maxSoFar = nums[0];
            var maxEndingHere = nums[0];
            var minEndingHere = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    (maxEndingHere, minEndingHere) = (minEndingHere, maxEndingHere);
                }
                maxEndingHere = Math.Max(nums[i], maxEndingHere * nums[i]);
                minEndingHere = Math.Min(nums[i], minEndingHere * nums[i]);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }
            return maxSoFar;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaxProduct(new []{ -2, 3, -4 }));
        }
    }
}