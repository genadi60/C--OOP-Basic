public class Company
{
    private string name;
    private decimal salary;
    private string department;

    public Company(string name, string department, decimal salary)
    {
        this.name = name;
        this.salary = salary;
        this.department = department;
    }

    public override string ToString()
    {
        return $"{this.name} {this.department} {this.salary:f2}";
    }
}