using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> repository;

    public StudentSystem()
    {
        this.Repository = new Dictionary<string, Student>();
    }

    public Dictionary<string, Student> Repository
    {
        get => repository;
        set => repository = value;
    }
}