using System;

namespace Inheritance_Morgan_Daniel
{
    class Program
    {
        /// <summary>
        /// Passes through title and esrb arguements, then it calls the are Describe method and PlayGame method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Horror myHorror = new Horror("E", "ZombCube");

            Console.WriteLine(myHorror.Describe());
            myHorror.PlayGame();

        }
    }
}
