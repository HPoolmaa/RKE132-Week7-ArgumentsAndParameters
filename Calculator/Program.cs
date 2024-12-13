﻿Console.WriteLine("Enter the operation (+;-;*;/):");
char userOperator = char.Parse(Console.ReadLine());
Console.WriteLine("Enter value a:");
int firstNum = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter value b:");
int secondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(firstNum, secondNum);
        break;
    case '-':
        Substraction(firstNum, secondNum);
        break;
    case '*':
        Multiplication(firstNum, secondNum);
        break;
    case '/':
        Divide(firstNum, secondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}


static void Addition(int a, int b)
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}
static void Substraction(int a, int b)
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}
static void Multiplication(int a, int b)
{
    Console.WriteLine($"{a} * {b} = {a * b}");
}
static void Divide(int a, int b)
{
    Console.WriteLine($"{a} / {b} = {a / b}");
}