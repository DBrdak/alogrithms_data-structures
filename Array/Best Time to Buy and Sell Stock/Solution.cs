namespace Best_Time_to_Buy_and_Sell_Stock
{
    internal class Solution
    {
        public static int MaxProfit(int[] prices)
        {
        //    var profit = 0;

        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i+1; j < prices.Length; j++)
        //        {
        //            if (prices[j] - prices[i] > profit)
        //                profit = prices[j] - prices[i];
        //        }
        //    }
        //    return profit;

            var maxProfit = new List<int>();
            var buyPrice = prices[0];
            var sellPrice = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > sellPrice)
                    sellPrice = prices[i];

                else if (i < prices.Length - 1 && 
                        prices[i] < buyPrice)
                {
                    buyPrice = prices[i];
                    sellPrice = prices[i];
                }

                maxProfit.Add(sellPrice - buyPrice);
            }

            return maxProfit.Max();
        }

        static void Main(string[] args)
        {
            var result = MaxProfit(new[] { 7, 6, 4, 3, 1 });

            Console.WriteLine(result);
        }
    }
}