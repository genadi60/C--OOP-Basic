using System;
using System.Text.RegularExpressions;

public static class Validator
{
    public static void ValidatePhoneNumber(string phoneNumber)
    {
        var pattern = "\\D";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(phoneNumber);
        if (match.Success)
        {
            throw new ArgumentException("Invalid number!");
        }
    }

    public static void ValidateBrowser(string browser)
    {
        var pattern = "\\d";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(browser);
        if (match.Success)
        {
            throw new ArgumentException("Invalid URL!");
        }
    }
}