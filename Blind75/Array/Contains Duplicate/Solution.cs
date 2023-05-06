namespace Contains_Duplicate
{
    internal class Solution
    {
        public static bool ContainsDuplicate(int[] nums) => !nums.SequenceEqual(nums.Distinct());

        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate(new []{1,2,3,3 }));
        }
    }
}