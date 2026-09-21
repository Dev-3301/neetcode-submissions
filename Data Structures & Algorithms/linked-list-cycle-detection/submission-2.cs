/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode turtle = head;
        ListNode rabbit = head;
        if(head == null){
            return false;
        }

        while(turtle.next != null && rabbit.next != null && rabbit.next.next != null){
            turtle = turtle.next;
            rabbit = rabbit.next.next;
            if(turtle == rabbit){
                return true;
            }
        }
        return false;
    }
}
