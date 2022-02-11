using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net.Http;


namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        public class TestingJokeService : IJokeService
        {
            private HttpClient HttpClient { get; } = new();
            public string GetJoke()
            {
                string joke = "Why did the chicken cross the road?";
                return joke;
            }
        }

        public class TestingJokeOutput : IJokeOutput
        {
            public void WriteJoke(string joke)
            {
                Console.WriteLine(joke);
            }
        }

        public JesterTests()
        {

        }

        [TestMethod]
        public void TellJoke_WithJokeFromService_OutputsJoke()
        {
            IJokeService service = new TestingJokeService();
            service.GetJoke();
            string joke = "";

            IJokeOutput output = new TestingJokeOutput();
            output.WriteJoke(joke);

            Jester jester = new Jester(service, output);
            jester.TellJoke();
            

            Assert.AreEqual(joke, jester.TellJoke());


        }
        

        
        
    }
}
