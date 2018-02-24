using System;

public class PriceCalculator
{
    private decimal totalPrice;
    public PriceCalculator(decimal price, int days, Enum season, Enum discount)
    {
        var priceTemp = days * price * (int)(object)season;
        TotalPrice = priceTemp - ((priceTemp / 100m) * (int)(object)discount);
        Console.WriteLine();
    }

    public decimal TotalPrice
    {
        get => totalPrice;
        set => totalPrice = value;
    }

    public override string ToString()
    {
        return $"{TotalPrice:f2}";
    }
}