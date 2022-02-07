using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester 
    {
        public IJokeOutput JokeOutput { get; set; }
        public IJokeService JokeService { get; set; }

        public Jester (IJokeService inputJokeService, IJokeOutput inputJokeOutput)
        {
            JokeService = inputJokeService;
            JokeOutput = inputJokeOutput;
        }

        public string TellJoke()
        {
            bool chuckNorrisJoke = false;
            string joke = "";
            
            while (chuckNorrisJoke)
            {
                joke = JokeService.GetJoke();
                chuckNorrisJoke = joke.Contains("Chuck Norris");
            }
            
            JokeOutput.WriteJoke(joke);
            
            return joke;

        }
    }
}
