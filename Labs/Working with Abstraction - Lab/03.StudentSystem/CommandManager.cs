using System;
using System.Collections.Generic;

public class CommandManager
{
    private StudentSystem studentSystems;
    private Dictionary<string, Student> repository;

    public CommandManager()
    {
        this.studentSystems = new StudentSystem();
        this.repository = studentSystems.Repository;
    }

    public bool ParseCommand()
    {
        string[] args = Console.ReadLine().Split();

        if (args[0] == "Create")
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            if (!repository.ContainsKey(name))
            {
                repository[name] = new Student(name, age, grade);
            }
        }
        else if (args[0] == "Show")
        {
            var name = args[1];
            if (repository.ContainsKey(name))
            {
                var student = repository[name];
                string view = $"{student.Name} is {student.Age} years old.";

                if (student.Grade >= 5.00)
                {
                    view += " Excellent student.";
                }
                else if (student.Grade < 5.00 && student.Grade >= 3.50)
                {
                    view += " Average student.";
                }
                else
                {
                    view += " Very nice person.";
                }

                Console.WriteLine(view);
            }

        }
        else if (args[0] == "Exit")
        {
            return true;
        }

        return false;
    }
}