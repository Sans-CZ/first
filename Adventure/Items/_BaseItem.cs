using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Items
{
    public abstract class BaseItem
    {
        public abstract string Name { get; }
        public abstract string Description { get; }
    }
}
