public class Smartphone : IFunctionable
{
    public string GetCalling(string phoneNumber)
    {
        Validator.ValidatePhoneNumber(phoneNumber);
        return $"Calling... {phoneNumber}";
    }

    public string GetBrowsing(string browser)
    {
        Validator.ValidateBrowser(browser);
        return $"Browsing: {browser}!";
    }
}