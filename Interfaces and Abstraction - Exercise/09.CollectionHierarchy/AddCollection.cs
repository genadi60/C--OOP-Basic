using System.Collections.Generic;

class AddCollection : IAddToEnd
{
	private List<string> collectionOfStrings;

	public AddCollection()
	{
		CollectionOfStrings = new List<string>();
	}

	public List<string> CollectionOfStrings { get; private set; }

	public string AddToEnd(string item)
	{
		var index = CollectionOfStrings.Count;
		CollectionOfStrings.Add(item);
		return index.ToString();
	}
}