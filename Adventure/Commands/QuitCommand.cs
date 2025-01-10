using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class QuitCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.MarkupLine("[red]Exiting[/]");

            Environment.Exit(0);
        }
    }
}
