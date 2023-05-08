namespace Sum_of_Two_Integers
{
    internal class Solution
    {
        public static int GetSum(int a, int b)
        {
            while (b != 0)
            {
                int temp = a;
                a = a ^ b;
                b = (b & temp) << 1;
            }
            return a;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(2,4));
        }
    }
}