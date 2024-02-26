using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCodeRoadmap.Arrays_Hashing
{
    public class ValidAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            var s1 = s.ToCharArray();
            var t1 = t.ToCharArray();

            Array.Sort(s1);
            Array.Sort(t1);

            return new string(s1).Equals(new string(t1));
        }
    }
}
