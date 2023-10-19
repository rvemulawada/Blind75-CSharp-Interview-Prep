public int[] TwoSum(int[] nums, int target)
{
    if (nums == null || nums.Length == 0)
        return null;

    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < nums.Length; i++)
    {
        int numToFind = target - nums[i];
        if (dict.ContainsKey(numToFind))
        {
            return new int[] { dict[numToFind], i };
        }

        if (!dict.ContainsKey(nums[i]))
        {
            dict[nums[i]] = i;
        }
    }
    return null;
}

  
//Time Complexity - O(N), Space Complexity - O(N)

