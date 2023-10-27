public IList<int> SpiralOrder(int[][] matrix) {
    var result = new List<int>();
    
    int rows = matrix.Length;
    int cols = matrix[0].Length;
    
    int top = 0, bottom = rows - 1, left = 0, right = cols - 1;

    while (top <= bottom && left <= right) {
        // Traverse top row
        for (int i = left; i <= right; i++) {
            result.Add(matrix[top][i]);
        }
        top++;

        // Traverse rightmost column
        for (int i = top; i <= bottom; i++) {
            result.Add(matrix[i][right]);
        }
        right--;

        // Traverse bottom row (if applicable)
        if (top <= bottom) {
            for (int i = right; i >= left; i--) {
                result.Add(matrix[bottom][i]);
            }
            bottom--;
        }

        // Traverse leftmost column (if applicable)
        if (left <= right) {
            for (int i = bottom; i >= top; i--) {
                result.Add(matrix[i][left]);
            }
            left++;
        }
    }

    return result;
}

//Time - O(M*N), Space - O(1). M, N are rows and cols respectively
