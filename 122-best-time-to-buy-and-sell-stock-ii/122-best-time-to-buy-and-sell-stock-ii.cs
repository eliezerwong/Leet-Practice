public class Solution {
    public int MaxProfit(int[] prices) {
        int i = 0;
        int profit = 0;
        
        //take difference in price between index & index + 1
        //{7, 1, 5, 3, 6, 4}
        // i  j
        //    i  j
        //      4
        //       i  j
        //          i  j
        //            3
        //             i  j
        //profit = 7
        //7 = (5 - 1) + (6 + 3);
        
        for (int j = 1; j < prices.Length; j ++)
        {
            if (prices[j] > prices[i])
            {
                profit += prices[j] - prices[i];
            }
            i += 1;
        }
        
        return profit;
    }
}