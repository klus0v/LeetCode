namespace LeetCode.Easy;

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock
public class BestTimeToBuyAndSellStock_121
{
    public int MaxProfit(int[] prices)
    {
        var min = prices[0];
        var maxProfit = 0;
        
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < min)
                min = prices[i];
            
            else if(prices[i] - min > maxProfit )
            {
                maxProfit = prices[i] - min;
            }
        }
        return maxProfit;
    }
}