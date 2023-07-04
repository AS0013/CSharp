namespace Problems;

public class isPalindrome{

    // Linked List class, for solving the isPalindrome problem below.
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
}