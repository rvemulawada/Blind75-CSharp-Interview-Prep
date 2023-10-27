public void Rotate(int[][] matrix) {
    if (matrix == null || matrix.Length == 0) return;
    
    int length = matrix.Length;
    
    // Transpose the matrix
    for (int i = 0; i < length; i++) {
        for (int j = i; j < length; j++) {
            int temp = matrix[i][j];
            matrix[i][j] = matrix[j][i];
            matrix[j][i] = temp;
        }
    }

    // Reverse the rows to complete the rotation
    for (int i = 0; i < length; i++) {
        for (int j = 0; j < length / 2; j++) {
            int temp = matrix[i][j];
            matrix[i][j] = matrix[i][length - 1 - j];
            matrix[i][length - 1 - j] = temp;
        }
    }
}

//Time - O(N^2), Space - O(1)
