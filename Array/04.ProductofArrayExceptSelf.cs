public int[] ProductExceptSelf(int[] nums)
{
    if (nums == null || nums.Length == 0)
        return nums;

    int n = nums.Length;
    int[] result = new int[n];
    int leftProduct = 1;
    int rightProduct = 1;

    //Left-product calculation
    //This below for loop calculates the product of all elements to the left of the current element
    for (int i = 0; i < n; i++)
    {
        result[i] = leftProduct;
        leftProduct *= nums[i];
    }
  
    //Right-product calculation
    //This below for loop calculates the product of all elements to the right of the current element
    for (int i = n - 1; i >= 0; i--)
    {
        result[i] *= rightProduct;
        rightProduct *= nums[i];
    }
    return result;
}
