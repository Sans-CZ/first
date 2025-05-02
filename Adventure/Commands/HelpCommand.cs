using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class HelpCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.WriteLine("To interact with the game, use following commands ...");
            AnsiConsole.WriteLine("---");
            AnsiConsole.WriteLine("look - looks around the room");

            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("help - shows this help");
            AnsiConsole.WriteLine("quit - exits the game");
            AnsiConsole.WriteLine("test - tests the command");
            AnsiConsole.WriteLine("go - goes to a room");
            AnsiConsole.WriteLine("pickup - picks up an item");
            AnsiConsole.WriteLine("inv - shows your inventory");
            AnsiConsole.WriteLine("use - uses an item");
        }
    }
}
