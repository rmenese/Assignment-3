//Created by: Remedios Meneses
//Student # : 300691712
//Last Mod : July 24, 2020 @ 5:45 PM
//Description: Classes and Interface
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            _type = type;
        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return (base.ToString() + "  The Giant Planet is " + _type);
        }
    }
}
