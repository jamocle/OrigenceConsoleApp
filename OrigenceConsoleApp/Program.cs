// See https://aka.ms/new-console-template for more information


using OrigenceConsoleApp;
using OrigenceConsoleApp.Contracts;

//Remove Duplicates

/* Requirements:
* Remove all duplicate characters in a string
* If string is null return null;
* if string is empty return empty
*/

//Test case 1
//null string  Should return "IsNull"
string? x = null;
Console.WriteLine(x.RemoveDuplicates() ?? "IsNull");

//Test case 2
//Empty string  Should return ''
x = string.Empty;
Console.WriteLine($"'{x.RemoveDuplicates()}'");

//Test case 3
//xyzzy string  Should return 'xyz'
x = "xyzzy";
Console.WriteLine($"'{x.RemoveDuplicates()}'");

//Test case 4
//xbcdr string  Should return 'xbcdr'
x = "xbcdr";
Console.WriteLine($"'{x.RemoveDuplicates()}'");


return;
//Create a stack
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

