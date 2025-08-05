// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! are you ok ");

//Introduce some errors 
//Console.WriteLine(jfdiwoaf"Hello, World! ok ");


static void nameGenerate(string? astrologysign, string? favoriteColor, string? streeAddressNumber)
{
    string a = astrologysign;
    string b = favoriteColor;
    string c = streeAddressNumber;
    Console.WriteLine("YOUR Hacker Name is:");
    Console.WriteLine($"{a}{b}{c}");
}

Console.WriteLine("Write favorite color:");
string color = Console.ReadLine();

Console.WriteLine("Write astrology sign:");
string astrology = Console.ReadLine();

Console.WriteLine("Write street address number:");
string streeAddressNumber = Console.ReadLine();

nameGenerate(astrology,color,streeAddressNumber);

Console.ReadLine();