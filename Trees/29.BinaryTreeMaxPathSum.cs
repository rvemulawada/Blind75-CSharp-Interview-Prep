//Link to Question: https://leetcode.com/problems/binary-tree-maximum-path-sum/

```
public class Solution {
    private int maxPathSum = int.MinValue; 

    public int MaxPathSum(TreeNode root) {
        if(root == null){
            return 0;
        }
        maxPathSumHelper(root);
        return maxPathSum;
    }

    public int maxPathSumHelper(TreeNode node){
        if(node == null){
            return 0;
        }

        int left = Math.Max(0, maxPathSumHelper(node.left));
        int right = Math.Max(0, maxPathSumHelper(node.right));

        int currentPathSum = node.val + left + right;
        maxPathSum = Math.Max(currentPathSum, maxPathSum);

        return node.val + Math.Max(left, right);
    }
}

```

//Time - O(N) Space - O(N)
