using System;


public class Engine : IEngine
{
	private InputReader reader;
	private OutputWriter writer;
	
	public Engine()
	{
		Reader = new InputReader();
		Writer = new OutputWriter();
	}

	public InputReader Reader
	{
		get => reader;
		set => reader = value;
	}
	public OutputWriter Writer
	{
		get => writer;
		set => writer = value;
	}
	

	public void Run()
	{
	    try
	    {
	        var pizzaName = Reader.ReadLine().Split()[1];

	        var pizza = new Pizza(pizzaName);

	        var doughData = Reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
	        var flourType = doughData[1];
	        var bakingTechnique = doughData[2];
	        var doughWeight = double.Parse(doughData[3]);

            var dough = new Dough(flourType, bakingTechnique, doughWeight);

	        pizza.Dough = dough;

	        while (true)
	        {
	            var input = Reader.ReadLine();
	            if ("END" == input)
	            {
	                break;
	            }

	            var tokens = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	            var modifier = tokens[1];
	            var toppingWeight = double.Parse(tokens[2]);

                var topping = new Topping(modifier,toppingWeight);

                pizza.AddTopping(topping);
            }
            Writer.WriteLine(pizza.ToString());
        }
	    catch (ArgumentException e)
	    {
	        Writer.WriteLine(e.Message);
	    }
    }
}