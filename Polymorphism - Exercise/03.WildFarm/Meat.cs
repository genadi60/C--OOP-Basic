using System;

public class Meat : Food
{
    public Meat(int quantity)
        : base(quantity)
    {
    }

    public override Type GetTypeSubclassType()
    {
        return GetType();
    }
}