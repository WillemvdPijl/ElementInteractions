using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInteractions
{
    class Item
    {
        public string Name { get; set; }
        public Material ItemMaterial { get; set; }
        public double Weight { get; set; }
        public string State { get; set; }

        //Constructor
        public Item(string name, Material itemMaterial, double weight, string state)
        {
            Name = name;
            ItemMaterial = itemMaterial;
            Weight = weight; //in KG
            State = state.ToLower();
        }

        public string Details()
        {
            return "Item: " + Name + ", Material: " + ItemMaterial.Name + ", Weight: " + Weight.ToString() + "kg" + ", State: " + State + ".";
        }
    }
}
