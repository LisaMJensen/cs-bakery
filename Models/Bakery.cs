using System;
using System.Collections.Generic;

namespace BakeryItems
{

class Bread
{

    public int AmountOrdered { get; set; }
    public int Price { get; set; }

    public Bread()
    {
        AmountOrdered = 0;
        Price = 0;
    }
}

class Pastry
{
    public int AmountOrdered { get; set; }
    public int Price { get; set; }

    public Pastry()
    {
        AmountOrdered = 0;
        Price = 0;
    }

}
}
