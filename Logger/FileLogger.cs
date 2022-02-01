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
        string path;
        path = FilePath;
        string appendText = "hikevin" + Environment.NewLine;
        File.AppendAllText(path, appendText);

    }
}
