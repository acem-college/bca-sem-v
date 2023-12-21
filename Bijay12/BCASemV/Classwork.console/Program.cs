// See https://aka.ms/new-console-template for more information
using Chapter1;
using System.ComponentModel;


// Use interface

UserInput userInput = new Demo();
var xResult = userInput.AskForVaule("x");
var yResult = userInput.AskForVaule("y");


// Use interface
Calculator calculator = new Demo();
var addResult = calculator.add(xResult, yResult);

var subResult = calculator.sub(xResult, yResult);

Console.WriteLine($"Add result: {addResult}");
Console.WriteLine($"Sub result: {subResult}");


