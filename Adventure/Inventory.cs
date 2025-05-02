using Adventure.Items;
using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Adventure
{
    public class Inventory
    {
        public List<BaseItem> Items = new List<BaseItem>();

        public bool AddItem(BaseItem item)
        {
            if (Items.Sum(x => x.Weight)+item.Weight>MaxCapacity) 
            {
                AnsiConsole.MarkupLine("[red] You can't carry more stuff[/]");
                return false;
            }
            Items.Add(item);
            return true;
        }
        public void RemoveItem(BaseItem item)
        {
            Items.Remove(item);
        }
        public int MaxCapacity => 20;
    }
}