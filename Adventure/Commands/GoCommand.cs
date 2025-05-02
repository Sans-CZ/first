using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class GoCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine("[red]You must write a room where you want to go!![/]");
                return;
            }
            var room = world.CurrentRoom.neighbours.FirstOrDefault(n => n.Name == @params[0]);
            if (room == null) 
            {
                AnsiConsole.MarkupLine("[red]You must write a neighbouring room!![/]");
                return;
            }
            

            if (room.Locked)
            {
                AnsiConsole.MarkupLine("[red]You can't go into a locked room[/]");
                AnsiConsole.MarkupLine("[red]You must use a key[/]");
            }
            else
            {
                world.SwitchRoom(room);
                AnsiConsole.MarkupLine($"[paleturquoise1]You walked into a {room.Name}![/]");
                
            }
            
        }
    }
}
