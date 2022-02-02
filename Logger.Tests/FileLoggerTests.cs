using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]

        public void Log_Call_AppendsTextToFile()
        {
            string path = "keviniskindofcool.txt";
            
            FileLogger logger = new FileLogger(path);
            logger.Log(LogLevel.Information,  "hikevin");
            string[] readText = File.ReadAllLines(path);
            string lastline = readText[readText.Length - 4];
            
           bool doescontain = lastline.Contains("hikevin");
           Assert.IsTrue(doescontain);

        }


    }
}
