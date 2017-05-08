using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInteractions
{
    class SinkStateCases
    {
        public static string LiquidSinkCase(Item item, Item Substance)
        {
            if (item.ItemMaterial.Name == Substance.ItemMaterial.Name)
            {
                double previousWeight = Substance.Weight;
                Substance.Weight = Substance.Weight + item.Weight;
                return Substance.Name + " (" + previousWeight + ") + " + item.Name + " (" + item.Weight + ") = " + Substance.Name + " (" + Substance.Weight + ").";
            }
            else if (item.ItemMaterial.Density > Substance.ItemMaterial.Density)
            {
                return item.Name + " will sink in " + Substance.Name + ".";
            }
            else
            {
                return item.Name + " will float in " + Substance.Name + ".";
            }
        }

        public static string SolidSinkCase(Item item, Item Substance)
        {
            return "You cannot sink into " + Substance.Name + " because it's not a liquid.";
        }
    }
}
