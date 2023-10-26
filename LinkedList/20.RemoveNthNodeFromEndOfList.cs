public ListNode RemoveNthFromEnd(ListNode head, int n) {
    if (head == null || n <= 0) return head;
    
    ListNode dummy = new ListNode(0);
    dummy.next = head;
    ListNode first = dummy;
    ListNode second = dummy;
    
    // Advance the first pointer by n+1 steps.
    for (int i = 0; i < n + 1; i++) {
        if (first == null) {
            // The value of n is greater than or equal to the length of the list.
            return head;
        }
        first = first.next;
    }
    
    // Move both pointers until the first pointer reaches the end of the list.
    while (first != null) {
        first = first.next;
        second = second.next;
    }
    
    // Remove the nth node by updating the next pointer of the node before it.
    second.next = second.next.next;
    
    return dummy.next;
}

//Time - O(N), Space - O(1)
