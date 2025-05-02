using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    internal class Potion : BaseItem
    {
        public override string Name => "Potion";

        public override string Description => "It heals you";

        public override int Weight => 2;
    }
}
