using System;
using BashSoft.StaticData;

namespace BashSoft.IO
{
    public class InputReader
    {
        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            while (true)
            {
                OutputWriter.WriteMessage($"{SessionData.CurrentPath} > ");
                var input = Console.ReadLine().Trim();

                if ("quit".Equals(input))
                {
                    break;
                }
                this.interpreter.InterpredCommand(input);
            }
        }
    }
}