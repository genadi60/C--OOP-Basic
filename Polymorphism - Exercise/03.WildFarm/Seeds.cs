using System;

public class Seeds : Food
{
    public Seeds(int quantity)
        : base(quantity)
    {
    }

    public override Type GetTypeSubclassType()
    {
        return GetType();
    }
}