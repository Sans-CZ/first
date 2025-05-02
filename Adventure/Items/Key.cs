using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    internal class Key : BaseItem
    {
        public override string Name => "Key";

        public override string Description => "Used to open doors";

        public override int Weight => 0;

        public override void Use(World world)
        {
            var room = world.CurrentRoom.neighbours.
                Find(r => r.Name == "Crossroad");
                room.Locked = false;
        }
        public override Usability IsUsable { get; } = Usability.Inv;
    }
}
