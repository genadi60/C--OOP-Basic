public interface ISoldierFactory
{
    IPrivate CreatePrivate(int id, string firstName, string lastName, double salary);

    ILeutenantGeneral CreateLeutenantGeneral(int id, string firstName, string lastName, double salary);

    IEngineer CreateEngineer(int id, string firstName, string lastName, double salary, string corps);

    ICommando CreateCommando(int id, string firstName, string lastName, double salary, string corps);

    ISpy CreateSpy(int id, string firstName, string lastName, int code);
}