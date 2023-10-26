public void ReorderList(ListNode head) {
    if (head == null) return;

    // Find the middle of the linked list
    ListNode slow = head, fast = head;
    while (fast != null && fast.next != null) {
        slow = slow.next;
        fast = fast.next.next;
    }

    // Reverse the second half of the linked list
    ListNode prev = null, curr = slow, temp;
    while (curr != null) {
        temp = curr.next;
        curr.next = prev;
        prev = curr;
        curr = temp;
    }

    // Reorder the linked list
    ListNode first = head, second = prev;
    while (second.next != null) {
        temp = first.next;
        first.next = second;
        first = temp;

        temp = second.next;
        second.next = first;
        second = temp;
    }
}

//Time - O(N), Space - O(1)
