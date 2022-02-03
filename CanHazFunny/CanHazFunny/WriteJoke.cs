using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class WriteJoke : IJokeService, IJokeOutput
    {
        public void JokeOutput(Output output)
        {
            throw new NotImplementedException();
        }

        public void JokeService(Service service)
        {
            throw new NotImplementedException();
        }
    }
}
