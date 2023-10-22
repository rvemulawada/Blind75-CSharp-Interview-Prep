    public int EraseOverlapIntervals(int[][] intervals) {
    if (intervals.Length == 0) return 0;
    
    Array.Sort(intervals, (x, y) => x[1].CompareTo(y[1])); //Sort interval by end times
    int minInt = 1; // Count the first interval
    
    int end = intervals[0][1];
    
    for (int i = 1; i < intervals.Length; i++) {
        if (intervals[i][0] >= end) {
            minInt++;
            end = intervals[i][1];
        }
    }   
    return intervals.Length - minInt;
}
