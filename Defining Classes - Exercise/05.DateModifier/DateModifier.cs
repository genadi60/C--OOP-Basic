using System;

public class DateModifier
{
    private int dateDifference;
    public DateModifier(){}

    public void CalculateDifference(string firstDate, string secondDate)
    {
        var first = firstDate.Split();
        var second = secondDate.Split();

        var startDate = new DateTime(int.Parse(first[0]), int.Parse(first[1]), int.Parse(first[2]));
        var endDate = new DateTime(int.Parse(second[0]), int.Parse(second[1]), int.Parse(second[2]));
        this.dateDifference = Math.Abs(startDate.Subtract(endDate).Days);
    }

    public override string ToString()
    {
        return this.dateDifference.ToString();
    }
}