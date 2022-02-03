using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester : IJokeService
    {
        public string GetJoke()


        {
            JokeService jokeService = new JokeService();
            string joke = jokeService.GetJoke();
            return joke;
        }

        public bool TellJoke()
        {
            string joke = GetJoke();
            if (joke == null)
            {
                return false;
            }
            else
            {

            }
            Console.WriteLine(joke);
            
            
            JokeOutput jokeOutput = new JokeOutput();
            string? text = jokeOutput.TellJoke();
            return text;
        }
    }
}
