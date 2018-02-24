using System;

public class Child : Person
{
    public Child(string name, int age) : base(name, age)
    {
    }

    //public override string Name
    //{
    //    get => base.Name; 
    //    set
    //    {
    //        if (value.Length < 3)
    //        {
    //            throw new ArgumentException("Name's length should not be less than 3!");
    //        }

    //        base.Name = value;
    //    }
    //}

    public override int Age
    {
        get => base.Age;
        set
        {
            if (value >= 15)
            {
               throw new ArgumentException("Child's age must be less than 15!");
            }

            base.Age = value;
        }
    }
}