using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BashSoft.Exceptions;
using BashSoft.Judge;
using BashSoft.Repository;

namespace BashSoft.IO.Commands
{
    class GetHelpCommand : Command
    {
        public GetHelpCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
            : base(input, data, judge, repository, inputOutputManager)
        {
        }


        public override void Execute()
        {
            if (this.Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.DisplayHelp();
        }

        private void DisplayHelp()
        {
            var allInputLines = File.ReadAllLines(@"newGetHelp.txt");
            for (int line = 0; line < allInputLines.Length; line++)
            {
                if (!String.IsNullOrEmpty(allInputLines[line]))
                {
                    OutputWriter.WriteMessageOnNewLine(allInputLines[line]);
                }
            }
        }
    }
}
