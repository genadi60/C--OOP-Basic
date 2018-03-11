using System;
using System.IO;
using BashSoft.IO;
using BashSoft.StaticData;

namespace BashSoft.Judge
{
    public class Tester
    {
        public void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            try
            {
                OutputWriter.WriteMessageOnNewLine("Reading files...");

                var mismatchPath = this.GetMismatchPath(expectedOutputPath);

                var actualOutputLines = File.ReadAllLines(userOutputPath);
                var expectedOutputLines = File.ReadAllLines(expectedOutputPath);

                bool hasMismatch;
                var mismatches = this.GetLinesWithPossibleMismatches(actualOutputLines, expectedOutputLines, out hasMismatch);

                this.PrintOutput(mismatches, hasMismatch, mismatchPath);
                OutputWriter.WriteMessageOnNewLine("Files read!");
            }
            catch (IOException ioe)
            {
                OutputWriter.DisplayException(ioe.Message);
            }
        }

        private string GetMismatchPath(string expectedOutputPath)
        {
            var indexOf = expectedOutputPath.LastIndexOf('\\');
            if (indexOf < 0)
            {
                indexOf = 0;
            }
            var directoryPath = expectedOutputPath.Substring(0, indexOf);
            var finalPath = directoryPath + @"Mismatches.txt";
            return finalPath;
        }

        private string[] GetLinesWithPossibleMismatches(string[] actualOutputLines,
            string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            var output = String.Empty;

            string[] mismatches = new string[actualOutputLines.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            var minOutputLines = actualOutputLines.Length;
            if (minOutputLines != expectedOutputLines.Length)
            {
                hasMismatch = true;
                minOutputLines = minOutputLines < expectedOutputLines.Length
                    ? minOutputLines
                    : expectedOutputLines.Length;
                OutputWriter.DisplayException(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
            }

            for (int index = 0; index < minOutputLines; index++)
            {
                var actualLine = actualOutputLines[index];
                var expectedLine = expectedOutputLines[index];

                if (!actualLine.Equals(expectedLine))
                {
                    output = String.Format("Mismatch at line {0} -- expected: \"{1}\", actual: \"{2}\"", index, expectedLine, actualLine);
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                }
                output += Environment.NewLine;
                mismatches[index] = output;
            }

            return mismatches;
        }

        private void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }

                File.WriteAllLines(mismatchesPath, mismatches);
                
                return;
            }
            OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
        }
    }
}