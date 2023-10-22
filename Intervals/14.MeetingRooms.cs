public class Solution {
    public bool CanAttendMeetings(int[][] intervals) {
        if (intervals == null || intervals.Length <= 1) return true;

        // Sort the intervals by their start times
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] < intervals[i - 1][1]) {
                // If the start time of the current interval is less than the end time of the previous interval, return false
                return false;
            }
        }

        // If no overlapping intervals are found, return true
        return true;
    }
}
//Time - O(NlogN), Space - O(1)
