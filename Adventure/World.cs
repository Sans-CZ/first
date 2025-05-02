using Adventure.Rooms;
using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    public class World
    {
        public BaseRoom CurrentRoom { get; private set; }
        public Inventory Inventory { get; } = new();
        public World() 
        {
            var lobby = new Lobby();
            var corridor = new Corridor();
            var crossroad = new Crossroad();

            lobby.RegisterNeighbour(corridor);
            corridor.RegisterNeighbour(lobby);
            corridor.RegisterNeighbour(crossroad);
            crossroad.RegisterNeighbour(corridor);
            CurrentRoom = lobby;
        }
        public bool SwitchRoom(BaseRoom room)
        {
            if (room.Locked)
            {
                AnsiConsole.MarkupLine("[red]You can't go into a locked room[/]");
                return false;
            }
            CurrentRoom = room;
            return true;
        }

        public string Intro { get; } = @"
How did you end up here? You don't really know. Maybe you fell, maybe someone pushed you.
One thing is certain, you need to [red italic]GET OUT OF HERE![/]
";
    }
}
