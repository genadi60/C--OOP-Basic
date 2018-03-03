using System;
using System.Text;

class CollectionHierarchy
{
    static void Main()
    {
		var collection = Console.ReadLine().Split();
		var removesCount = int.Parse(Console.ReadLine());
		AddCollection addCollection = new AddCollection();
		AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
		MyList myList = new MyList();

		var sb1 = new StringBuilder();
		var sb2 = new StringBuilder();
		var sb3 = new StringBuilder();

		for (int index = 0; index < collection.Length; index++)
		{
			sb1.Append(addCollection.AddToEnd(collection[index])).Append(" ");
			sb2.Append(addRemoveCollection.AddToStart(collection[index])).Append(" ");
			sb3.Append(myList.AddToStart(collection[index])).Append(" ");
		}

		Console.WriteLine(sb1.ToString().Trim());
		Console.WriteLine(sb2.ToString().Trim());
		Console.WriteLine(sb3.ToString().Trim());

		sb1.Clear();
		sb2.Clear();
		
		for (int index = 0; index < removesCount; index++)
		{
			sb1.Append(addRemoveCollection.RemoveFromEnd()).Append(" ");
			sb2.Append(myList.RemoveFromStart()).Append(" ");
		}

		Console.WriteLine(sb1.ToString().Trim());
		Console.WriteLine(sb2.ToString().Trim());
	}
}