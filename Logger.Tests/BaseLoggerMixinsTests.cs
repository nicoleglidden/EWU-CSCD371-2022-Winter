using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Logger.Tests
{
    [TestClass]
    public class BaseLoggerMixinsTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]

        public void Error_WithNullLogger_ThrowsException()
        {
            // Arrange
            var logger = new TestLogger();

            // Act
            BaseLoggerMixins.Error(logger, null!);
            // Assert
        }
            
        [TestMethod]
        public void Error_WithData_LogsMessage()
        {
            var logger = new TestLogger();

            logger.Error("Message {0}", 42);

            Assert.AreEqual(1, logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Error, logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Warning_WithNullMessage_ThrowsException()
        {
            var logger = new TestLogger();

            BaseLoggerMixins.Warning(logger, null!);
        }

        [TestMethod]
        public void Warning_WithData_LogsMessage()
        {
            var logger = new TestLogger();

            logger.Warning("Message {0}", 42);

            Assert.AreEqual(1, logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Warning, logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
        }

        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Information_WithNullMessage_ThrowsException()
        {
            var logger = new TestLogger();

            BaseLoggerMixins.Information(logger, null!);
        }

        [TestMethod]
        public void Information_WithData_LogsMessage()
        {
            var logger = new TestLogger();

            logger.Information("Message {0}", 42);

            Assert.AreEqual(1, logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Information, logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Debug_WithNullMessage_ThrowsException()
        {
            var logger = new TestLogger();

            BaseLoggerMixins.Debug(logger, null!);

            // Assert
        }

        [TestMethod]
        public void Debug_WithData_LogsMessage()
        {
            var logger = new TestLogger();

            logger.Debug("Message {0}", 42);

            Assert.AreEqual(1, logger.LoggedMessages.Count);
            Assert.AreEqual(LogLevel.Debug, logger.LoggedMessages[0].LogLevel);
            Assert.AreEqual("Message 42", logger.LoggedMessages[0].Message);
        }
    }

    public class TestLogger : BaseLogger
    {
        public List<(LogLevel LogLevel, string Message)> LoggedMessages { get; } = new List<(LogLevel, string)>();

        public override void Log(LogLevel logLevel, string message)
        {
            LoggedMessages.Add((logLevel, message));
        }
    }
}
