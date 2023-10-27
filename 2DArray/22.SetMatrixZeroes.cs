public void SetZeroes(int[][] matrix) {
    int rows = matrix.Length;
    int cols = matrix[0].Length;

    bool[] rowZero = new bool[rows];
    bool[] colZero = new bool[cols];

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (matrix[i][j] == 0) {
                rowZero[i] = true;
                colZero[j] = true;
            }
        }
    }

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            if (rowZero[i] || colZero[j]) {
                matrix[i][j] = 0;
            }
        }
    }
}

//Time - O(m * n), Space - O(m+n) where m, n are rows and columns respectively
