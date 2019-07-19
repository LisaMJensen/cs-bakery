using System;

class Bakery
{
    public static void OrderGoods()
    {
        Console.WriteLine("Would you like to make a purchase? (Y/N)");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        Console.WriteLine("How many loaves of bread? (Please enter a number)");
        string orderedLoaves = Console.ReadLine();
        Console.WriteLine("How many pastries? (Please enter a number)");
        string orderedPastries = Console.ReadLine();
    }
}

    public static void Main()
    {
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Menu:");
        Console.WriteLine("Loaf of Bread - $5   OR   Buy two, get one free");
        Console.WriteLine("Pastry - $2   OR   Three for $5");

        OrderGoods();
    }
}
