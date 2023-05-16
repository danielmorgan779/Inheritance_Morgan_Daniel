using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Morgan_Daniel
{
    abstract class Game
    {

        /// <summary>
        /// Strings Esrb and Title with assigned parameters to the correct properties
        /// </summary>
        public string Esrb { get; set; }

        public string Title { get; set; }

        // A constructor that takes the string parameters esrb and title.
        public Game(string esrbParam, string titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title and says it's starting
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();

    }
}
