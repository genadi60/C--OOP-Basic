public class Employee
{
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, decimal salary, string position, string department, string email, int age)
    { 
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
        this.email = email;
        this.age = age;
    }

    public decimal Salary
    {
        get => salary;
    }

    public override string ToString()
    {
        return $"{this.name} {this.salary:f2} {this.email} {this.age}";
    }
}
