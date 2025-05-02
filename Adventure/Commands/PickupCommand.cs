using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class PickupCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine("[red]You must write an item you want to pickup!![/]");
                return;
            }
            var item = world.CurrentRoom.items.FirstOrDefault(n => n.Name == @params[0]);
            if (item == null) 
            {
                AnsiConsole.MarkupLine("[red]You must write an existing item you want to pickup!![/]");
                return;
            }
            world.CurrentRoom.RemoveItem(item);

            var result = world.Inventory.AddItem(item);
            if (result)
            {
                AnsiConsole.MarkupLine($"[paleturquoise1]You picked up a {item.Name}![/]");
            }
        }
    }
}
