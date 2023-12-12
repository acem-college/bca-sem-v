using Classwork.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

