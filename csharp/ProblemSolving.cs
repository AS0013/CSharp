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
}