using System;
namespace JokeAppDotNet6.Data
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; } = String.Empty;
        public string JokeAnswer { get; set; } = String.Empty;

        public Joke()
        {
        }
    }
}
