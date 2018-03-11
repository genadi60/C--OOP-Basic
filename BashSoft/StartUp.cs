using System;
using System.Text;
using BashSoft.IO;
using BashSoft.Judge;
using BashSoft.Repository;


namespace BashSoft
{
    class StartUp
    {
        public static void Main()
        {
            Tester tester = new Tester();
            IOManager ioManager = new IOManager();
            StudentsRepository repo = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());
            CommandInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            InputReader reader = new InputReader(currentInterpreter);
            reader.StartReadingCommands();
        }
    }
}