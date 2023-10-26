public ListNode MergeKLists(ListNode[] lists) {
    if (lists == null || lists.Length == 0) return null;
    return MergeKListsHelper(lists, 0, lists.Length - 1);
}

private ListNode MergeKListsHelper(ListNode[] lists, int start, int end) {
    if (start == end) return lists[start];
    int mid = start + (end - start) / 2;
    ListNode left = MergeKListsHelper(lists, start, mid);
    ListNode right = MergeKListsHelper(lists, mid + 1, end);
    return MergeTwoLists(left, right);
}

private ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    ListNode dummy = new ListNode(-1);
    ListNode curr = dummy;
    
    while (list1 != null && list2 != null) {
        if (list1.val <= list2.val) {
            curr.next = list1;
            list1 = list1.next;
        } else {
            curr.next = list2;
            list2 = list2.next;
        }
        curr = curr.next;
    }

    curr.next = (list1 != null) ? list1 : list2;

    return dummy.next;
}

//Time - O(N * log(K)), Space - O(log(K))
