public bool ContainsDuplicate(int[] nums)
{
    if (nums == null || nums.Length == 0)
        return false;

    HashSet<int> set = new HashSet<int>(nums);
    return set.Count < nums.Length; //true means the given array contains duplicate
}

//Time Complexity - O(N), Space Complexity - O(N)
