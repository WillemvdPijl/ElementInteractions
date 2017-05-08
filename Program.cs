using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInteractions
{
    class Program
    { 

        public static string SinkController(Item item, Item Substance)
        {
            if (Substance.State == "liquid")
            {
                // Sinking calculation:
                return SinkStateCases.LiquidSinkCase(item, Substance);
            }
            else
            {
                return SinkStateCases.SolidSinkCase(item, Substance);
            }
        }

        public static string BurnController(Item item)
        {
            Console.WriteLine(item.Name + " " + item.ItemMaterial.BurnReaction + ".");
            if (item.ItemMaterial.BurnReaction == "vaporises")
            {
                return BurnStateCases.VaporiseBurnCase(item);
            }
            else if (item.ItemMaterial.BurnReaction == "burns" && item.State == "solid")
            {
                return BurnStateCases.SolidBurnCase(item);
            }
            else if (item.ItemMaterial.BurnReaction == "burns")
            {
                return BurnStateCases.NormalBurnCase(item);
                
            }
            else
            {
                return BurnStateCases.AlternativeBurnCase(item);
            }
        }

        static void Main(string[] args)
        {   
            // Creating the Materials
            Material stone = new Material("Stone", 2.55, "does nothing", false);
            Material wood = new Material("Wood", 0.75, "burns", false);
            Material iron = new Material("Iron", 7.87, "glows red", true);
            Material water = new Material("Water", 1, "vaporises", true);
            Material mercury = new Material("Mercury", 13.53, "burns", true);
            Material glass = new Material("Glass", 2.55, "shatters", false);

            // Creating the Items
            Item littleRock = new Item("Little rock", stone, 0.3, "solid");
            Item plank = new Item("Plank", wood, 5, "solid");
            Item masterSword = new Item("Master Sword", iron, 2, "solid");
            Item amountOfWater = new Item("Water", water, 1, "liquid");
            Item amountOfMercury = new Item("Mercury", mercury, 4, "liquid");
            Item mirror = new Item("Mirror", glass, 10, "solid");

            //Sinking substances
            Item SinkingSubstanceWater = new Item("Water", water, 700, "liquid");
            Item SinkingSubstanceMercury = new Item("Mercury", mercury, 4, "liquid");

            // Doing the interactions
            /*
            Console.WriteLine(masterSword.Details());
            Console.WriteLine(glass.Details());
            Console.WriteLine(masterSword.Name);
            Console.WriteLine(masterSword.ItemMaterial.Name);
            Console.WriteLine(BurnController(amountOfWater));
            Console.WriteLine(BurnController(plank));
            Console.WriteLine(BurnController(amountOfMercury));
            Console.WriteLine(SinkController(amountOfWater, SinkingSubstanceWater));
            Console.WriteLine(SinkController(mirror, SinkingSubstanceWater));
            Console.WriteLine(SinkController(littleRock, SinkingSubstanceMercury));
            Console.WriteLine(SinkController(littleRock, SinkingSubstanceWater));
            */

            Console.WriteLine(plank.State);
            Console.WriteLine(BurnController(plank));
            Console.WriteLine(plank.State);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
