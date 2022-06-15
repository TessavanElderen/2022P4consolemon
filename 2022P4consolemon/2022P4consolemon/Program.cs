using System;
using ConsoleMonsters.Loaders;


namespace ConsoleMon
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMonFactory consoleMonFactory = new ConsoleMonFactory();
            ConsoleMonArena consoleMonArena = new ConsoleMonArena();

            consoleMonFactory.Load();    

            ConsoleMon a = consoleMonFactory.Make("EnterMon");
            ConsoleMon b = consoleMonFactory.Make("NewLineMon");

            consoleMonArena.DoBattle(a, b);

        }
    }
}
