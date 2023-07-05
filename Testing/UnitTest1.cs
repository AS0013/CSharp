using Problems;

namespace Testing;

public class Tests{
    
    [SetUp]
    public void Setup()
    {
       
        
    }

    [Test]
    public void IsPalindrome_Test1()
    {
        // Arrange 
        SinglyLinkedListProblems solving = new SinglyLinkedListProblems();
        SinglyLinkedListProblems.ListNode node4 = new SinglyLinkedListProblems.ListNode(1);
        SinglyLinkedListProblems.ListNode node3 = new SinglyLinkedListProblems.ListNode(2,node4);
        SinglyLinkedListProblems.ListNode node2 = new SinglyLinkedListProblems.ListNode(2,node3);
        SinglyLinkedListProblems.ListNode node1 = new SinglyLinkedListProblems.ListNode(1,node2);
        SinglyLinkedListProblems.ListNode head = node1;

        // Act
        bool ispalindrome = solving.IsPalindrome(head);

        // Assert
        Assert.IsTrue(ispalindrome);
    }
    [Test]
    public void IsPalindrome_Test2()
    {
        // Arrange
        SinglyLinkedListProblems solving = new SinglyLinkedListProblems();
        SinglyLinkedListProblems.ListNode node4 = new SinglyLinkedListProblems.ListNode(1);
        SinglyLinkedListProblems.ListNode node3 = new SinglyLinkedListProblems.ListNode(2,node4);
        SinglyLinkedListProblems.ListNode node2 = new SinglyLinkedListProblems.ListNode(2,node3);
        SinglyLinkedListProblems.ListNode node1 = new SinglyLinkedListProblems.ListNode(2,node2);
        SinglyLinkedListProblems.ListNode head = node1;

        // Act
        bool ispalindrome = solving.IsPalindrome(head);

        // Assert
        Assert.That(ispalindrome, Is.EqualTo(false));
    }

    [Test]
    public void CanConstruct_Test1(){
        // Arrange
        string magazine = "a";
        string ransomnote = "b";
        Construct solving = new Construct();

        //Act
        bool canconstruct = solving.CanConstruct(ransomnote,magazine);

        // Assert
        Assert.That(canconstruct, Is.EqualTo(false));
    }
    [Test]
    public void CanConstruct_Test2(){
        // Arrange
        string magazine = "aa";
        string ransomnote = "ab";
        Construct solving = new Construct();

        //Act
        bool canconstruct = solving.CanConstruct(ransomnote,magazine);

        // Assert
        Assert.That(canconstruct, Is.EqualTo(false));
    }
    [Test]
    public void CanConstruct_Test3(){
        // Arrange
        string magazine = "aab";
        string ransomnote = "aa";
        Construct solving = new Construct();

        //Act
        bool canconstruct = solving.CanConstruct(ransomnote,magazine);

        // Assert
        Assert.That(canconstruct, Is.EqualTo(true));
    }
}