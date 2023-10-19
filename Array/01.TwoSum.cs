## Problem Statement

Given an array of integers `nums` and an integer `target`, your task is to find and return the indices of 
two numbers in the array such that they add up to the given `target`. You can assume that each input will 
have exactly one valid solution, and you should not use the same element twice in your answer. The order in
which you return the indices does not matter.

### Example 1

#### Input

nums = [2, 7, 11, 15]
target = 9
Output: [0, 1]
Explanation
Because nums[0] + nums[1] == 9, we return [0, 1].
    
###

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

