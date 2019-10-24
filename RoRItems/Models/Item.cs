using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoRItems.Models
{
    public class Item
    { 
        public string Description { get; set; }
        public string Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Rarity { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Item>(this);
        }
    }
}
