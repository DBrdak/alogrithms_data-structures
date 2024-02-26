using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeRoadmap.Arrays_Hashing
{
    public class ContainsDuplicateSolution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var duplicates = new HashSet<int>();

            foreach (var num in nums)
            {
                if (!duplicates.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
