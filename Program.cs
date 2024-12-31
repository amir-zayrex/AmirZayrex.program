// See https://aka.ms/new-console-template for more information/

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("Please enter your username:");
        string username = Console.ReadLine();
        
        Console.WriteLine("Please enter your password:");
        string password = Console.ReadLine();

        Console.WriteLine("Please enter your email:");
        string email = Console.ReadLine();

        Console.WriteLine("Please enter your phone number:");
        string phoneNumber = Console.ReadLine();

        // Validate phone number length
        if (phoneNumber.Length == 11)
        {
            Console.WriteLine("Valid Count!");
        }
        else
        {
            Console.WriteLine("Invalid Count! It must be 11 digits long.");
        }
    }
}