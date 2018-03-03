using System;

public class Vegetable : Food
{
    public Vegetable(int quantity)
        : base(quantity)
    {
    }

    public override Type GetTypeSubclassType()
    {
        return GetType();
    }
}