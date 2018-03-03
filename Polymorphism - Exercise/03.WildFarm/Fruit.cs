using System;

public class Fruit : Food
{
    public Fruit(int quantity)
        : base(quantity)
    {
    }

    public override Type GetTypeSubclassType()
    {
        return GetType();
    }
}