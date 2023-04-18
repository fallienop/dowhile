string un = "admin";
string pw = "123";
string u;
string p;
go:
Random rand = new Random();
ConsoleColor getRandomColor()
{
    return (ConsoleColor)(rand.Next(Enum.GetNames(typeof(ConsoleColor)).Length));

}

do { 
Console.ForegroundColor= getRandomColor();
    if (Console.ForegroundColor == ConsoleColor.Black) goto go;
Console.Write("Enter username:");
u=Console.ReadLine();
Console.ForegroundColor = getRandomColor(); if (Console.ForegroundColor == ConsoleColor.Black) goto go;
    Console.Write("Enter password:");
 p = Console.ReadLine();
    Console.WriteLine();
} while (un != u|| pw != p);
Console.ForegroundColor =ConsoleColor.Green;
Console.WriteLine("Succesful");
Console.ResetColor();
Console.ReadLine();