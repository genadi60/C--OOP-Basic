using System;

public class Mission : IMission
{
    private string codeName;
    private string state;

    public Mission(string codeName, string state)
    {
        CodeName = codeName;
        State = state;
    }

    private string CodeName
    {
        get => codeName;
        set => codeName = value;
    }

    public string State
    {
        get => state;
        private set
        {
            if (value != Constants.FINISHED && value != Constants.IN_PROGRESS)
            {
                throw new ArgumentException();
            }
            state = value;
        }
    }

    public void CompleteMission()
    {
        State = Constants.FINISHED;
    }

    public override string ToString()
    {
        return $"Code Name: {CodeName} State: {State}";
    }
}