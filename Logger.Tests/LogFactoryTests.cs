using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_NullFilePath_ReturnsNullLogger()
        {
            string? filePath = null;


            LogFactory loggerfactory = new LogFactory();
            loggerfactory.ConfigureFileLogger(filePath);
            // baseLogger.Log();
            BaseLogger? baselogger = loggerfactory.CreateLogger();

            Assert.IsNull(baselogger);

        }

        [TestMethod]
        public void CreateLogger_FilePath_ReturnsLogger()
        {
            string filePath = string.Empty;

            LogFactory loggerfactory = new LogFactory();
            loggerfactory.ConfigureFileLogger(filePath);
            BaseLogger? baselogger = loggerfactory.CreateLogger();

            Assert.IsNotNull(baselogger);
        }
    }
}
