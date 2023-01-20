﻿namespace ConsoleUI
{
    internal class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            //Create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
