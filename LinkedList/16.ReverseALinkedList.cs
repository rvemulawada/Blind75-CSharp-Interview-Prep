Problem Statement:
Given the head of a singly linked list, reverse the list, and return the reversed list.
Example 1:

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
-----------------------------------------------------------------------------

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
