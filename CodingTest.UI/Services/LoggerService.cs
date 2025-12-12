using System;
using System.IO;

namespace CodingTest.UI.Services
{
    public class LoggerService
    {
        private readonly string _logFilePath;

        public LoggerService()
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            _logFilePath = Path.Combine(desktop, "CodingTest_Log.txt");
        }

        /// <summary>
        /// Writes error messages into a log file on the Desktop.
        /// </summary>
        public void LogError(string message)
        {
            try
            {
                File.AppendAllText(_logFilePath,
                    $"{DateTime.Now}: {message}{Environment.NewLine}");
            }
            catch
            {
                // If logging fails, we silently continue.
            }
        }
    }
}
