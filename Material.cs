using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementInteractions
{
    class Material
    {
        public string Name { get; set; }
        public double Density { get; set; }
        public string BurnReaction { get; set; }
        public bool Conduction { get; set; }
        

        //Constructor
        public Material(string name, double density, string burnreaction, bool conduction)
        {
            Name = name.ToLower();
            Density = (density * Math.Pow(10, 3));
            BurnReaction = burnreaction.ToLower();
            Conduction = conduction;
            
        }

        public string Details()
        {
            return "Material: " + Name + ", Density: " + Density.ToString() + ", Burn Reaction: " + BurnReaction + ", Conduction: " + Conduction.ToString();
        }
        
    }
}
