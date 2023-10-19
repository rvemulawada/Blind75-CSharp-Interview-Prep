public int MaxSubArray(int[] nums)
{
    if (nums == null || nums.Length == 0)
        return 0;

    int currentMax = nums[0];
    int globalMax = nums[0];

    //Skipping first element i.e 0th index and start iterating from 1st index 
    foreach (int num in nums.Skip(1))
    {
        currentMax = Math.Max(num, currentMax + num);
        globalMax = Math.Max(globalMax, currentMax);
    }
  
    return globalMax;
}

// Time Complexity - O(N), Space Complexity - O(1)
