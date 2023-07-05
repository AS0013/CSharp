namespace Problems;

public class SinglyLinkedListProblems{

    // Linked List class, for solving problem below.
    public class ListNode {
      public int val;
      public ListNode? next;
      public ListNode(int val=0, ListNode? next =null) {
          this.val = val;
          this.next = next;
      }
    }

    // Palindrome Linked List (Leetcode: Easy)
    // Given the head of a singly linked list. determine if it is a palindrome or not.
    // the solution I could think of was to first convert the linked list to an array, since 
    // traversing an array from both ends, going towards the middle index, 
    // at the same time is easy. 
    public bool IsPalindrome(ListNode head) {
        List<int> arr = new List<int>();

        ListNode? currentNode = head;
        while (currentNode != null)
        {
            arr.Add(currentNode.val);
            currentNode = currentNode.next;
        }

        for (int i = 0, j = arr.Count - 1; i <= j; i++, j--)
        {
            if (arr[i] != arr[j]){
                return false;
            }
        }
        return true;
        
    }

    // Leetcode: Easy
    // Given the head of a singly linked list, return the middle node of the linked list.
    // If there are two middle nodes, return the second middle node.

    // Using Floyd’s slow and fast pointers approach. 

     public ListNode MiddleNode(ListNode head) {
        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}