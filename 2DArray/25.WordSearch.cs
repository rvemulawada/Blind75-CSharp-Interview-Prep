    private bool[][] visited;
    public bool Exist(char[][] board, string word) {
        int rows = board.Length;
        int cols = board[0].Length;
        visited = new bool[rows][];
        for (int i = 0; i < rows; i++) {
            visited[i] = new bool[cols];
        }
        
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (word[0] == board[i][j] && SearchWord(i, j, 0, board, word)) {
                    return true;
                }
            }
        } 
        return false;
    }
    
    private bool SearchWord(int i, int j, int index, char[][] board, string word) {
        if (word.Length == index) {
            return true;
        }  
        if (i < 0 || i >= board.Length || j < 0 || j >= board[0].Length || word[index] != board[i][j] || visited[i][j]) {
            return false;
        }
        visited[i][j] = true;
        if (SearchWord(i + 1, j, index + 1, board, word) ||
            SearchWord(i - 1, j, index + 1, board, word) ||
            SearchWord(i, j + 1, index + 1, board, word) ||
            SearchWord(i, j - 1, index + 1, board, word)) {
            return true;
        }
        visited[i][j] = false;
        return false;
    }

//Time - O(rows * cols * 4^k), Space- O(rows * cols)
