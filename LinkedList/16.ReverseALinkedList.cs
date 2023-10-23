public ListNode ReverseList(ListNode head) {
    ListNode prev = null;
    
    while (head != null) {
        ListNode next = head.next;
        head.next = prev;
        prev = head;
        head = next;
    }   
    return prev;
}

//Time - O(N), Space - O(1)
