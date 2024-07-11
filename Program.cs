Console.WriteLine("Arithmetic operations");

Console.WriteLine("Please, enter the first number");
var number1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please, enter the second number");
var number2 = Convert.ToDouble(Console.ReadLine());

var Sum1 = number1 + number2;
Console.WriteLine($"Sum: {number1} + {number2} = {Sum1}");
var Sum2 = number1 - number2;
Console.WriteLine($"Sum: {number1} - {number2} = {Sum2}");
var Sum3 = number1 * number2;
Console.WriteLine($"Sum: {number1} * {number2} = {Sum3}");
var Sum4 = number1 / number2;
Console.WriteLine($"Sum: {number1} / {number2} = {Sum4}");