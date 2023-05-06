namespace Search_in_Rotated_Sorted_Array
{
    internal class Program
    {
        public static int Search(int[] nums, int target) => 
            nums.ToList().IndexOf(target);


        static void Main(string[] args)
        {
            Console.WriteLine(Search(new []{ 4, 5, 6, 7, 0, 1, 2 }, 77));
        }
    }
}