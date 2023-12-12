using Classwork.Console;

class Program
{
    static void Main()
    {
        // Use interface
        IUserInput userInput = new UserInput();
        var xResult = userInput.AskForValue("x");
        var yResult = userInput.AskForValue("y");

        // Use interface
        ICalculator calculator = new Calculator();
        var addResult = calculator.Add(xResult, yResult);
        var subResult = calculator.Subtract(xResult, yResult);

        Console.WriteLine($"Add result: {addResult}");
        Console.WriteLine($"Sub result: {subResult}");
    }
}