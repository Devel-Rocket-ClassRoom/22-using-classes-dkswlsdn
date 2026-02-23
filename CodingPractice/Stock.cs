using System;
using System.Collections.Generic;
using System.Text;

public class Stock
{
    private decimal currentPrice;

    public decimal CurrentPrice
    {
        get { return currentPrice; }
        set { currentPrice = value; }
    }
}