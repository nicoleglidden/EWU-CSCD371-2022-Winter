namespace CanHazFunny
{
    class Program
    {
        static void Main(string[] args)
        {
            new Jester(new JokeService(), new JokeOutput()).TellJoke();
            
            //Feel free to use your own setup here - this is just provided as an example
            //new Jester(new SomeReallyCoolOutputClass(), new SomeJokeServiceClass()).TellJoke();


        }
    }
}
