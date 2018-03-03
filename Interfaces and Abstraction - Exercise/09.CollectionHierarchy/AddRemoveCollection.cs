using System.Collections.Generic;

public class AddRemoveCollection : IAddToStart, IRemoveFromEnd
{
	private List<string> collectionOfStrings;

	public AddRemoveCollection()
	{
		CollectionOfStrings = new List<string>();
	}

	public List<string> CollectionOfStrings { get; private set; }


	public string AddToStart(string item)
	{
		CollectionOfStrings.Insert(0, item);
		return "0";
	}

	public string RemoveFromEnd()
	{
		var index = CollectionOfStrings.Count - 1;
		var item = CollectionOfStrings[index];
		CollectionOfStrings.RemoveAt(index);
		return item;
	}
}