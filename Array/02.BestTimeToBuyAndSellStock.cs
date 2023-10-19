public int MaxProfit(int[] prices) {
    int minPrice = int.MaxValue, maxProfit = 0;

    foreach (int price in prices) {
      
      // Update minPrice and maxProfit variables as you traverse the array
      // to calculate maxProfit and return it after completing the traversal

        minPrice = Math.Min(minPrice, price);
        maxProfit = Math.Max(maxProfit, price - minPrice);
    }

    return maxProfit;
}

//Time Complexity - O(N), Space Complexity - O(N)
