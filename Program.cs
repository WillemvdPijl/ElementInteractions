using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInteractions
{
    class Program
    {
        public static string Sinking(Item item, Item Substance)
        {   
            //Is it a fluid?
            if(Substance.State == "liquid") {
                // Sinking calculation:
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
            else
            {
                return "You cannot sink into " + Substance.Name + " because it's not a liquid.";
            }
        }

        public static string Burning(Item item)
        {
            // Burning calculation:
            Console.WriteLine(item.Name + " " + item.ItemMaterial.BurnReaction + ".");
            if (item.ItemMaterial.BurnReaction == "vaporizes")
            {
                item.State = "gass";
                return item.Name + " vaporized into " + item.State + ".";
            }
            else if (item.ItemMaterial.BurnReaction == "burns" && item.State == "solid")
            {
                item.State = "ash";
                return item.Name + " burned into " + item.State + ".";
            }
            else if (item.ItemMaterial.BurnReaction == "burns")
            {
                item.State = "flames";
                return item.Name + " burned into " + item.State + ".";
            }
            else
            {
                return item.Name + " still " + item.ItemMaterial.BurnReaction + ".";
            }
        }

        static void Main(string[] args)
        {   
            // Creating the Materials
            Material stone = new Material("Stone", 2.55, "does nothing", false);
            Material wood = new Material("Wood", 0.75, "burns", false);
            Material iron = new Material("Iron", 7.87, "glows red", true);
            Material water = new Material("Water", 1, "vaporizes", true);
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
            Console.WriteLine(masterSword.Details());
            Console.WriteLine(glass.Details());
            Console.WriteLine(masterSword.Name);
            Console.WriteLine(masterSword.ItemMaterial.Name);
            Console.WriteLine(Burning(amountOfWater));
            Console.WriteLine(Burning(plank));
            Console.WriteLine(Burning(amountOfMercury));
            Console.WriteLine(Sinking(amountOfWater, SinkingSubstanceWater));
            Console.WriteLine(Sinking(mirror, SinkingSubstanceWater));
            Console.WriteLine(Sinking(littleRock, SinkingSubstanceMercury));
            Console.WriteLine(Sinking(littleRock, SinkingSubstanceWater));


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
