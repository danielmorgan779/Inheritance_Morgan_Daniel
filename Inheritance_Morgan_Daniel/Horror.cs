using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Morgan_Daniel
{
    class Horror : Game
    {

        /// <summary>
        /// Two constructors that inherit from the base class
        /// </summary>
        /// <param name="esrbParam"></param>
        /// <param name="titleParam"></param>
        public Horror(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        /// <summary>
        /// A Describe method that returns a string that describes the game and includes the title and esrb
        /// </summary>
        /// <returns></returns>
        public override string Describe()
        {
            return $"{Title} is a Horror game rated {Esrb}!";
        }
    }
}
