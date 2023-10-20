 public IList<IList<int>> ThreeSum(int[] nums) {
    var list = new List<IList<int>>();
    if(nums == null || nums.Length == 0) return list;

    Array.Sort(nums);
    int length = nums.Length;
    for(int i=0; i< length; i++){
        if(i >0 && nums[i] == nums[i-1]){
            continue;
        }
        int j = i+1, k= length-1;
        while(j < k){
            int sum = nums[i] + nums[j] + nums[k];
            if(sum == 0){
                list.Add(new List<int>(){nums[i], nums[j++], nums[k--]});
                while(j<k && nums[j] == nums[j-1]) {j++;}
                while(j<k && nums[k] == nums[k+1]) {k--;}
            }else if(sum >0){
                k--;
            }else{
                j++;
            }
        }
    }
        return list;
  }

//Time Complexity - O(N), Space Complexity - O(1)
