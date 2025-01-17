using Adventure.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Rooms
{
    public abstract class BaseRoom
    {
        protected List<BaseRoom> neighbours = new List<BaseRoom>();

        protected List<BaseItem> items = new List<BaseItem>();

        public abstract string Name { get; }
        public abstract string Description { get; }

        public void RegisterNeighbour(BaseRoom room)
        {
            neighbours.Add(room);
        }
        public void AddItem(BaseItem item) 
        {
            items.Add(item);    
        }
        public void RemoveItem(BaseItem item) 
        {
            items.Remove(item); 
        }
    }
}
