public bool HasCycle(ListNode head) {
    ListNode slow = head;
    ListNode fast = head;

    while (fast != null && fast.next != null) {
        slow = slow.next;
        fast = fast.next.next;

        if (slow == fast) {
            return true;  // Detected a cycle
        }
    }
    return false;  // No cycle found
}

//Time - O(N), Space - O(1)
