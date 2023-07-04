using Problems;
class Program
{
    static void Main()
    {
        isPalindrome solving = new isPalindrome();

        isPalindrome.ListNode node4 = new isPalindrome.ListNode(1);
        isPalindrome.ListNode node3 = new isPalindrome.ListNode(2,node4);
        isPalindrome.ListNode node2 = new isPalindrome.ListNode(2,node3);
        isPalindrome.ListNode node1 = new isPalindrome.ListNode(1,node2);
        isPalindrome.ListNode head = node1;

        
    }
}

