    public int MinMeetingRooms(int[][] intervals) {
        if (intervals == null || intervals.Length == 0) return 0;

        // Sort the intervals by start times
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        // Create a priority queue (min heap) to track the end times of ongoing meetings
        var minHeap = new PriorityQueue<int>();
        
        // Add the end time of the first meeting to the min heap
        minHeap.Enqueue(intervals[0][1]);

        for (int i = 1; i < intervals.Length; i++) {
            if (intervals[i][0] >= minHeap.Peek()) {
                // If the start time of the current meeting is greater than or equal to
                // the end time of the meeting at the top of the min heap, no additional room is needed.
                minHeap.Dequeue();
            }

            // Add the end time of the current meeting to the min heap
            minHeap.Enqueue(intervals[i][1]);
        }

        // The size of the min heap represents the minimum number of meeting rooms required.
        return minHeap.Count;
    }

// Time - O(n * log(n)), and the space complexity is O(n).
