using System;
using System.Collections.Generic;

namespace BakeryItems
{

class Bread
{

    public int AmountOrdered { get; set; }
    public int Price { get; set; }
    public int FinalPrice { get; set; }
    public int preDiscount { get; set; }

    public Bread()
    {
        AmountOrdered = 0;
        Price = 0;
        FinalPrice = 0;
        preDiscount = 0;
    }

    public void GetTotalPrice()
    {
        int preDiscount = AmountOrdered / 3;
        FinalPrice = (AmountOrdered - preDiscount) * 5;
    }
}

class Pastry
{
    public int AmountOrdered { get; set; }
    public int Price { get; set; }
    public int FinalPrice { get; set; }
    public int normalPrice { get; set; }
    public int discountPrice { get; set; }

    public Pastry()
    {
        AmountOrdered = 0;
        discountPrice = 0;
        normalPrice = 0;
        FinalPrice = 0;
    }

    public void GetTotalPrice()
    {
        int discountPrice = AmountOrdered / 3;
        int normalPrice = AmountOrdered % 3;
        FinalPrice = (discountPrice * 5) + (normalPrice * 2);
    }

}
}
