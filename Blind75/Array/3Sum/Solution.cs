using System.Reflection.Metadata.Ecma335;
using Xunit;

namespace _3Sum;

internal class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        var result = new List<IList<int>>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            var lp = i + 1;
            var rp = nums.Length - 1;
            while (lp < rp)
            {
                var threeSum = nums[i] + nums[lp] + nums[rp];

                switch (threeSum)
                {
                    case > 0:
                        rp--;
                        break;
                    case < 0:
                        lp++;
                        break;
                    case 0:
                        result.Add(new List<int>{ nums[i], nums[lp], nums[rp] });
                        lp++;
                        while (nums[lp] == nums[lp - 1] && lp < rp)
                            lp++;
                        break;
                }
            }
        }

        return result;
    }


    private static string ToString(IList<IList<int>> nums)
    {
        var result = "[";

        foreach (var list in nums)
        {
            result += "[";

            foreach (var num in list)
            {
                result += $" {num} ";
            }

            result += "],";
        }

        return result + "]";
    }

    static void Main(string[] args)
    {
        Console.WriteLine(ToString(ThreeSum(new []{ -2, 0, 1, 1, 2 })));
    }
}