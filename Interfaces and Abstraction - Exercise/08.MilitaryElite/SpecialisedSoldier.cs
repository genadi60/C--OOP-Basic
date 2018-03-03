using System;

public class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    private string corps;

    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary)
    {
        Corps = corps;
    }

    public string Corps
    {
        get => corps;
        private set
        {
            if (value != Constants.AIRFORCES && value != Constants.MARINES)
            {
                throw new ArgumentException();
            }

            corps = value;
        }
    }
}