public class Solution {
    public int MaxProfit(int[] prices) {
        int min = Int32.MaxValue;
        int profit = 0;
        foreach(var price in prices)
        {
            if(price < min)
                min = price;
            else if(price-min > profit)
                profit = price - min;
        }
        return profit;
    }
}