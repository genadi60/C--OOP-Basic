﻿using System;

public class BankAccount
{
    private int id;
    private decimal balance;

    public int Id
    {
        get => id;
        set => id = value;
    }

    public decimal Balance
    {
        get => balance;
        set => balance = value;
    }

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (this.Balance < amount)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            this.Balance -= amount;
        }
    }

    public override string ToString()
    {
        return $"Account ID{this.Id}, balance {this.Balance:f2}";
    }
}