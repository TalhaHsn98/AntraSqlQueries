// See https://aka.ms/new-console-template for more information
using Day3_C_;

Console.WriteLine("Hello, World!");


//Stack

MyStack<int> stack = new MyStack<int>();

stack.Push(10);
stack.Push(20);
stack.Push(30);

Console.WriteLine("Count: " + stack.Count()); // 3

Console.WriteLine("Popped: " + stack.Pop());  // 30
Console.WriteLine("Count: " + stack.Count()); // 2