using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public class Crossroad : BaseRoom
    {
        public override string Name => "Crossroad";

        public override string Description => "There are multiple doors ahead";

        public override bool Locked { get; set; } = true;

    }
}
