public class Repair : IRepair
{
    private string partName;
    private int hoursWorked;

    public Repair(string partName, int hoursWorked)
    {
        PartName = partName;
        HoursWorked = hoursWorked;
    }

    private string PartName
    {
        get => partName;
        set => partName = value;
    }

    private int HoursWorked
    {
        get => hoursWorked;
        set => hoursWorked = value;
    }

    public override string ToString()
    {
        return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}