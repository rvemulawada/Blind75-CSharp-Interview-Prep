public int[][] Merge(int[][] intervals) {
    if (intervals.Length <= 1) return intervals;
    Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
    List<int[]> result = new List<int[]>();

    int[] currentInterval = intervals[0];
    for (int i = 1; i < intervals.Length; i++) {
        if (currentInterval[1] >= intervals[i][0]) {
            currentInterval[1] = Math.Max(currentInterval[1], intervals[i][1]);
        } 
        else {
            result.Add(currentInterval);
            currentInterval = intervals[i];
        }
    }
    result.Add(currentInterval);
    return result.ToArray();
}

//Time - O(NlogN) Space-O(N)
