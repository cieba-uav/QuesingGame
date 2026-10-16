using System;

Console.WriteLine("Hello, welcome to the Quesing Game!");
Console.WriteLine("Please enter random number");
Console.ReadLine();

// maszyna nowa
Random losator = new Random();

// pilot
int randomNumber = losator.Next(11);
Console.WriteLine("The random number is: " + randomNumber);
Console.WriteLine("Did you guess the number?  YES/NO");

// odczytanie odpowiedzi gracza
string UserQuess = Console.ReadLine();
if (UserQuess == "YES")
{
    Console.WriteLine("You guessed the number!");
}
else if (UserQuess == "NO")
{
    Console.WriteLine("You didn't guess the number.");
}
else
{
    Console.WriteLine("Invalid input. Please enter YES or NO.");
}
Console.ReadKey();
