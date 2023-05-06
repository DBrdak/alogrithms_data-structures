namespace Find_Minimum_in_Rotated_Sorted_Array
{
    internal class Solution
    {
        public static int FindMin(int[] nums) => nums.Min();

        static void Main(string[] args)
        {
            Console.WriteLine(FindMin(new []{1,2,0,4,5,9,12,0,-5}));
        }
    }
}