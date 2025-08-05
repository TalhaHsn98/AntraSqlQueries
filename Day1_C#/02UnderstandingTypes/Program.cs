// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static void typeINFO()
{

    Console.WriteLine($"sbyte: Min = {sbyte.MinValue} Max = {sbyte.MaxValue}");
    Console.WriteLine($"byte: Min = {byte.MinValue},Max = {byte.MaxValue}");
    Console.WriteLine($"short: Min = {short.MinValue},Max = {short.MaxValue}");
    Console.WriteLine($"ushort: Min = {ushort.MinValue},Max = {ushort.MaxValue}");
    Console.WriteLine($"int: Min = {int.MinValue},Max = {int.MaxValue}");
    Console.WriteLine($"uint: Min = {uint.MinValue},Max = {uint.MaxValue}");
    Console.WriteLine($"long: Min = {long.MinValue},Max = {long.MaxValue}");
    Console.WriteLine($"ulong: Min = {ulong.MinValue},Max = {ulong.MaxValue}");
    Console.WriteLine($"float: Min = {float.MinValue},Max = {float.MaxValue}");
    Console.WriteLine($"double: Min = {double.MinValue},Max = {double.MaxValue}");
    Console.WriteLine($"decimal: Min = {decimal.MinValue},Max = {decimal.MaxValue}");

}

typeINFO();

Console.WriteLine("=================================================================");

Console.Write("Enter number of centuries: ");

int number = Convert.ToInt32(Console.ReadLine());


int years = number * 100;
long days = (long)(years * 365.24); 
long hours = days * 24;
long minutes = hours * 60;
long seconds = minutes * 60;
long milliseconds = seconds * 1000;
decimal microseconds = (decimal)milliseconds * 1000;
decimal nanoseconds = (decimal)microseconds * 1000;

Console.WriteLine($"\n{number} centuries =");
Console.WriteLine($"{years} years =");
Console.WriteLine($"{days} days =");
Console.WriteLine($"{hours} hours= ");
Console.WriteLine($"{minutes} minutes =");
Console.WriteLine($"{seconds} seconds =");
Console.WriteLine($"{milliseconds} milliseconds =");
Console.WriteLine($"{microseconds} microseconds =");
Console.WriteLine($"{nanoseconds} nanoseconds");


// Test YOUR Knowledge
//Question 1
//int a = 10;
//int b = a / 0;
//Console.WriteLine($"{b}");


//Question 2
//double a = 10.008390;
//double b = a / 0;
//Console.WriteLine($"Divide double by 0 = {b}");

//Question 3
//int max = int.MaxValue;
//int result = max + 10;
//Console.WriteLine($"Overflow result: {result}");

////Question 4
//int y = 5;
//int x1 = y++;  // post-increment
//Console.WriteLine($"x1 = {x1}, y = {y}");

//y = 5;
//int x2 = ++y;  // pre-increment
//Console.WriteLine($"x2 = {x2}, y = {y}");


//Question 5 Explained in Text file
//Question 6 Explained in Text

//Question 7 Explained in Text file

//Question 8
for (; ;) ; //just runs infinitly

//Question 9 Explained in Text file

//Question 10 Explained in Text file