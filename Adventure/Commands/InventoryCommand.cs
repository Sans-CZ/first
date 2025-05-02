using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class InventoryCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (world.Inventory.Items.Count == 0)
            {
                AnsiConsole.MarkupLine("[red]You don't have anything in your inventory![/]");
            }
            else
                AnsiConsole.MarkupLine($"Your inventory:\n[green]{string.Join("\n", world.Inventory.Items)}[/]");
           
        }
    }
}
