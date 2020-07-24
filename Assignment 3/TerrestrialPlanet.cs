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
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen;
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            _oxygen = oxygen;
        }
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public override string ToString()
        {
            return (base.ToString() + "  This Terrestrial Planet has oxygen " + _oxygen);
        }
    }
}