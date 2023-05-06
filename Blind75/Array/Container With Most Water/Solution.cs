namespace Container_With_Most_Water
{
    internal class Solution
    {
        public static int MaxArea(int[] height)
        {
            var maxArea = 0;
            var lp = 0;
            var rp = height.Length - 1;

            while(lp < rp)
            {
                maxArea = Math.Max
                    (Math.Min(height[lp], height[rp]) * (rp - lp), maxArea);

                if (height[lp] < height[rp])
                    lp++;
                else if (height[rp] < height[lp])
                    rp--;
            }

            return maxArea;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(MaxArea(new []{ 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        }
    }
}