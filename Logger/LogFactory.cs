namespace Logger
{
    public class LogFactory
    {
        public BaseLogger? CreateLogger()
        { 
            if (FilePath == null)
            {
                {
                   
                };
                return null;
            }
            else
            {
                BaseLogger baseLogger = new FileLogger(FilePath)
                {
                    ClassName = nameof(FileLogger),

                };
                return baseLogger;
            }
            

        }
        public void ConfigureFileLogger(string? filePath) 
        { 
        this.FilePath = filePath;
            
        }
        private string? FilePath { get; set; }
    }
}
