using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServiceTests
    {
        [TestMethod]
        public void JokeService_NullJoke_Wrong()
        {
            JokeService service = new JokeService();
            Assert.IsNotNull(service.GetJoke());
        }

    }
        
}
