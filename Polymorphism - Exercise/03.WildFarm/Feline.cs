﻿public abstract class Feline : Mammal
{
	private string breed;

	protected Feline(string name, double weight, string livingRegion, string breed)
		: base(name, weight, livingRegion)
	{
		Breed = breed;
	}

	public string Breed { get => breed; private set => breed = value; }
}