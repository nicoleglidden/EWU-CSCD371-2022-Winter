using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class JokeOutput : IJokeOutput
    {

        public void WriteJoke(string text)
        {
           if (string.IsNullOrWhiteSpace(text))
           {
                throw new ArgumentNullException($"{nameof(text)} cannot be null or whitespace.");

           }

            Console.WriteLine(text);
           

            
        }

    }
}
