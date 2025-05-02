using Spectre.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Commands
{
    public class UseCommand : BaseCommand
    {
        public override void Execute(World world, params string[] @params)
        {
            if (!@params.Any())
            {
                AnsiConsole.MarkupLine("[red]You must write an item you want to use!![/]");
                return;
            }
            var item = world.Inventory.Items.Find(i => i.Name == @params[0]);
            
            if (item != null && item.IsUsable == Items.Usability.Inv)
            {
                item.Use(world);
                AnsiConsole.MarkupLine($"[blue]you used a {@params[0]}[/]");
                return;
            }
            item = world.CurrentRoom.items.Find(i => i.Name == @params[0]);
            if (item != null && item.IsUsable == Items.Usability.Room)
            {
                item.Use(world);
                AnsiConsole.MarkupLine($"[blue]you used a {@params[0]}[/]");
                
                return;
            }
            if (item == null) 
            {
                AnsiConsole.MarkupLine("[red]You can't use any item here!!");
            }
        }
    }
}
