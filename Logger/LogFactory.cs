namespace Logger
{
    public class LogFactory
    {
        public BaseLogger CreateLogger()
        {
            BaseLogger baseLogger = new FileLogger(string.Empty)
            {
                ClassName = nameof(FileLogger),
              
            };
            return baseLogger;

        }
        public void ConfigureFileLogger(string filePath) 
        { 
        this.FilePath = filePath;
            
        }
        private string? FilePath { get; set; }
    }
}
