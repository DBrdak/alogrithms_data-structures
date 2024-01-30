using static System.Int32;

namespace Number_of_1_Bits
{
    internal class Solution
    {
        public static int HammingWeight(uint n) => PopCount((int)n);

        static void Main(string[] args)
        {
            Console.WriteLine(HammingWeight(00000000000000000000000000001011));
        }
    }
}