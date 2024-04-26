// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisestada tema vanuse
//kui kasutaja vanus on väiksem kui 13, siin konsoolis kuvatakse:
//"You are to young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"


using System;

Console.WriteLine("Enter your age:");

string userAge = Console.ReadLine();

int userAgeNum = 0;

//boolean - true/false

bool isageNumber = Int32.TryParse(userAge, out userAgeNum);

//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13 - stack

Console.WriteLine($"Parse result {isageNumber}. User is {userAgeNum} years old");

if (isageNumber)
{
    if (userAgeNum >= 13)
    {
        Console.WriteLine("Welcome to Instagram.");
    }
    else
    {
        Console.WriteLine("You are too young to use Instagram.");
    }
}
else
{
    Console.WriteLine("Could not read your age");
}