using System;

class HotelReservation
{
    static void Main()
    {
        var token = Console.ReadLine().Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries);
        var pricePerDay = decimal.Parse(token[0]);
        var daysNumber = int.Parse(token[1]);
        Enum season = null;
        
        switch (token[2])
        {
            case "Spring":
                season = Enums.Season.Spring;
                break;
            case "Summer":
                season = Enums.Season.Summer;
                break;
            case "Autumn":
                season = Enums.Season.Autumn;
                break;
            case "Winter":
                season = Enums.Season.Winter;
                break;
        }

        Enum discount = Enums.Discount.None;

        if (token.Length == 4)
        {
            switch (token[3])
            {
                case "VIP":
                    discount = Enums.Discount.VIP;
                    break;
                case "SecondVisit":
                    discount = Enums.Discount.SecondVisit;
                    break;
            }
        }
        var calculator = new PriceCalculator(pricePerDay, daysNumber, season, discount);
        Console.WriteLine(calculator);
    }
}