using System.Collections.Generic;

public class MyList : IAddToStart, IRemoveFromStart
{
	private int used;

	private List<string> collectionOfStrings;

	public MyList()
	{
		CollectionOfStrings = new List<string>();
	}

	public List<string> CollectionOfStrings { get; set; }

	public int Used
	{
		get { return used; }
		private set { used = value; }
	}

	public string AddToStart(string item)
	{
		CollectionOfStrings.Insert(0, item);
		Used++;
		return "0";
	}

	public string RemoveFromStart()
	{
		var item = CollectionOfStrings[0];
		CollectionOfStrings.RemoveAt(0);
		Used--;
		return item;
	}
}