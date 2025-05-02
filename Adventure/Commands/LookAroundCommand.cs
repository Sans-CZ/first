using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class LookAroundCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            AnsiConsole.MarkupLine($"You looked around and see that you are in a [green]{world.CurrentRoom.Description}[/]");
            if (world.CurrentRoom.items.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]You did not find anything[/]");
            }
            else
            {
                AnsiConsole.MarkupLine($"You found a pickable [blue]{string.Join(",", world.CurrentRoom.items)}[/]");
            }
            AnsiConsole.MarkupLine($"You also see that you can go to [red]{string.Join(",", world.CurrentRoom.neighbours)}[/]");
        }
    }
}
