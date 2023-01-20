﻿using ConsoleUI;

Console.WriteLine("Welcome to my application!");

//Ask for user information
Person user = new Person();

Console.Write("What is your first name: ");
user.FirstName = Console.ReadLine();

Console.Write("What is your last name: ");
user.LastName = Console.ReadLine();

//Checks to be sure the first and last name are valid
if (string.IsNullOrEmpty(user.FirstName))
{
    Console.WriteLine("You did not give us a valid first name!");
    Console.ReadLine();
    return;
}

if (string.IsNullOrEmpty(user.LastName))
{
    Console.WriteLine("You did not give us a valid last name!");
    Console.ReadLine();
    return;
}

//Create a username for the person
Console.WriteLine($"Your username is { user.FirstName.Substring(0,1) }{ user.LastName }");

Console.ReadLine();