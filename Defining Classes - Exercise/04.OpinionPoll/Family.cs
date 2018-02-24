using System.Collections.Generic;
using System.Linq;

public class Family
{
    private Dictionary<string, Person> members;

    public Family()
    {
        this.members = new Dictionary<string, Person>();
    }

    public Dictionary<string, Person> Members
    {
        get => members;
    }

    public void AddMember(Person member)
    {
        if (!this.members.ContainsKey(member.Name))
        {
            this.members[member.Name] = member;
        }
    }

    public Person GetOldestMember()
    {
        Person person = null;
        foreach (KeyValuePair<string, Person> kvp in members.OrderByDescending(x => x.Value.Age))
        {
             person = kvp.Value;
            break;
        }

        return person;
    }
}