using System.Collections.Generic;

public class Car
{
    private string model;
    private Engine engine;
    private List<Tire> tires;
    private Cargo cargo;

    public Car(string model, Engine engine, List<Tire> tires, Cargo cargo)
    {
        this.model = model;
        this.engine = engine;
        this.tires = tires;
        this.cargo = cargo;
    }

    public Engine Engine
    {
        get => engine;
    }

    public List<Tire> Tires
    {
        get => tires;
    }

    public Cargo Cargo
    {
        get => cargo;
    }

    public override string ToString()
    {
        return this.model;
    }
}