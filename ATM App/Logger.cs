using System;
using System.Collections.Generic;
using System.IO;

public class Logger
{
    private readonly string logFolderPath;
    private List<string> logs;

    public Logger(string logFolderPath)
    {
        this.logFolderPath = logFolderPath;
        this.logs = new List<string>();
    }

    public void Log(string message)
    {
        string logEntry = $"{DateTime.Now} - {message}";
        logs.Add(logEntry);
    }

    public void PrintLogs()
    {
        string logFileName = $"{DateTime.Now:dd-MM-yyyy}.txt";
        string logFilePath = Path.Combine(logFolderPath, logFileName);

        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            foreach (string logEntry in logs)
            {
                Console.WriteLine(logEntry);
                writer.WriteLine(logEntry);
            }
        }
    }
}