using Problems;
class Program
{
    static void Main()
    {
        SinglyLinkedListProblems solving = new SinglyLinkedListProblems();

        SinglyLinkedListProblems.ListNode node4 = new SinglyLinkedListProblems.ListNode(1);
        SinglyLinkedListProblems.ListNode node3 = new SinglyLinkedListProblems.ListNode(2,node4);
        SinglyLinkedListProblems.ListNode node2 = new SinglyLinkedListProblems.ListNode(2,node3);
        SinglyLinkedListProblems.ListNode node1 = new SinglyLinkedListProblems.ListNode(1,node2);
        SinglyLinkedListProblems.ListNode head = node1;

        
    }
}

