using System;

namespace ZlozonoscLogger
{
    public enum LogType
    {
        Error,
        Information,
        Warning
    }
    public static class Logger
    {
        public static void LogMessage(string message, LogType type)
        {
            switch(type)
            {
                case LogType.Error:
                    DisplayMessage(string.Format("{0}: {1}", Constatns.LogTypeNames.Error, message), ConsoleColor.Red);
                    break;
                case LogType.Information:
                    DisplayMessage(string.Format("{0}: {1}", Constatns.LogTypeNames.Information, message), ConsoleColor.White);
                    break;
                case LogType.Warning:
                    DisplayMessage(string.Format("{0}: {1}", Constatns.LogTypeNames.Warning, message), ConsoleColor.Yellow);
                    break;
            }
        }

        private static void DisplayMessage(string message, ConsoleColor color)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
