using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        public FileLogger(string className) : base(className)
        {
            public string FilePath { get; }
        }

        public override void Log(LogLevel logLevel, string message, string callingFile)
        {
            
        }

        public string 
    }
}
