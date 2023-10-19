public int MaxProduct(int[] nums)
{
    int maxProd = 1;
    int result = int.MinValue;

    // Left-to-right pass
    for (int i = 0; i < nums.Length; i++)
    {
        maxProd *= nums[i];
        result = Math.Max(maxProd, result);
        if (maxProd == 0)
            maxProd = 1;
    }

    maxProd = 1;
    // Right-to-left pass
    for (int i = nums.Length - 1; i >= 0; i--)
    {
        maxProd *= nums[i];
        result = Math.Max(maxProd, result);
        if (maxProd == 0)
            maxProd = 1;
    }
    return result;
}

//Time Complexity - O(N), Space Complexity - O(1)
