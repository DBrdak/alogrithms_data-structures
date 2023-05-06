namespace Product_of_Array_Except_Self
{
    public class Solution
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            var answer = nums.Clone() as int[];
            var num = 1;

            switch (answer.Count(n => n == 0))
            {
                case > 1:
                    for (int i = 0; i < nums.Length; i++)
                        answer[i] = 0;

                    return answer;
                case 1:
                    foreach (var number in answer)
                        if (number != 0)
                            num *= number;

                    for (int i = 0; i < answer.Length; i++)
                    {
                        if (nums[i] == 0)
                            answer[i] = num;
                        else
                            answer[i] = 0;
                    }

                    return answer;
                case 0:
                    foreach (var number in answer)
                        num *= number;

                    for (int i = 0; i < answer.Length; i++)
                        answer[i] = num;

                    for (int i = 0; i < answer.Length; i++)
                        answer[i] /= nums[i];

                    return answer;
            }

            return answer;
        }

        static void Main(string[] args)
        {
            var answer = ProductExceptSelf(new[] { -1, 1, 0, -3, 3 });

            Console.Write("[ ");
            foreach (var i in answer)
            {
                Console.Write($"{i} ");
            }

            Console.Write("]");
        }
    }
}