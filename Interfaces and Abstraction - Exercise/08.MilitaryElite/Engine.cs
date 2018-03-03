using System;
using System.Collections.Generic;
using System.Text;

public class Engine : IEngine
{
    private ISoldierFactory soldierFactory;

    public Engine()
    {
        SoldierFactory = new SoldierFactory();
    }

    public ISoldierFactory SoldierFactory
    {
        get => soldierFactory;
        private set => soldierFactory = value;
    }

    public void Run()
    {
        var sb = new StringBuilder();
        var soldiers = new Dictionary<int, IPrivate>();
        while (true)
        {
            var input = Console.ReadLine();
            if ("End" == input)
            {
                break;
            }

            
            var tokens = input.Trim().Split();
            var soldierType = tokens[0];
            var id = int.Parse(tokens[1]);
            var firstName = tokens[2];
            var lastName = tokens[3];
            
            switch (soldierType)
            {
                case "Private":
                    var salary = double.Parse(tokens[4]);
                    IPrivate soldier =  SoldierFactory.CreatePrivate(id, firstName, lastName, salary);
                    if (!soldiers.ContainsKey(id))
                    {
                        soldiers[id] = soldier;
                    }
                    sb.AppendLine(soldier.ToString());
                    break;
                case "LeutenantGeneral":
                    salary = double.Parse(tokens[4]);
                    ILeutenantGeneral leutenantGeneral = SoldierFactory.CreateLeutenantGeneral(id, firstName, lastName, salary);
                    if (tokens.Length > 5)
                    {
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            var targetId = int.Parse(tokens[i]);
                            if (soldiers.ContainsKey(targetId))
                            {
                                leutenantGeneral.AddPrivate(targetId, soldiers[targetId]);
                            }
                        }
                    }
                    sb.AppendLine(leutenantGeneral.ToString());
                    break;
                case "Engineer":
                    salary = double.Parse(tokens[4]);
                    var corps = tokens[5];
                    try
                    {
                        IEngineer engineer = SoldierFactory.CreateEngineer(id, firstName, lastName, salary, corps);
                        if (tokens.Length > 6)
                        {
                            for (int index = 6; index < tokens.Length; index += 2)
                            {
                                var repairPart = tokens[index];
                                var repairHours = int.Parse(tokens[index + 1]);
                                IRepair repair = new Repair(repairPart, repairHours);
                                engineer.AddRepair(repair);
                            }
                        }
                        sb.AppendLine(engineer.ToString());
                    }
                    catch (ArgumentException ae){}
                    break;
                case "Commando":
                    salary = double.Parse(tokens[4]);
                    corps = tokens[5];
                    try
                    {
                        ICommando commando = SoldierFactory.CreateCommando(id, firstName, lastName, salary, corps);
                        if (tokens.Length > 6)
                        {
                            for (int index = 6; index < tokens.Length; index += 2)
                            {
                                var codeName = tokens[index];
                                var state = tokens[index + 1];
                                try
                                {
                                    IMission mission = new Mission(codeName, state);
                                    commando.AddMission(mission);
                                }
                                catch (ArgumentException ae){}
                            }
                        }

                        sb.AppendLine(commando.ToString());
                    }
                    catch (ArgumentException ae){}
                    break;
                case "Spy":
                    var code = int.Parse(tokens[4]);
                    ISpy spy = SoldierFactory.CreateSpy(id, firstName, lastName, code);
                    sb.AppendLine(spy.ToString());
                    break;
            }
        }

        Console.WriteLine(sb.ToString());
    }
}