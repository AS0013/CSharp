namespace Problems;

public class ProblemSolving{

    // FizzBuzz problem. 
    // For multiples of 3, print "Fizz"
    // For multiples of 5, print "Buzz"
    // For multiples of 3 and 5, print "FizzBuzz"
    public void FizzBuss(int length){
        for (int i = 1; i <= length; i++)
        {
            if (i % 3 == 0 && i % 5 == 0){
                Console.WriteLine("FizzBuzz!");
            }
            else if (i % 3  == 0){
                Console.WriteLine("Fizz!");
            }
            else if(i % 5 == 0){
                Console.WriteLine("Buzz!");
            }
            else{
                Console.WriteLine(i);
            }

        }
    }

    // Taking a string of Roman numbers and converting into integers. (Leetcode: Easy)
    // Ended up with two solutions. Trade off between runtime and memory
     public int RomanToInt1(string s) {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M",1000}
        };
        int ans = 0;
        for (int i = 0; i < s.Length - 1; i++){
            if (dict[s[i].ToString()] < dict[s[i + 1].ToString()]){
                ans -= dict[s[i].ToString()];
            }
            else{
                ans += dict[s[i].ToString()];
            }
        }
        ans += dict[s[s.Length - 1].ToString()];
        return ans;
    }
     public int RomanToInt2(string s) {
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M",1000}
        };
        int total = 0;
        int prevValue = 0;

        for (int i = s.Length - 1; i >= 0; i--) {
            int currValue = dict[s[i].ToString()];

            if (currValue >= prevValue) {
                total += currValue;
            } else {
                 total -= currValue;
            }

            prevValue = currValue;
        }
        return total;
    }

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

    // (Leetcode: Easy)
    // Given two strings ransomNote and magazine, return true if ransomNote can be constructed
    // by using the letters from magazine and false otherwise.
    // Each letter in magazine can only be used once in ransomNote.
    // fairly trivial.
    public bool CanConstruct(string ransomNote, string magazine) {
        if (ransomNote.Length <= magazine.Length){

            List<char> magList = magazine.ToCharArray().ToList();
            for (int i = 0; i < ransomNote.Length; i++){

                if (magList.Contains(ransomNote[i])){
                    magList.Remove(ransomNote[i]);
                }
                else{
                    return false;
                }
            }
            return true;
        }
        else{
            return false;
        }
    }
}