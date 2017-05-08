using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInteractions
{
    class BurnStateCases
    {
        public static string VaporiseBurnCase(Item item)
        {
            item.State = "gass";
            return item.Name + " vaporised into " + item.State + ".";
        }

        public static string SolidBurnCase(Item item)
        {
            item.State = "ash";
            return item.Name + " burned into " + item.State + ".";
        }
        
        public static string NormalBurnCase(Item item)
        {
            item.State = "flames";
            return item.Name + " burned into " + item.State + ".";
        }

        public static string AlternativeBurnCase(Item item)
        {

            return item.Name + " still " + item.ItemMaterial.BurnReaction + ".";
        }
    }
}
