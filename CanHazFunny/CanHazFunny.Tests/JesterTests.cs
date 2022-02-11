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

        public void JesterTests()
        {

        }
       
        

        public IJokeOutput JokeOutput { get; set; }
        public IJokeService JokeService { get; set; }

        public JesterTests(IJokeService inputJokeService, IJokeOutput inputJokeOutput)
        {
            JokeService = inputJokeService;
            JokeOutput = inputJokeOutput;
        }


        [TestMethod]
        public void TestingJesterService_GetJoke_ReturnsJoke()
        {
            IJokeService service = new TestingJokeService();
            service.GetJoke();
            string joke = "";

            JokeOutput.WriteJoke(joke);

            Assert.AreEqual(joke, service.GetJoke());


        }
        

        
        
    }
}
