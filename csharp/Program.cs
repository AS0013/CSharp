using Problems;
class Program
{
    static void Main()
    {
        ProblemSolving solving = new ProblemSolving();
        solving.FizzBuss(100);

        Console.WriteLine(solving.RomanToInt1("MCMXCIV"));
        Console.WriteLine(solving.RomanToInt2("MCMXCIV"));

    }
}

