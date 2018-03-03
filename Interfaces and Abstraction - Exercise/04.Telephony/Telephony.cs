using System;

class Telephony
{
    static void Main()
    {
        IFunctionable phone = new Smartphone();
        var phoneNumbers = Console.ReadLine().Split();
        foreach (var phoneNumber in phoneNumbers)
        {
            try
            {
                Console.WriteLine(phone.GetCalling(phoneNumber));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
        var browsers = Console.ReadLine().Split();
        foreach (var browser in browsers)
        {
            try
            {
                Console.WriteLine(phone.GetBrowsing(browser));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}