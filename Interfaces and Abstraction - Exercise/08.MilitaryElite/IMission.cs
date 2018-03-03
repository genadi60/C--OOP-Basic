using System.Reflection.Metadata;

public interface IMission
{

    string State { get; }
    void CompleteMission();
}