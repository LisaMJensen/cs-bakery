using System;
using BakeryItems;

class Bakery
{
    private static Bread breadOrdered = new Bread ();
    private static Pastry pastriesOrdered = new Pastry();
    private static int intOrderedLoaves { get; set; }
    private static int intOrderedPastries { get; set; }

    private static int OrderBread()
    {
        Console.WriteLine("How many loaves of bread? (Please enter a number)");
        string orderedLoaves = Console.ReadLine();

        int intOrderedLoaves = int.Parse(orderedLoaves);
        return intOrderedLoaves;
    }

    private static int OrderPastry()
    {
    Console.WriteLine("How many pastries? (Please enter a number)");
    string orderedPastries = Console.ReadLine();

    int intOrderedPastries = int.Parse(orderedPastries);
    return intOrderedPastries;
    }

    private static void CalculateTotalPrice(int intOrderedLoaves , int intOrderedPastries)
    {
        breadOrdered.AmountOrdered = intOrderedLoaves;
        pastriesOrdered.AmountOrdered = intOrderedPastries;

        breadOrdered.GetTotalPrice();
        pastriesOrdered.GetTotalPrice();
    }

    private static void DisplayUsersTotal()
    {
        int total = breadOrdered.FinalPrice + pastriesOrdered.FinalPrice;

        Console.WriteLine("Your total is:" );
        Console.WriteLine($" ${total}");
    }

    public static void Welcome()
    {
        Console.WriteLine("Welcome to Pierre's Bakery!");
        Console.WriteLine("Menu:");
        Console.WriteLine("Loaf of Bread - $5   OR   Buy two, get one free");
        Console.WriteLine("Pastry - $2   OR   Three for $5");

    }

    public static void Main()
    {
        Welcome();
        Console.WriteLine("Would you like to make a purchase? (Y/N)");
        string answer = Console.ReadLine();
        if (answer == "Y" || answer == "y")
        {
            int OrderedLoaves = OrderBread();
            int OrderedPastry = OrderPastry();
            CalculateTotalPrice(OrderedLoaves , OrderedPastry);
            DisplayUsersTotal();
        }

    }
}
