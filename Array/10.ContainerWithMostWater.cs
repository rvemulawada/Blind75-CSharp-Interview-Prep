    public int MaxArea(int[] height) {
        int start=0, end = height.Length-1;
        int maxArea =0, newMaxArea = 0;
        while(start < end){
            maxArea = Math.Min(height[start], height[end]) * (end - start);
            newMaxArea = Math.Max(maxArea, newMaxArea);
            if(height[start] < height[end]){
                start++;
            }else{
                end--;
            }
        }
        return newMaxArea;
    }

//Time - O(N), Space - O(1)
