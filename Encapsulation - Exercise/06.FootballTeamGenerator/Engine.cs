using System;
using System.Linq;
using System.Text;

public class Engine : IEngine
{
	private InputReader reader;
	private OutputWriter writer;
	private IController controller;
	
	public Engine(InputReader reader, OutputWriter writer)
	{
		Reader = reader;
		Writer = writer;
		Controller = new Controller(reader, writer);
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
	public IController Controller
	{
		get => controller;
		set => controller = value;
	}

	public void Run()
	{
	    var sb = new StringBuilder();
        while (true)
		{
			var input = Reader.ReadLine();
			if ("END" == input)
			{
				break;
			}

			var inputData = input.Trim().Split(new string[] { ";" }, System.StringSplitOptions.RemoveEmptyEntries).ToArray();
			var command = inputData[0];
		    
			switch (command)
			{
				case "Team":
                    Controller.CreateTeam(inputData);
					break;

				case "Add":
					try
					{
					    Controller.AddPlayer(inputData);
                    }
					catch (Exception e)
					{
					    sb.AppendLine(e.Message);
					}
                    break;

				case "Remove":
					try
					{
					    Controller.RemovePlayer(inputData);
                    }
					catch (Exception e)
					{
					    sb.AppendLine(e.Message);
					}
                    break;

				case "Rating":
				    try
				    {
                        sb.AppendLine(Controller.RatingTeam(inputData));
				    }
				    catch (Exception e)
				    {
				        sb.AppendLine(e.Message);
				    }
				    break;
            }
		}
        Writer.WriteLine(sb.ToString().Trim());
	}
}