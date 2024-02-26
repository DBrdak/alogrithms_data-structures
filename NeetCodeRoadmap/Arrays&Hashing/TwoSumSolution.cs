namespace NeetCodeRoadmap.Arrays_Hashing
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var prevMap = new Dictionary<int, int>();
            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                var diff = target - nums[i];

                if (prevMap.TryGetValue(diff, out var j))
                {
                    return new[] { j , i };
                }

                prevMap.TryAdd(nums[i], i);
            }

            return result;
        }
    }
}
