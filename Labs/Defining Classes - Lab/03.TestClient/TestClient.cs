using System;
using System.Collections.Generic;

class TestClient
{
    private static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
    static void Main()
    {
        var input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            var userCommand = input.Split();
            var command = userCommand[0];
            switch (command)
            {
                case "Create":
                    Create(int.Parse(userCommand[1]));
                    break;
                case "Deposit":
                    Deposit(int.Parse(userCommand[1]), decimal.Parse(userCommand[2]));
                    break;
                case "Withdraw":
                    Withdraw(int.Parse(userCommand[1]), decimal.Parse(userCommand[2]));
                    break;
                case "Print":
                    Print(int.Parse(userCommand[1]));
                    break;
            }
        }
    }

    private static void Print(int id)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            Console.WriteLine(accounts[id]);
        }
    }

    private static void Withdraw(int id, decimal amount)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Withdraw(amount);
        }
    }

    private static void Deposit(int id, decimal amount)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            accounts[id].Deposit(amount);
        }
    }

    private static void Create(int id)
    {
        if (!accounts.ContainsKey(id))
        {
            accounts[id] = new BankAccount
            {
                Id = id
            };
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }
}