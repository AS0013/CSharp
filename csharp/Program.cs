using Problems;
class Program
{
    static void Main()
    {
        ProblemSolving solving = new ProblemSolving();

        ProblemSolving.ListNode node4 = new ProblemSolving.ListNode(1);
        ProblemSolving.ListNode node3 = new ProblemSolving.ListNode(2,node4);
        ProblemSolving.ListNode node2 = new ProblemSolving.ListNode(2,node3);
        ProblemSolving.ListNode node1 = new ProblemSolving.ListNode(1,node2);
        ProblemSolving.ListNode head = node1;

        // solving.FizzBuss(100);
        
        // Console.WriteLine(solving.RomanToInt1("MCMXCIV"));
        // Console.WriteLine(solving.RomanToInt2("MCMXCIV"));
        Console.WriteLine(solving.IsPalindrome(head));

    }
}

