using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazFunny
{
    public class Jester
    {
        WriteJoke writejoke = new WriteJoke();

        IJokeService servicingWriteJoke = writejoke;
        servicingWriteJoke.JokeService(...);
        IJokeOutput jokeOutputWriteJoke = writejoke;
        jokeOutputWriteJoke.JokeOutput(...);


    }
}
