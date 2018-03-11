using System.IO;

namespace BashSoft.StaticData
{
    public static class SessionData
    {
        public static string currentPath = Directory.GetCurrentDirectory();

        public static string CurrentPath
        {
            get => currentPath;
            set => currentPath = value;
        }
    }
}