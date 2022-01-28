using System;
using System.IO;

namespace Logger;

public class FileLogger : BaseLogger
{
	public FileLogger (string filePath)
	{
		
	}

    public override void Log(LogLevel logLevel, string message)
    {
        throw new NotImplementedException();
    }
}
