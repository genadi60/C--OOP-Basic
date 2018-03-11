using System;
using System.Collections.Generic;
using System.IO;
using BashSoft.Exceptions;
using BashSoft.StaticData;

namespace BashSoft.IO
{
    public class IOManager
    {
        public void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            var currentPath = SessionData.CurrentPath;
            int initialIdentation = currentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(currentPath);

            while (subFolders.Count != 0)
            {
                currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;
                if (depth - identation < 0)
                {
                    break;
                }

                try
                {
                    OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string('-', identation),
                        currentPath));
                    foreach (var directoryPath in Directory.GetDirectories(currentPath + "\\"))
                    {
                        subFolders.Enqueue(directoryPath);
                        var indexOfLastSlash = directoryPath.LastIndexOf("\\");
                        if (indexOfLastSlash < 0)
                        {
                            indexOfLastSlash = 0;
                        }
                        var directoryName = directoryPath.Substring(indexOfLastSlash);
                        OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash + identation) + directoryName);
                    }
                    
                    foreach (var file in Directory.GetFiles(currentPath + "\\"))
                    {
                        var indexOfLastSlash = file.LastIndexOf("\\");
                        if (indexOfLastSlash < 0)
                        {
                            indexOfLastSlash = 0;
                        }
                        var fileName = file.Substring(indexOfLastSlash);
                        OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash + identation) + fileName);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessExceptionMessage);

                    Console.ReadKey();
                }
            }
        }

        public void CreateDirectoryInCurrentFolder(string name)
        {
            var path = $"{SessionData.CurrentPath}\\{name}";
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException)
            {
                throw new InvalidFileNameException();
            }
        }

        public void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    var currentPath = SessionData.CurrentPath;
                    var indexOfLastSlash = currentPath.LastIndexOf("\\");
                    var newPath = currentPath.Substring(0, indexOfLastSlash);
                    SessionData.CurrentPath = newPath;
                }
                catch (ArgumentOutOfRangeException)
                {
                    //throw new ArgumentOutOfRangeException("indexOfLastSlash", ExceptionMessages.InvalidDestination);
                    throw new InvalidPathException();
                }
                
            }
            else
            {
                var currentPath = SessionData.CurrentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        public void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                throw new DirectoryNotFoundException();
                //OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                //return;
            }

            SessionData.CurrentPath = absolutePath;
        }
    }
}