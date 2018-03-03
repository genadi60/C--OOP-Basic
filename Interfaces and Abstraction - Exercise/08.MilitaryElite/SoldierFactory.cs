public class SoldierFactory : ISoldierFactory
{
    public IPrivate CreatePrivate(int id, string firstName, string lastName, double salary)
    {
        IPrivate soldier = new Private(id, firstName, lastName, salary);
        return soldier;
    }

    public ILeutenantGeneral CreateLeutenantGeneral(int id, string firstName, string lastName, double salary)
    {
        ILeutenantGeneral soldier = new LeutenantGeneral(id, firstName, lastName, salary);
        return soldier;
    }

    public IEngineer CreateEngineer(int id, string firstName, string lastName, double salary, string corps)
    {
        IEngineer soldier = new Engineer(id, firstName, lastName, salary, corps);
        return soldier;
    }

    public ICommando CreateCommando(int id, string firstName, string lastName, double salary, string corps)
    {
        ICommando soldier = new Commando(id, firstName, lastName, salary, corps);
        return soldier;
    }

    public ISpy CreateSpy(int id, string firstName, string lastName, int code)
    {
        ISpy soldier = new Spy(id, firstName, lastName, code);
        return soldier;
    }
}