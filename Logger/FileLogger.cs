using System;
using System.IO;

namespace Logger;

public class FileLogger : BaseLogger
{
    public string FilePath { get; }
    public FileLogger (string filePath)
	{
        this.FilePath = filePath;
  
	}

    public override void Log(LogLevel logLevel, string? message)
    {
        message = message ?? throw new ArgumentNullException(nameof(message));
        string path;
        path = FilePath;
        DateTime date = DateTime.Now;
        string appendText = date + "FilePath" + logLevel + ":" + message +  Environment.NewLine;
        File.AppendAllText(path, appendText);

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }
    }
}
