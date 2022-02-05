using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeOutputTests
    {
        [TestMethod]

        public void JokeOutput_WriteJoke_NullJoke_ThrowsException()
        {
            JokeOutput output = new JokeOutput();
            output.WriteJoke();


        }
    }
}
    
