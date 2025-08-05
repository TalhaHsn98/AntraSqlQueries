// See https://aka.ms/new-console-template for more information
using Exercise03;
using static System.Console;

Console.WriteLine("Hello, World!");

//Calling the fizzbuzz class
/*FizzBuzz fizzBuzz = new FizzBuzz();

fizzBuzz.Fizzbuzz(1000);*/

// The example code
/*int max = 500;

for(byte i = 0; i < max; i++)
{
    WriteLine(i);
}*/

//Answer this goes in infinite loop we can add a checked block if it overflows then we will get an error
//stating System.OverflowException

/*int max = 500;

checked
{
    for (byte i = 0; i < max; i++)
    {
        WriteLine(i);
    }
}*/



//Calling the Randon Number class

/*
RandomNumber random = new RandomNumber();

random.Random();*/


//Calling the print a pyramid class

Print_a_Pyramid obj =  new Print_a_Pyramid();

obj.Print_Pyramid(20);

