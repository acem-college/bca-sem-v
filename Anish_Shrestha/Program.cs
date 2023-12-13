// See https://aka.ms/new-console-template for more information
using SemV.ConsoleApp;

Console.WriteLine("Hello, World!");

// Use interface
var userInput = new UserInput();
var xResult = userInput.AskForVaule("x");
var yResult = userInput.AskForVaule("y");
 interface askvalues
{

}
class
// Use interface
var calculator = new Calculator();
var addResult = calculator.Add(xResult, yResult);

var subResult = calculator.Substract(xResult, yResult);

Console.WriteLine($"Add result: {addResult}");
Console.WriteLine($"Sub result: {subResult}");