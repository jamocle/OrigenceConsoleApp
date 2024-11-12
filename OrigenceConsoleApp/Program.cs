// See https://aka.ms/new-console-template for more information


using OrigenceConsoleApp;
using OrigenceConsoleApp.Contracts;

IStack<string> stack = new MyStack<string>();

stack.Push("1");
stack.Push("2");
stack.Push("3");
try
{
    Console.WriteLine(stack.Peek());

    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
    Console.WriteLine(stack.Pop());
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
	throw;
}

