using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.name = name;
        this.age = age;
        this.accounts = accounts;
    }

    public Person(string name, int age):this(name, age, new List<BankAccount>()){}

    public decimal GetBalance()
    {
        return this.accounts.Sum(x => x.Balance);
    }
}